using DiscordApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordApp.DTO
{
	internal class PrivateMessageDTO
	{
		public int MessageId { get; set; }
        public int SenderId { get; set; }
        public int RecieverId { get; set; }
        public string Content { get; set; }
        public DateTime TimeStamp { get; set; }
        public PrivateMessageDTO()
        {
            
        }
        public PrivateMessageDTO(PrivateMessage pm)
        {
            MessageId = pm.MessageId;
            SenderId = pm.SenderId;
            RecieverId = pm.RecieverId;
            Content = pm.Content;
            TimeStamp = pm.TimeStamp;
        }
    }
}
