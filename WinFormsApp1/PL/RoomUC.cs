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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp1.PL
{
	public partial class RoomUC : UserControl
	{
		string roomName = "";
		string channelName = "";
		int d_message = 0;
		string username = Properties.Settings.Default.LoggedUsername;
		public RoomUC()
		{
			InitializeComponent();
			ptbAddChannel.Visible = false;
			ShowRoomList();
			btSend.Enabled = false;
			btInvite.Visible = false;
			ptbAddChannel.Visible = false;
		}

		private void ShowRoomList()
		{
			CleanPanel(pnListRoom);
			List<RoomDTO> list = RoomMembershipBLL.GetInstance().GetRooms();
			int d = 0;
			for (int i = 1; i <= list.Count; i++)
			{
				string username = list[i - 1].RoomName;
				Label lb = new Label();
				lb.Text = username;
				lb.Location = new Point(5, 10 + d);
				d += 30;
				lb.Font = new Font("Segoe UI", 11);
				lb.ForeColor = Color.White;
				lb.Click += Lb_Click;
				pnListRoom.Controls.Add(lb);
			}
		}
		private void Lb_Click(object? sender, EventArgs e)
		{
			ptbAddChannel.Visible = true;
			Label lb = sender as Label;
			roomName = lb.Text;
			ShowChannelList(roomName);

			int roomId = RoomBLL.GetInstance().GetRoomIdWithRoomName(roomName);
			if (RoomBLL.GetInstance().IsMaster(roomId))
			{
				btInvite.Visible = true;
				ptbAddChannel.Visible = true;
			}
			else
			{
				btInvite.Visible = false;
				ptbAddChannel.Visible = false;
			}
		}
		private void ShowChannelList(string roomName)
		{
			CleanPanel(pnChannel);
			int roomId = RoomBLL.GetInstance().GetRoomIdWithRoomName(roomName);
			List<ChannelDTO> list = ChannelBLL.GetInstance().GetChannels(roomId);
			int d = 0;
			for (int i = 1; i <= list.Count; i++)
			{
				string username = list[i - 1].ChannelName;
				Label lbChannel = new Label();
				lbChannel.Text = username;
				lbChannel.Location = new Point(5, 10 + d);
				d += 30;
				lbChannel.Font = new Font("Segoe UI", 11);
				lbChannel.ForeColor = Color.White;
				lbChannel.Click += LbChannel_Click;
				pnChannel.Controls.Add(lbChannel);
			}
		}

		private void LbChannel_Click(object? sender, EventArgs e)
		{
			Label lb = sender as Label;
			channelName = lb.Text;
			btSend.Enabled = true;
			ShowMessages(channelName);
		}

		private void ShowMessages(string channelName)
		{
			CleanPanel(pnMessages);
			int roomId = RoomBLL.GetInstance().GetRoomIdWithRoomName(roomName);
			int channelId = ChannelBLL.GetInstance().GetId(roomId, channelName);
			List<ChannelMessageDTO> list = ChannelMessageBLL.GetInstance().GetMessages(channelId);

			d_message = 0;
			for (int i = 0; i < list.Count; i++)
			{
				ChannelMessageDTO message = list[i];
				// panel
				Panel panel = new Panel();
				panel.Location = new Point(0, 0 + d_message);
				panel.Size = new Size(448, 66);
				panel.AutoSize = true;

				pnMessages.Controls.Add(panel);

				//lable username
				Label lbUsername = new Label();
				lbUsername.Text = UserBLL.GetInstance().GetUsernameWithId(message.SenderId);
				lbUsername.ForeColor = Color.Navy;
				lbUsername.Font = new Font("Segoe UI", 13);
				lbUsername.Location = new Point(3, 5);
				lbUsername.AutoSize = true;
				lbUsername.Size = new Size(0, 0);
				panel.Controls.Add(lbUsername);

				// lable time
				Label lbTime = new Label();
				string formatTime = message.Timestamp.ToString("dd/MM HH:mm");
				lbTime.Text = formatTime;
				lbTime.ForeColor = Color.FromArgb(64, 64, 64);
				lbTime.Font = new Font("Segoe UI", 9);
				lbTime.Location = new Point(lbUsername.Location.X + lbUsername.Size.Width + 5, 13);
				panel.Controls.Add(lbTime);

				// textbox message
				TextBox txbMessage = new TextBox();
				txbMessage.ForeColor = Color.White;
				txbMessage.BackColor = Color.DimGray;
				txbMessage.BorderStyle = BorderStyle.None;
				txbMessage.Font = new Font("Segoe UI", 11);
				txbMessage.Location = new Point(6, 35);
				txbMessage.Size = new Size(437, 25);
				txbMessage.Multiline = true;
				txbMessage.WordWrap = true;
				txbMessage.Text = message.Content;
				AdjustTextBoxHeight();
				d_message += panel.Size.Height;
				panel.Controls.Add(txbMessage);

				if (i == list.Count - 1)
				{
					pnMessages.ScrollControlIntoView(panel);
				}

				void AdjustTextBoxHeight()
				{
					using (Graphics g = txbMessage.CreateGraphics())
					{
						SizeF size = g.MeasureString(txbMessage.Text, txbMessage.Font, txbMessage.Width);
						txbMessage.Height = (int)Math.Ceiling(size.Height) + txbMessage.Margin.Vertical;
						panel.Height = lbUsername.Height + txbMessage.Height + 15;
					}
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
		private void pnListRoom_Paint(object sender, PaintEventArgs e)
		{

		}

		private void ptbAddRoom_Click(object sender, EventArgs e)
		{
			CreateRoom createRoom = new CreateRoom();
			createRoom.FormClosed += CreateRoom_FormClosed;
			createRoom.ShowDialog();
			
		}

		private void CreateRoom_FormClosed(object? sender, FormClosedEventArgs e)
		{
			ShowRoomList();
		}

		private void ptbAddChannel_Click(object sender, EventArgs e)
		{
			int roomId = RoomBLL.GetInstance().GetRoomIdWithRoomName(roomName);

			CreateChannel createChannel = new CreateChannel(roomId);
			createChannel.FormClosed += CreateChannel_FormClosed;
			createChannel.ShowDialog();
			
		}

		

		private void CreateChannel_FormClosed(object? sender, FormClosedEventArgs e)
		{
			ShowChannelList(roomName);
		}

		private void btSend_Click(object sender, EventArgs e)
		{

			int senderId = UserBLL.GetInstance().GetIdWithUsername(username);
			int roomId = RoomBLL.GetInstance().GetRoomIdWithRoomName(roomName);
			int channelId = ChannelBLL.GetInstance().GetId(roomId, channelName);
			string content = txbSendMessage.Text;

			ChannelMessageDTO message = new ChannelMessageDTO();
			message.SenderId = senderId;
			message.ChannelId = channelId;
			message.Content = content;
			message.Timestamp = DateTime.Now;

			if (ChannelMessageBLL.GetInstance().AddMessage(senderId, channelId, content))
			{
				txbSendMessage.Text = string.Empty;
				CleanPanel(pnMessages);
				ShowMessages(channelName);
			}
		}

		private void btInvite_Click(object sender, EventArgs e)
		{
			int roomId = RoomBLL.GetInstance().GetRoomIdWithRoomName(roomName);
			InviteMember inviteMember = new InviteMember(roomId);
			inviteMember.Show();
		}
	}
}
