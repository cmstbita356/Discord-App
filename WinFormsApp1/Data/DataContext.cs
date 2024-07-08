using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiscordApp.Models;
using WinFormsApp1.Models;

namespace DiscordApp.Data
{
	internal class DataContext : DbContext
	{
        public DataContext()
        {
            
        }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
        public DbSet<Channel> Channels { get; set; }
        public DbSet<ChannelMessage> ChannelMessages { get; set; }
        public DbSet<PrivateMessage> PrivateMessages { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Friend> Friends { get; set; }
        public DbSet<RoomMembership> RoomMembership { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Data Source=.\\BITA;Initial Catalog=Discord;Integrated Security=True;Trust Server Certificate=True");
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
            modelBuilder.Entity<Channel>(e =>
            {
                e.HasKey(channel => channel.ChannelId);

                e.HasMany(c => c.ChannelMessages)
                .WithOne(cm => cm.Channel)
                .HasForeignKey(cm => cm.ChannelId);
            });
            modelBuilder.Entity<Room>(e =>
            {
                e.HasKey(r => r.RoomId);

                e.HasMany(r => r.Channels)
                .WithOne(c => c.Room)
                .HasForeignKey(c => c.RoomId);

                /*e.HasMany(r => r.Users)
                .WithMany(u => u.Rooms)
                .UsingEntity(t => t.ToTable("RoomMembership"));*/
            });
            modelBuilder.Entity<User>(e =>
            {
                e.HasKey(u => u.UserId);

                e.HasMany(u => u.PrivateSenderMessages)
                .WithOne(pm => pm.Sender)
                .HasForeignKey(pm => pm.SenderId)
                .OnDelete(DeleteBehavior.NoAction);

				e.HasMany(u => u.PrivateRecieverMessages)
                .WithOne(pm => pm.Reciever)
                .HasForeignKey(pm => pm.RecieverId)
				.OnDelete(DeleteBehavior.NoAction);

				e.HasMany(u => u.ChannelMessages)
                .WithOne(cm => cm.User)
                .HasForeignKey(cm => cm.SenderId);

			});
            modelBuilder.Entity<RoomMembership>(e =>
            {
                e.HasKey(rm => new { rm.UserId, rm.RoomId });

                e.HasOne(rm => rm.User)
                .WithMany(u => u.RoomMemberships)
                .HasForeignKey(rm => rm.UserId);

                e.HasOne(rm => rm.Room)
                .WithMany(r => r.RoomMemberships)
                .HasForeignKey(rm => rm.RoomId);
            });
            modelBuilder.Entity<PrivateMessage>(e =>
            {
                e.HasKey(pm => pm.MessageId);
            });
			modelBuilder.Entity<ChannelMessage>(e =>
			{
				e.HasKey(cm => cm.MessageId);
			});
            modelBuilder.Entity<Friend>(e =>
            {
                e.HasKey(f => new { f.UserId, f.FriendId });

                e.HasOne<User>().WithMany()
                .HasForeignKey(f => f.UserId)
				.OnDelete(DeleteBehavior.NoAction);

				e.HasOne<User>().WithMany()
                .HasForeignKey(f => f.FriendId)
				.OnDelete(DeleteBehavior.NoAction);
			});


		}
	}
}
