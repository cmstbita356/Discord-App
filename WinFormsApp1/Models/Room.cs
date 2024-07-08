using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordApp.Models
{
	internal class Room
	{
        public int RoomId { get; set; }
        public int MasterId { get; set; }
        public string RoomName { get; set; }
		//public ICollection<User> Users { get; set; }
		public ICollection<RoomMembership> RoomMemberships { get; set; }

		public ICollection<Channel> Channels { get; set; }
    }
}
