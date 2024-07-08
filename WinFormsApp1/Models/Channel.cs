using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordApp.Models
{
	internal class Channel
	{
        public int ChannelId { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set; }
        public string ChannelName { get; set; }
        public ICollection<ChannelMessage> ChannelMessages { get; set; }
    }
}
