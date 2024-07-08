using DiscordApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordApp.DTO
{
	internal class ChannelMessageDTO
	{
		public ChannelMessageDTO(ChannelMessage cm)
		{
			MessageId = cm.MessageId;
			SenderId = cm.SenderId;
			ChannelId = cm.ChannelId;
			Content = cm.Content;
			Timestamp = cm.Timestamp;
		}
        public ChannelMessageDTO()
        {
            
        }
        public int MessageId { get; set; }
        public int SenderId { get; set; }
        public int ChannelId { get; set; }
        public string Content { get; set; }
        public DateTime Timestamp { get; set; }

    }
}
