using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordApp.Models
{
	internal class User
	{
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public ICollection<PrivateMessage> PrivateSenderMessages { get; set; }
		public ICollection<PrivateMessage> PrivateRecieverMessages { get; set; }

		public ICollection<ChannelMessage> ChannelMessages { get; set; }
        //public ICollection<Room> Rooms { get; set; }
        public ICollection<RoomMembership> RoomMemberships { get; set; }
    }
}
