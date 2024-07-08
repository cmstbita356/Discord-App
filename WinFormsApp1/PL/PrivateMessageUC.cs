using DiscordApp.DTO;
using System;
using System.Collections;
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
	public partial class PrivateMessageUC : UserControl
	{
		string username = Properties.Settings.Default.LoggedUsername;
		string friendUsername = string.Empty;
		int d_message = 0;
		public PrivateMessageUC()
		{
			InitializeComponent();
			ShowFriendList();
		}
		void ShowFriendList()
		{
			List<UserDTO> listuser = FriendBLL.GetInstance().GetFriendList();
			int d = 0;
			for (int i = 1; i <= listuser.Count; i++)
			{
				string username = listuser[i - 1].Username;
				Label lb = new Label();
				lb.Text = username;
				lb.Location = new Point(5, 10 + d);
				d += 30;
				lb.Font = new Font("Segoe UI", 11);
				lb.ForeColor = Color.White;
				lb.Click += Lb_Click;
				panel1.Controls.Add(lb);
			}
		}

		private void Lb_Click(object? sender, EventArgs e)
		{
			CleanPanel(panel2);
			btSend.Enabled = true;
			Label lb = sender as Label;
			friendUsername = lb.Text;
			ShowNewMessage(friendUsername);
		}
		private void ShowNewMessage(string frienUsername)
		{
			int friendid = UserBLL.GetInstance().GetIdWithUsername(friendUsername);
			int userid = UserBLL.GetInstance().GetIdWithUsername(username);
			List<PrivateMessageDTO> list = GetListPM(userid, friendid);

			d_message = 0;
			for (int i = 0; i < list.Count; i++)
			{
				PrivateMessageDTO message = list[i];
				// panel
				Panel panel = new Panel();
				panel.Location = new Point(0, 0 + d_message);
				panel.Size = new Size(448, 66);
				panel.AutoSize = true;

				panel2.Controls.Add(panel);

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
				string formatTime = message.TimeStamp.ToString("dd/MM HH:mm");
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
					panel2.ScrollControlIntoView(panel);
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

		private List<PrivateMessageDTO> GetListPM(int userid, int friendid)
		{
			// Danh sách tin nhắn mình gửi
			List<PrivateMessageDTO> listPM_Send = PrivateMessageBLL.GetInstance().GetList(userid, friendid);
			// DS tin nhắn mình nhận
			List<PrivateMessageDTO> listPM_Recieve = PrivateMessageBLL.GetInstance().GetList(friendid, userid);

			List<PrivateMessageDTO> result = listPM_Send.Concat(listPM_Recieve)
											.OrderBy(pm => pm.TimeStamp)
											.ToList();
			return result;
		}

		private void btSend_Click(object sender, EventArgs e)
		{
			int senderId = UserBLL.GetInstance().GetIdWithUsername(username);
			int recieverId = UserBLL.GetInstance().GetIdWithUsername(friendUsername);
			string content = txbSendMessage.Text;

			PrivateMessageDTO message = new PrivateMessageDTO();
			message.SenderId = senderId;
			message.RecieverId = recieverId;
			message.Content = content;
			message.TimeStamp = DateTime.Now;

			if (PrivateMessageBLL.GetInstance().AddMessage(senderId, recieverId, content))
			{
				txbSendMessage.Text = string.Empty;
				CleanPanel(panel2);
				ShowNewMessage(friendUsername);
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
		private void PrivateMessageUC_Load(object sender, EventArgs e)
		{

		}
	}
}
