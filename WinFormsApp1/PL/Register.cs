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
	public partial class Register : Form
	{
		public Register()
		{
			InitializeComponent();
		}

		private void btRegister_Click(object sender, EventArgs e)
		{
			string username = txbUsername.Text;
			string password = txbPass.Text;
			string repass = txbRePass.Text;
			if (UserBLL.GetInstance().Register(username, password, repass))
			{
				//Login login = new Login();
				//login.Show();
				this.Close();
			}
			else
			{
				lbFaile.Text = "Username is existed";
			}
		}

		private void lbLogin_Click(object sender, EventArgs e)
		{
			//Login login = new Login();
			//login.Show();
			this.Close();
		}
	}
}
