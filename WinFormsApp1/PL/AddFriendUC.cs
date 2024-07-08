using DiscordApp.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.PeerToPeer;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.BLL;

namespace WinFormsApp1.PL
{
	public partial class AddFriendUC : UserControl
	{
		string username = Properties.Settings.Default.LoggedUsername;
		int d_add = 0;
		public AddFriendUC()
		{
			InitializeComponent();
			ShowPendingList();
		}

		private void txbSendMessage_TextChanged(object sender, EventArgs e)
		{
			CleanPanel(pnAdd);
			TextBox txb = sender as TextBox;
			string words = txb.Text;
			List<UserDTO> listuser = new List<UserDTO>();
			if (words != "" && words != string.Empty && words != null)
				listuser = UserBLL.GetInstance().GetListNoFriendWithWord(words);
			d_add = 0;
			for(int i = 0; i < listuser.Count; i++)
			{
				ShowUserToAdd(listuser[i]);
			}
		}
		private void ShowUserToAdd(UserDTO user)
		{
			// Panel
			Panel panel = new Panel();
			panel.Location = new Point(0, 0 + d_add);
			panel.Size = new Size(405, 72);
			pnAdd.Controls.Add(panel);
			d_add += 100;

			// ptbUser
			PictureBox ptbUser = new PictureBox();
			ptbUser.BackgroundImage = Properties.Resources.User_icon;
			ptbUser.BackgroundImageLayout = ImageLayout.Stretch;
			ptbUser.Location = new Point(0, 0);
			ptbUser.Size = new Size(73, 69);
			panel.Controls.Add(ptbUser);
			
			// lbUsername
			Label lbUsername = new Label();
			lbUsername.Text = user.Username;
			lbUsername.Font = new Font("Segoe UI", 14);
			lbUsername.ForeColor = Color.Navy;
			lbUsername.Location = new Point(79, 22);
			panel.Controls.Add(lbUsername);

			// ptbAdd
			PictureBox ptbAdd = new PictureBox();
			ptbAdd.BackgroundImage = Properties.Resources.Add_icon;
			ptbAdd.BackgroundImageLayout = ImageLayout.Stretch;
			ptbAdd.Location = new Point(329, 0);
			ptbAdd.Size = new Size(73, 69);
			ptbAdd.Click += PtbAdd_Click;
			panel.Controls.Add(ptbAdd);

			void PtbAdd_Click(object? sender, EventArgs e)
			{
				FriendBLL.GetInstance().AskingFriend(user.Username);
				txbSendMessage.Text = "";
			}
		}
		private void ShowPendingList()
		{
			List<UserDTO> list = FriendBLL.GetInstance().GetPendingList();
			int d = 0;
			for (int i = 0; i < list.Count; i++)
			{
				UserDTO user = list[i];
				// Panel
				Panel panel = new Panel();
				panel.Location = new Point(0, 0 + d);
				panel.Size = new Size(188, 52);
				pnPending.Controls.Add(panel);
				d += 60;

				// ptbUser
				PictureBox ptbUser = new PictureBox();
				ptbUser.BackgroundImage = Properties.Resources.User_icon;
				ptbUser.BackgroundImageLayout = ImageLayout.Stretch;
				ptbUser.Location = new Point(0, 0);
				ptbUser.Size = new Size(48, 47);
				panel.Controls.Add(ptbUser);

				// lbUsername
				Label lbUsername = new Label();
				lbUsername.Text = user.Username;
				lbUsername.Font = new Font("Segoe UI", 9);
				lbUsername.ForeColor = Color.Navy;
				lbUsername.Location = new Point(54, 15);
				panel.Controls.Add(lbUsername);

				// ptbAdd
				PictureBox ptbPending = new PictureBox();
				ptbPending.BackgroundImage = Properties.Resources.Pending_icon;
				ptbPending.BackgroundImageLayout = ImageLayout.Stretch;
				ptbPending.Location = new Point(140, 0);
				ptbPending.Size = new Size(48, 47);
				panel.Controls.Add(ptbPending);
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
