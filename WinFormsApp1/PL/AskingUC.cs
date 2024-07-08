using DiscordApp.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.BLL;

namespace WinFormsApp1.PL
{
	public partial class AskingUC : UserControl
	{
		public AskingUC()
		{
			InitializeComponent();
			ShowAskingFriendList();
			ShowAskingRoomList();
		}
		private void ShowAskingRoomList()
		{
			List<RoomDTO> list = RoomMembershipBLL.GetInstance().GetAsking();
			int d = 0;
			for (int i = 0; i < list.Count; i++)
			{
				RoomDTO room = list[i];
				// Panel
				Panel panel = new Panel();
				panel.Location = new Point(0, 0 + d);
				panel.Size = new Size(188, 52);
				panel.AutoSize = true;
				pnRoom.Controls.Add(panel);
				d += 100;

				// ptbUser
				PictureBox ptbUser = new PictureBox();
				ptbUser.BackgroundImage = Properties.Resources.User_icon;
				ptbUser.BackgroundImageLayout = ImageLayout.Stretch;
				ptbUser.Location = new Point(0, 0);
				ptbUser.Size = new Size(80, 75);
				panel.Controls.Add(ptbUser);

				// lbUsername
				Label lbUsername = new Label();
				lbUsername.Text = room.RoomName;
				lbUsername.Font = new Font("Segoe UI", 11);
				lbUsername.ForeColor = Color.Navy;
				lbUsername.Location = new Point(90, 28);
				panel.Controls.Add(lbUsername);

				// ptbAccept
				PictureBox ptbAccept = new PictureBox();
				ptbAccept.BackgroundImage = Properties.Resources.Accept_icon;
				ptbAccept.BackgroundImageLayout = ImageLayout.Stretch;
				ptbAccept.Location = new Point(247, 0);
				ptbAccept.Size = new Size(41, 40);
				ptbAccept.Click += PtbAccept_Click;
				panel.Controls.Add(ptbAccept);

				// ptbReject
				PictureBox ptbReject = new PictureBox();
				ptbReject.BackgroundImage = Properties.Resources.Reject_icon;
				ptbReject.BackgroundImageLayout = ImageLayout.Stretch;
				ptbReject.Location = new Point(247, 40);
				ptbReject.Size = new Size(41, 40);
				ptbReject.Click += PtbReject_Click;
				panel.Controls.Add(ptbReject);


				void PtbAccept_Click(object? sender, EventArgs e)
				{
					RoomMembershipBLL.GetInstance().AcceptAsking(room.RoomId);
					CleanPanel(pnRoom);
					ShowAskingRoomList();
				}
				void PtbReject_Click(object? sender, EventArgs e)
				{
					RoomMembershipBLL.GetInstance().RejectAsking(room.RoomId);
					CleanPanel(pnRoom);
					ShowAskingRoomList();
				}
			}
		}
		private void ShowAskingFriendList()
		{
			List<UserDTO> list = FriendBLL.GetInstance().GetAskingList();
			int d = 0;
			for (int i = 0; i < list.Count; i++)
			{
				UserDTO user = list[i];
				// Panel
				Panel panel = new Panel();
				panel.Location = new Point(0, 0 + d);
				panel.Size = new Size(188, 52);
				panel.AutoSize = true;
				pnFriend.Controls.Add(panel);
				d += 100;

				// ptbUser
				PictureBox ptbUser = new PictureBox();
				ptbUser.BackgroundImage = Properties.Resources.User_icon;
				ptbUser.BackgroundImageLayout = ImageLayout.Stretch;
				ptbUser.Location = new Point(0, 0);
				ptbUser.Size = new Size(80, 75);
				panel.Controls.Add(ptbUser);

				// lbUsername
				Label lbUsername = new Label();
				lbUsername.Text = user.Username;
				lbUsername.Font = new Font("Segoe UI", 11);
				lbUsername.ForeColor = Color.Navy;
				lbUsername.Location = new Point(90, 28);
				panel.Controls.Add(lbUsername);

				// ptbAccept
				PictureBox ptbAccept = new PictureBox();
				ptbAccept.BackgroundImage = Properties.Resources.Accept_icon;
				ptbAccept.BackgroundImageLayout = ImageLayout.Stretch;
				ptbAccept.Location = new Point(247, 0);
				ptbAccept.Size = new Size(41, 40);
				ptbAccept.Click += PtbAccept_Click;
				panel.Controls.Add(ptbAccept);

				// ptbReject
				PictureBox ptbReject = new PictureBox();
				ptbReject.BackgroundImage = Properties.Resources.Reject_icon;
				ptbReject.BackgroundImageLayout = ImageLayout.Stretch;
				ptbReject.Location = new Point(247, 40);
				ptbReject.Size = new Size(41, 40);
				ptbReject.Click += PtbReject_Click;
				panel.Controls.Add(ptbReject);


				void PtbAccept_Click(object? sender, EventArgs e)
				{
					FriendBLL.GetInstance().AcceptFriend(user.Username);
					CleanPanel(pnFriend);
					ShowAskingFriendList();
				}
				void PtbReject_Click(object? sender, EventArgs e)
				{
					FriendBLL.GetInstance().DeleteAsking(user.Username);
					CleanPanel(pnFriend);
					ShowAskingFriendList();
				}
			}
		}
		private void CleanPanel(Panel panel)
		{
			do
			{
				foreach (Control c in panel.Controls)
				{
					panel.Controls.Remove(c);
				}
			}
			while (panel.Controls.Count != 0);
		}
	}
}
