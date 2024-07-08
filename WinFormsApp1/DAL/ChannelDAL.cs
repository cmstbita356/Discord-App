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
	internal class ChannelDAL
	{
		private static ChannelDAL instance;
		private DataContext _dataContext;
		private readonly static object _lock = new object();
		private ChannelDAL()
		{
			_dataContext = new DataContext();
		}
		public static ChannelDAL GetInstance()
		{
			if (instance == null)
			{
				lock (_lock)
				{
					instance = new ChannelDAL();
				}
			}
			return instance;
		}
		public List<ChannelDTO> GetChannels(int roomId)
		{
			List<ChannelDTO> result = new List<ChannelDTO>();
			var listChannel = _dataContext.Channels.Where(c => c.RoomId == roomId).ToList();
			foreach ( Channel c in listChannel )
			{
				ChannelDTO channelDTO = new ChannelDTO(c.ChannelId, c.RoomId, c.ChannelName);
				result.Add(channelDTO);
			}
			return result;
		}
		public int GetId(int roomId, string channelName) 
		{
			var channel = _dataContext.Channels.Where(c => c.RoomId == roomId && c.ChannelName == channelName).SingleOrDefault();
			return channel.ChannelId;
		}
		public bool CreateChannel(int roomId, string channelName)
		{
			if (IsNameExisted(roomId, channelName)) return false;
			Channel c = new Channel();
			c.RoomId = roomId;
			c.ChannelName = channelName;

			_dataContext.Channels.Add(c);
			if (_dataContext.SaveChanges() > 0) return true;
			return false;
		}
		private bool IsNameExisted(int roomId, string channelName)
		{
			return _dataContext.Channels.Any(c => c.RoomId == roomId && c.ChannelName == channelName);

		}
	}
}
