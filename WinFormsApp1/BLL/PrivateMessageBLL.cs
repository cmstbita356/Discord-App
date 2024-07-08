using DiscordApp.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.DAL;

namespace WinFormsApp1.BLL
{
	internal class PrivateMessageBLL
	{
		private static PrivateMessageBLL instance;
		private static readonly object _lock = new object();
		private PrivateMessageBLL() { }
		public static PrivateMessageBLL GetInstance()
		{
			if (instance == null)
			{
				lock (_lock)
				{
					instance = new PrivateMessageBLL();
				}
			}
			return instance;
		}
		public List<PrivateMessageDTO> GetList(int senderId, int recieverId)
		{
			return PrivateMessageDAL.GetInstance().GetList(senderId, recieverId);
		}
		public bool AddMessage(int senderId, int recieverId, string content)
		{
			PrivateMessageDTO message = new PrivateMessageDTO();
			message.SenderId = senderId;
			message.RecieverId = recieverId;
			message.Content = content;
			message.TimeStamp = DateTime.Now;
			return PrivateMessageDAL.GetInstance().AddMessage(message);
		}
	}
}
