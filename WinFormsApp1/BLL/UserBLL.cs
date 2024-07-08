using DiscordApp.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.DAL;

namespace WinFormsApp1.BLL
{
	internal class UserBLL
	{
		private static UserBLL instance;
		private static readonly object _lock = new object();
		private UserBLL() { }
		public static UserBLL GetInstance()
		{
			if (instance == null)
			{
				lock(_lock)
				{
					instance = new UserBLL();
				}
			}
			return instance;
		}
		public UserDTO GetUserWithId(int userid)
		{
			return UserDAL.GetInstance().GetUserWithId(userid);
		}
		public int GetIdWithUsername(string username)
		{
			return UserDAL.GetInstance().GetIdWithUsername(username);
		}
		public string GetUsernameWithId(int id)
		{
			return UserDAL.GetInstance().GetUsernameWithId(id);
		}
		public List<UserDTO> GetListNoFriendWithWord(string words)
		{
			string username = Properties.Settings.Default.LoggedUsername;
			int userId = GetIdWithUsername(username);
			return UserDAL.GetInstance().GetListNoFriendWithWord(userId, words);
		}
		public List<UserDTO> GetListNoRoomWithWord(int roomId, string words)
		{
			return UserDAL.GetInstance().GetListNoRoomWithWord(roomId, words);
		}
		public bool Register(string username, string password, string repassword)
		{
			return UserDAL.GetInstance().Register(username, password, repassword);
		}
		public bool Login(string username, string password)
		{
			return UserDAL.GetInstance().Login(username, password);
		}
	}
}
