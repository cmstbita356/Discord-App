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
	internal class PrivateMessageDAL
	{
		private static PrivateMessageDAL instance;
		private DataContext _dataContext;
		private readonly static object _lock = new object();
		private PrivateMessageDAL()
		{
			_dataContext = new DataContext();
		}
		public static PrivateMessageDAL GetInstance()
		{
			if (instance == null)
			{
				lock (_lock)
				{
					instance = new PrivateMessageDAL();
				}
			}
			return instance;
		}
		public List<PrivateMessageDTO> GetList(int senderId, int recieverId)
		{
			List<PrivateMessageDTO> result = new List<PrivateMessageDTO>();
			var listPM = _dataContext.PrivateMessages.Where(pm => pm.SenderId == senderId && pm.RecieverId == recieverId).ToList();
			foreach(PrivateMessage pm in listPM)
			{
				PrivateMessageDTO pmDTO = new PrivateMessageDTO(pm);
				result.Add(pmDTO);
			}
			return result;
		}
		public bool AddMessage(PrivateMessageDTO message)
		{
			if(message.Content == null || message.Content == string.Empty || message.Content.Length == 0)
			{
				return false;
			}
			else
			{
				PrivateMessage pm = new PrivateMessage();
				pm.SenderId = message.SenderId;
				pm.RecieverId = message.RecieverId;
				pm.Content = message.Content;
				pm.TimeStamp = message.TimeStamp;
				_dataContext.PrivateMessages.Add(pm);
				if (_dataContext.SaveChanges() > 0) return true;
				return false;
			}
		}
	}
}
