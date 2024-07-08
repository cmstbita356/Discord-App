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
	internal class ChannelMessageDAL
	{
		private static ChannelMessageDAL instance;
		private DataContext _dataContext;
		private readonly static object _lock = new object();
		private ChannelMessageDAL()
		{
			_dataContext = new DataContext();
		}
		public static ChannelMessageDAL GetInstance()
		{
			if (instance == null)
			{
				lock (_lock)
				{
					instance = new ChannelMessageDAL();
				}
			}
			return instance;
		}
		public List<ChannelMessageDTO> GetMessages(int channelId)
		{
			List<ChannelMessageDTO> result = new List<ChannelMessageDTO>();
			var listCM = _dataContext.ChannelMessages.Where(cm => cm.ChannelId == channelId).ToList();
			foreach(ChannelMessage c in listCM)
			{
				ChannelMessageDTO channelMessageDTO = new ChannelMessageDTO(c);
				result.Add(channelMessageDTO);
			}
			return result;
		}
		public bool AddMessage(ChannelMessageDTO message)
		{
			if (message.Content == null || message.Content == string.Empty || message.Content.Length == 0)
			{
				return false;
			}
			else
			{
				ChannelMessage cm = new ChannelMessage();
				cm.SenderId = message.SenderId;
				cm.ChannelId = message.ChannelId;
				cm.Content = message.Content;
				cm.Timestamp = message.Timestamp;
				_dataContext.ChannelMessages.Add(cm);
				if (_dataContext.SaveChanges() > 0) return true;
				return false;
			}
		}
	}
}
