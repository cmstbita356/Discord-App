using WinFormsApp1.PL;

namespace WinFormsApp1
{
	public partial class Home : Form
	{
		public Home()
		{
			InitializeComponent();
			Properties.Settings.Default.LoggedUsername = "lan";
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			CleanPanel(pnMain);
			PrivateMessageUC uc = new PrivateMessageUC();
			pnMain.Controls.Add(uc);
		}

		private void ptbAddFriend_Click(object sender, EventArgs e)
		{
			CleanPanel(pnMain);
			AddFriendUC uc = new AddFriendUC();
			pnMain.Controls.Add(uc);
		}
		private void CleanPanel(Panel panel)
		{
			foreach (Control c in panel.Controls)
			{
				panel.Controls.Remove(c);
			}
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			CleanPanel(pnMain);
			RoomUC uc = new RoomUC();
			pnMain.Controls.Add(uc);
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			CleanPanel(pnMain);
			AskingUC uc = new AskingUC();
			pnMain.Controls.Add(uc);
		}
	}
}
