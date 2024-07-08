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
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}

		private void lbFaile_Click(object sender, EventArgs e)
		{

		}

		private void btLogin_Click(object sender, EventArgs e)
		{
			string username = txbUsername.Text;
			string password = txbPassword.Text;
			if (UserBLL.GetInstance().Login(username, password))
			{
				Home home = new Home();
				home.Show();
				this.Hide();
			}
			else
			{
				lbFaile.Text = "Username or Password is wrong";
			}
		}

		private void lbRegister_Click(object sender, EventArgs e)
		{
			Register register = new Register();
			register.ShowDialog();
			
		}
	}
}
