using DiscordApp.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.DAL;

namespace WinFormsApp1.BLL
{
	internal class ChannelBLL
	{
		private static ChannelBLL instance;
		private static readonly object _lock = new object();
		private ChannelBLL() { }
		public static ChannelBLL GetInstance()
		{
			if (instance == null)
			{
				lock (_lock)
				{
					instance = new ChannelBLL();
				}
			}
			return instance;
		}
		public List<ChannelDTO> GetChannels(int roomId)
		{
			return ChannelDAL.GetInstance().GetChannels(roomId);
		}
		public int GetId(int roomId, string channelName)
		{
			return ChannelDAL.GetInstance().GetId(roomId, channelName);
		}
		public bool CreateChannel(int roomId, string channelName) 
		{
			return ChannelDAL.GetInstance().CreateChannel(roomId, channelName);
		}
	}
}
