using DiscordApp.Data;
using DiscordApp.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models;

namespace WinFormsApp1.DAL
{
	internal class FriendDAL
	{
		private static FriendDAL instance;
		private DataContext _dataContext;
		private readonly static object _lock = new object();
		private FriendDAL()
		{
			_dataContext = new DataContext();
		}
		public static FriendDAL GetInstance()
		{
			if (instance == null)
			{
				lock (_lock)
				{
					instance = new FriendDAL();
				}
			}
			return instance;
		}
		public Friend GetFriend(int userId, int friendId)
		{
			Friend friend = _dataContext.Friends.Where(f => f.UserId == userId && f.FriendId == friendId).SingleOrDefault();
			return friend;
		}
		public List<UserDTO> GetFriendList(string username)
		{
			int userid = UserDAL.GetInstance().GetIdWithUsername(username);
			List<Friend> friends = GetFriends(userid);
			List<UserDTO> result = new List<UserDTO>();
			foreach(Friend f in friends)
			{
				UserDTO userDTO = UserDAL.GetInstance().GetUserWithId(f.FriendId);
				result.Add(userDTO);
			}
			return result;
		}
		public List<UserDTO> GetPendingList(string username)
		{
			int userid = UserDAL.GetInstance().GetIdWithUsername(username);
			List<Friend> friends = GetPending(userid);
			List<UserDTO> result = new List<UserDTO>();
			foreach (Friend f in friends)
			{
				UserDTO userDTO = UserDAL.GetInstance().GetUserWithId(f.FriendId);
				result.Add(userDTO);
			}
			return result;
		}
		public List<UserDTO> GetAskingList(string username)
		{
			int userid = UserDAL.GetInstance().GetIdWithUsername(username);
			List<Friend> friends = GetAsking(userid);
			List<UserDTO> result = new List<UserDTO>();
			foreach (Friend f in friends)
			{
				UserDTO userDTO = UserDAL.GetInstance().GetUserWithId(f.UserId);
				result.Add(userDTO);
			}
			return result;
		}
		public string GetStatus(int userId, int friendId)
		{
			Friend friend = GetFriend(userId, friendId);
			if(friend == null)
			{
				return "none";
			}
			else
			{
				string result = friend.Status;
				return result;
			}
		}
		public bool AskingFriend(int userId, int friendId)
		{
			Friend f = new Friend();
			f.UserId = userId;
			f.FriendId = friendId;
			f.Status = "pending";

			_dataContext.Add(f);
			if (_dataContext.SaveChanges() > 0) return true;
			return false;
		}
		public bool AcceptFriend(int whoAskId, int userId)
		{
			Friend user = GetFriend(whoAskId, userId);
			user.Status = "accepted";

			Friend f = new Friend();
			f.UserId = userId;
			f.FriendId = whoAskId;
			f.Status = "accepted";
			_dataContext.Add(f);

			if (_dataContext.SaveChanges() > 0) return true;
			return false;
		}
		public bool DeleteAsking(int whoAskId, int userId)
		{
			Friend asking = GetFriend(whoAskId, userId);
			_dataContext.Friends.Remove(asking);
			if (_dataContext.SaveChanges() > 0) return true;
			return false;
		}
		private List<Friend> GetFriends(int userid)
		{
			var result = _dataContext.Friends.Where(f => f.UserId == userid && f.Status == "accepted").ToList();
			return result;
		}
		private List<Friend> GetPending(int userid)
		{
			var result = _dataContext.Friends.Where(f => f.UserId == userid && f.Status == "pending").ToList();
			return result;
		}
		private List<Friend> GetAsking(int userid)
		{
			var result = _dataContext.Friends.Where(f => f.FriendId == userid && f.Status == "pending").ToList();
			return result;
		}
	}
}
