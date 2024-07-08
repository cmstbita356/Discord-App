using DiscordApp.DTO;
using DiscordApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.DAL;

namespace WinFormsApp1.BLL
{
	internal class RoomBLL
	{
		private static RoomBLL instance;
		private static readonly object _lock = new object();
		string username = Properties.Settings.Default.LoggedUsername;
		private RoomBLL() { }
		public static RoomBLL GetInstance()
		{
			if (instance == null)
			{
				lock (_lock)
				{
					instance = new RoomBLL();
				}
			}
			return instance;
		}
		public RoomDTO GetRoomWithId(int roomId)
		{
			return RoomDAL.GetInstance().GetRoomWithId(roomId);
		}
		public int GetRoomIdWithRoomName(string roomName)
		{
			int userId = UserBLL.GetInstance().GetIdWithUsername(username);
			return RoomDAL.GetInstance().GetRoomIdWithRoomName(userId, roomName);
		}
		public Room GetRoomUserCreate(string roomName)
		{
			int userId = UserBLL.GetInstance().GetIdWithUsername(username);
			return RoomDAL.GetInstance().GetRoomUserCreate(userId, roomName);

		}
		public bool CreateRoom(string roomName)
		{
			int masterId = UserBLL.GetInstance().GetIdWithUsername(username);
			return RoomDAL.GetInstance().CreateRoom(roomName, masterId);
		}
		public bool IsMaster(int roomId)
		{
			int userId = UserBLL.GetInstance().GetIdWithUsername(username);
			return RoomDAL.GetInstance().IsMaster(roomId, userId);

		}
	}
}
