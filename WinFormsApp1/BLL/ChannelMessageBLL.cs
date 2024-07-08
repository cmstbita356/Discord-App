using DiscordApp.Data;
using DiscordApp.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.DAL;

namespace WinFormsApp1.BLL
{
	internal class ChannelMessageBLL
	{
		private static ChannelMessageBLL instance;
		private DataContext _dataContext;
		private readonly static object _lock = new object();
		private ChannelMessageBLL()
		{
			_dataContext = new DataContext();
		}
		public static ChannelMessageBLL GetInstance()
		{
			if (instance == null)
			{
				lock (_lock)
				{
					instance = new ChannelMessageBLL();
				}
			}
			return instance;
		}
		public List<ChannelMessageDTO> GetMessages(int channelId)
		{
			return ChannelMessageDAL.GetInstance().GetMessages(channelId);
		}
		public bool AddMessage(int senderId, int channelId, string content)
		{
			ChannelMessageDTO message = new ChannelMessageDTO();
			message.SenderId = senderId;
			message.ChannelId = channelId;
			message.Content = content;
			message.Timestamp = DateTime.Now;
			return ChannelMessageDAL.GetInstance().AddMessage(message);
		}
	}
}
