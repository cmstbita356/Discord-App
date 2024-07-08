using DiscordApp.Data;
using DiscordApp.DTO;
using DiscordApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.DAL
{
	internal class RoomDAL
	{
		private static RoomDAL instance;
		private DataContext _dataContext;
		private readonly static object _lock = new object();
		private RoomDAL()
		{
			_dataContext = new DataContext();
		}
		public static RoomDAL GetInstance()
		{
			if (instance == null)
			{
				lock (_lock)
				{
					instance = new RoomDAL();
				}
			}
			return instance;
		}
		public RoomDTO GetRoomWithId(int roomId)
		{
			var r = _dataContext.Rooms.Where(r => r.RoomId == roomId).SingleOrDefault();
			RoomDTO roomDTO = new RoomDTO(r.RoomId, r.MasterId, r.RoomName);
			return roomDTO;
		}
		public int GetRoomIdWithRoomName(int userId, string roomName)
		{
			var listRoom = RoomMembershipDAL.GetInstance().GetRooms(userId);
			foreach (RoomDTO room in listRoom)
			{
				if (room.RoomName == roomName) return room.RoomId;
			}
			return 0;
		}
		public Room GetRoomUserCreate(int userId, string roomName)
		{
			Room room = _dataContext.Rooms.Where(r => r.MasterId == userId && r.RoomName == roomName).SingleOrDefault();
			return room;
		}
		public bool CreateRoom(string roomName, int masterId)
		{
			if (IsNameExisted(masterId, roomName)) 
				return false;
			Room r = new Room();
			r.RoomName = roomName;
			r.MasterId = masterId;

			_dataContext.Rooms.Add(r);
			if (_dataContext.SaveChanges() > 0) return true;
			return false;
		}
		public bool IsMaster(int roomId, int userId)
		{
			var room = GetRoomWithId(roomId);
			if(room == null) return false;
			if (room.MasterId == userId) return true;
			return false;
		}
		private bool IsNameExisted(int masterId, string roomName)
		{
			return _dataContext.Rooms.Any(r => r.MasterId == masterId && r.RoomName == roomName);
		}
	}
}
