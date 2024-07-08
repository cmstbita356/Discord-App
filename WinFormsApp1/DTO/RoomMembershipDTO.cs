using DiscordApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordApp.DTO
{
	internal class RoomMembershipDTO
	{
		public RoomMembershipDTO(RoomMembership rm)
		{
			RoomId = rm.RoomId;
			UserId = rm.UserId;
		}

		public int RoomId { get; set; }
        public int UserId { get; set; }
    }
}
