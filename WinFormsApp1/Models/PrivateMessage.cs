using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordApp.Models
{
	internal class PrivateMessage
	{
		public int MessageId { get; set; }
        public int SenderId { get; set; }
        public User Sender { get; set; }
        public int RecieverId { get; set; }
        public User Reciever { get; set; }
        public string Content { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
