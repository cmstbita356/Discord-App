using DiscordApp.Data;
using DiscordApp.DTO;
using DiscordApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp1.DAL
{
	internal class UserDAL
	{
		private static UserDAL instance;
		private DataContext _dataContext;
		private readonly static object _lock = new object();
		private UserDAL()
		{
			_dataContext = new DataContext();
		}
		public static UserDAL GetInstance()
		{
			if (instance == null)
			{
				lock (_lock)
				{
					instance = new UserDAL();
				}
			}
			return instance;
		}
		public UserDTO GetUserWithId(int userid)
		{
			var result = _dataContext.Users.Where(u => u.UserId == userid).SingleOrDefault();
			UserDTO userDTO = new UserDTO(result);
			return userDTO;
		}
		public int GetIdWithUsername(string username)
		{
			var user = _dataContext.Users.Where(u => u.Username == username).SingleOrDefault();
			return user.UserId;
		}
		public string GetUsernameWithId(int id)
		{
			var user = _dataContext.Users.Where(u => u.UserId == id).SingleOrDefault();
			return user.Username;
		}
		public List<UserDTO> GetListNoFriendWithWord(int userId, string words)
		{
			var list = _dataContext.Users.Where(u => u.Username.Contains(words)).ToList();
			List<UserDTO> result = new List<UserDTO>();
			foreach(User u in list)
			{
				bool isFriend = FriendDAL.GetInstance().GetFriend(userId, u.UserId) != null;
				if (isFriend)
					continue;
				if (u.UserId == userId)
					continue;
				
				UserDTO userDTO = new UserDTO(u);
				result.Add(userDTO);
			}
			return result;
		}
		public List<UserDTO> GetListNoRoomWithWord(int roomId, string words)
		{
			var list = _dataContext.Users.Where(u => u.Username.Contains(words)).ToList();
			List<UserDTO> result = new List<UserDTO>();
			foreach (User u in list)
			{
				bool isMember = RoomMembershipDAL.GetInstance().IsRoomMember(u.UserId, roomId);
				if (isMember)
					continue;

				UserDTO userDTO = new UserDTO(u);
				result.Add(userDTO);
			}
			return result;
		}
		public bool Register(string username, string password, string repassword)
		{
			if (password != repassword) return false;
			if(IsExisted(username))
			{
				return false;
			}
			else
			{
				User user = new User();
				user.Username = username;
				user.Password = password;
				_dataContext.Add(user);
				if(_dataContext.SaveChanges() > 0)
					return true;
				return false;
			}
		}
		public bool Login(string username, string password)
		{
			if(IsExisted(username))
			{
				Properties.Settings.Default.LoggedUsername = username;
				return true;
			}
			else
			{
				return false;
			}
		}
		private bool IsExisted(string username)
		{
			var result = _dataContext.Users.Any(u => u.Username == username);
			return result;
		}

		
	}
}
