using DiscordApp.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.DAL;
using WinFormsApp1.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp1.BLL
{
	internal class FriendBLL
	{
		private static FriendBLL instance;
		private static readonly object _lock = new object();
		private FriendBLL() { }
		public static FriendBLL GetInstance()
		{
			if (instance == null)
			{
				lock (_lock)
				{
					instance = new FriendBLL();
				}
			}
			return instance;
		}
		public Friend GetFriend(string friendUsername)
		{
			string username = Properties.Settings.Default.LoggedUsername;
			int userid = UserBLL.GetInstance().GetIdWithUsername(username);
			int friendId = UserBLL.GetInstance().GetIdWithUsername(friendUsername);
			return FriendDAL.GetInstance().GetFriend(userid, friendId);
		}
		public List<UserDTO> GetFriendList()
		{
			string username = Properties.Settings.Default.LoggedUsername;
			return FriendDAL.GetInstance().GetFriendList(username);
		}
		public List<UserDTO> GetPendingList()
		{
			string username = Properties.Settings.Default.LoggedUsername;
			return FriendDAL.GetInstance().GetPendingList(username);
		}
		public List<UserDTO> GetAskingList()
		{
			string username = Properties.Settings.Default.LoggedUsername;
			return FriendDAL.GetInstance().GetAskingList(username);
		}
		public string GetStatus(string friendUsername)
		{
			string username = Properties.Settings.Default.LoggedUsername;
			int userid = UserBLL.GetInstance().GetIdWithUsername(username);
			int friendId = UserBLL.GetInstance().GetIdWithUsername(friendUsername);
			return FriendDAL.GetInstance().GetStatus(userid, friendId);
		}
		public bool AskingFriend(string whosAskUsername)
		{
			string username = Properties.Settings.Default.LoggedUsername;
			int userid = UserBLL.GetInstance().GetIdWithUsername(username);
			int friendId = UserBLL.GetInstance().GetIdWithUsername(whosAskUsername);
			return FriendDAL.GetInstance().AskingFriend(userid, friendId);
		}
		public bool AcceptFriend(string whosAskUsername)
		{
			string username = Properties.Settings.Default.LoggedUsername;
			int whoAskId = UserBLL.GetInstance().GetIdWithUsername(whosAskUsername);
			int userId = UserBLL.GetInstance().GetIdWithUsername(username);
			return FriendDAL.GetInstance().AcceptFriend(whoAskId, userId);
		}
		public bool DeleteAsking(string whosAskUsername)
		{
			string username = Properties.Settings.Default.LoggedUsername;
			int whoAskId = UserBLL.GetInstance().GetIdWithUsername(whosAskUsername);
			int userId = UserBLL.GetInstance().GetIdWithUsername(username);
			return FriendDAL.GetInstance().DeleteAsking(whoAskId, userId);

		}
	}
}
