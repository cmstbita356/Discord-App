using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordApp.DTO
{
	internal class RoomDTO
	{
		public RoomDTO(int roomId, int masterId, string roomName)
		{
			RoomId = roomId;
			MasterId = masterId;
			RoomName = roomName;
		}

		public int RoomId { get; set; }
		public int MasterId { get; set; }
		public string RoomName { get; set; }

	}
}
