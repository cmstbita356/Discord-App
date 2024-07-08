using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordApp.DTO
{
	internal class ChannelDTO
	{
		public ChannelDTO(int channelId, int roomId, string channelName)
		{
			ChannelId = channelId;
			RoomId = roomId;
			ChannelName = channelName;
		}

		public int ChannelId { get; set; }
        public int RoomId { get; set; }
        public string ChannelName { get; set; }
    }
}
