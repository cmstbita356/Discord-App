using DiscordApp.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.DAL;

namespace WinFormsApp1.BLL
{
	internal class RoomMembershipBLL
	{
		private static RoomMembershipBLL instance;
		private static readonly object _lock = new object();
		string username = Properties.Settings.Default.LoggedUsername;
		private RoomMembershipBLL() { }
		public static RoomMembershipBLL GetInstance()
		{
			if (instance == null)
			{
				lock (_lock)
				{
					instance = new RoomMembershipBLL();
				}
			}
			return instance;
		}
		public List<RoomDTO> GetRooms()
		{
			int userId = UserBLL.GetInstance().GetIdWithUsername(username);
			return RoomMembershipDAL.GetInstance().GetRooms(userId);
		}
		public List<RoomDTO> GetAsking()
		{
			int userId = UserBLL.GetInstance().GetIdWithUsername(username);
			return RoomMembershipDAL.GetInstance().GetAsking(userId);
		}
		public bool AcceptAsking(int roomId)
		{
			int userId = UserBLL.GetInstance().GetIdWithUsername(username);
			return RoomMembershipDAL.GetInstance().AcceptAsking(roomId, userId);
		}
		public bool RejectAsking(int roomId)
		{
			int userId = UserBLL.GetInstance().GetIdWithUsername(username);
			return RoomMembershipDAL.GetInstance().RejectAsking(roomId, userId);

		}
		public bool AddMember(int roomId, int userId)
		{
			return RoomMembershipDAL.GetInstance().AddMember(roomId, userId);
		}
		public bool AskingMember(int roomId, int userId)
		{
			return RoomMembershipDAL.GetInstance().AskingMember(roomId, userId);
		}
		public bool IsRoomMember(int checkUser, int roomId)
		{
			return RoomMembershipDAL.GetInstance().IsRoomMember(checkUser, roomId);
		}
	}
}
