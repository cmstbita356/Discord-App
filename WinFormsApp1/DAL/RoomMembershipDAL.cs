using DiscordApp.Data;
using DiscordApp.DTO;
using DiscordApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.BLL;

namespace WinFormsApp1.DAL
{
	internal class RoomMembershipDAL
	{
		private static RoomMembershipDAL instance;
		private DataContext _dataContext;
		private readonly static object _lock = new object();
		private RoomMembershipDAL()
		{
			_dataContext = new DataContext();
		}
		public static RoomMembershipDAL GetInstance()
		{
			if (instance == null)
			{
				lock (_lock)
				{
					instance = new RoomMembershipDAL();
				}
			}
			return instance;
		}
		public List<RoomDTO> GetRooms(int userId)
		{
			List<RoomDTO> result = new List<RoomDTO>();
			List<int> listRoomId = new List<int>();
			var listRoom = _dataContext.RoomMembership.Where(rm => rm.UserId == userId && rm.status == "accepted").ToList();
			foreach (RoomMembership rm in listRoom)
			{
				if (listRoomId.Contains(rm.RoomId)) continue;
				listRoomId.Add(rm.RoomId);
				RoomDTO roomDTO = RoomDAL.GetInstance().GetRoomWithId(rm.RoomId);
				result.Add(roomDTO);
			}
			return result;
		}
		public List<RoomDTO> GetAsking(int userId)
		{
			List<RoomDTO> result = new List<RoomDTO>();
			var list = _dataContext.RoomMembership.Where(rm => rm.UserId == userId && rm.status == "pending").ToList();
			foreach(RoomMembership rm in list)
			{
				RoomDTO room = RoomBLL.GetInstance().GetRoomWithId(rm.RoomId);
				result.Add(room);
			}
			return result;
		}
		public bool AcceptAsking(int roomId, int userId)
		{
			var roomMember = _dataContext.RoomMembership.Where(rm => rm.RoomId == roomId && rm.UserId == userId && rm.status == "pending").SingleOrDefault();
			if (roomMember != null)
			{ 
				roomMember.status = "accepted";
				if (_dataContext.SaveChanges() > 0) return true;
				return false;
			}
			return false;
		}
		public bool RejectAsking(int roomId, int userId)
		{
			var roomMember = _dataContext.RoomMembership.Where(rm => rm.RoomId == roomId && rm.UserId == userId && rm.status == "pending").SingleOrDefault();
			_dataContext.RoomMembership.Remove(roomMember);
			if (_dataContext.SaveChanges() > 0) return true;
			return false;
		}
		public bool AddMember(int roomId, int userId)
		{
			RoomDTO r = RoomDAL.GetInstance().GetRoomWithId(roomId);
			if (IsRoomNameExisted(userId, r.RoomName)) return false;
			RoomMembership rm = new RoomMembership();
			rm.RoomId = roomId;
			rm.UserId = userId;
			rm.status = "accepted";

			_dataContext.Add(rm);
			if (_dataContext.SaveChanges() > 0) return true;
			return false;
		}
		public bool AskingMember(int roomId, int userId)
		{
			RoomDTO r = RoomDAL.GetInstance().GetRoomWithId(roomId);
			if (IsRoomNameExisted(userId, r.RoomName)) return false;
			RoomMembership rm = new RoomMembership();
			rm.RoomId = roomId;
			rm.UserId = userId;
			rm.status = "pending";

			_dataContext.Add(rm);
			if (_dataContext.SaveChanges() > 0) return true;
			return false;
		}
		public bool IsRoomMember(int checkUser, int roomId)
		{
			return _dataContext.RoomMembership.Any(rm => rm.UserId == checkUser && rm.RoomId == roomId);
		}
		public bool IsRoomNameExisted(int userId, string roomName)
		{
			var listRoomUserIn = GetRooms(userId);
			List<string> listRoomName = new List<string>();
			foreach(RoomDTO r in listRoomUserIn)
			{
				listRoomName.Add(r.RoomName);
			}
			if(listRoomName.Contains(roomName))
			{
				return true;
			}
			return false;
		}
		
	}
}
