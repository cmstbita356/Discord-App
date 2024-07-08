using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordApp.Models
{
	internal class ChannelMessage
	{
        public int MessageId { get; set; }
        public int SenderId { get; set; }
        public int ChannelId { get; set; }
        public User User { get; set; }
        public Channel Channel { get; set; }
        public string Content { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
