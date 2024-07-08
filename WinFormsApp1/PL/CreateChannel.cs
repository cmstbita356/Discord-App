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
	public partial class CreateChannel : Form
	{
		int roomId;
		public CreateChannel(int roomId)
		{
			InitializeComponent();
			this.roomId = roomId;
		}

		private void txbName_TextChanged(object sender, EventArgs e)
		{
			if (txbName.Text == null || txbName.Text == string.Empty || txbName.Text == "")
			{
				btCreate.Enabled = false;
			}
			else
			{
				btCreate.Enabled = true;
			}
		}

		private void btCreate_Click(object sender, EventArgs e)
		{
			if (ChannelBLL.GetInstance().CreateChannel(roomId, txbName.Text))
				this.Close();
			
		}
	}
}
