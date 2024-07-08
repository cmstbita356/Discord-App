using DiscordApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordApp.DTO
{
	internal class UserDTO
	{
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public UserDTO()
        {
            
        }
        public UserDTO(User user)
        {
            UserId = user.UserId;
            Username = user.Username;
            Password = user.Password;
        }
    }
}
