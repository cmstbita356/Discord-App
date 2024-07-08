using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordApp.Models
{
	internal class RoomMembership
	{
        public int RoomId { get; set; }
        public Room Room { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public string status { get; set; }
    }
}
