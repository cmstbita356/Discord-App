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
	public partial class CreateRoom : Form
	{
		string username = Properties.Settings.Default.LoggedUsername;
		public CreateRoom()
		{
			InitializeComponent();
			btCreate.Enabled = false;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (RoomBLL.GetInstance().CreateRoom(txbName.Text))
			{
				int roomId = RoomBLL.GetInstance().GetRoomUserCreate(txbName.Text).RoomId;
				int userId = UserBLL.GetInstance().GetIdWithUsername(username);
				if (RoomMembershipBLL.GetInstance().AddMember(roomId, userId))
				{
					this.Close();
				}
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			if(txbName.Text == null || txbName.Text == string.Empty || txbName.Text =="")
			{
				btCreate.Enabled = false;
			}
			else
			{
				btCreate.Enabled = true;
			}
		}
	}
}
