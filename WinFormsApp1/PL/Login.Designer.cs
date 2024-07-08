namespace WinFormsApp1.PL
{
	partial class Login
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			panel1 = new Panel();
			lbFaile = new Label();
			lbRegister = new Label();
			label5 = new Label();
			btLogin = new Button();
			txbPassword = new TextBox();
			txbUsername = new TextBox();
			label4 = new Label();
			label3 = new Label();
			label1 = new Label();
			label2 = new Label();
			pictureBox1 = new PictureBox();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = SystemColors.ControlDarkDark;
			panel1.Controls.Add(lbFaile);
			panel1.Controls.Add(lbRegister);
			panel1.Controls.Add(label5);
			panel1.Controls.Add(btLogin);
			panel1.Controls.Add(txbPassword);
			panel1.Controls.Add(txbUsername);
			panel1.Controls.Add(label4);
			panel1.Controls.Add(label3);
			panel1.Controls.Add(label1);
			panel1.Location = new Point(125, 86);
			panel1.Name = "panel1";
			panel1.Size = new Size(445, 287);
			panel1.TabIndex = 0;
			// 
			// lbFaile
			// 
			lbFaile.AutoSize = true;
			lbFaile.Font = new Font("Segoe UI", 11F);
			lbFaile.ForeColor = Color.Maroon;
			lbFaile.Location = new Point(12, 60);
			lbFaile.Name = "lbFaile";
			lbFaile.Size = new Size(0, 20);
			lbFaile.TabIndex = 11;
			lbFaile.Click += lbFaile_Click;
			// 
			// lbRegister
			// 
			lbRegister.AutoSize = true;
			lbRegister.BackColor = SystemColors.ControlDarkDark;
			lbRegister.Font = new Font("Segoe UI", 11.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
			lbRegister.ForeColor = Color.Blue;
			lbRegister.Location = new Point(150, 246);
			lbRegister.Name = "lbRegister";
			lbRegister.Size = new Size(63, 20);
			lbRegister.TabIndex = 7;
			lbRegister.Text = "Register";
			lbRegister.Click += lbRegister_Click;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.BackColor = SystemColors.ControlDarkDark;
			label5.Font = new Font("Segoe UI", 11F);
			label5.ForeColor = Color.Silver;
			label5.Location = new Point(12, 246);
			label5.Name = "label5";
			label5.Size = new Size(132, 20);
			label5.TabIndex = 6;
			label5.Text = "Need an account ?";
			// 
			// btLogin
			// 
			btLogin.AutoSize = true;
			btLogin.BackColor = Color.Navy;
			btLogin.FlatStyle = FlatStyle.Flat;
			btLogin.Font = new Font("Segoe UI", 17F);
			btLogin.ForeColor = Color.White;
			btLogin.Location = new Point(57, 187);
			btLogin.Name = "btLogin";
			btLogin.Size = new Size(326, 43);
			btLogin.TabIndex = 5;
			btLogin.Text = "Log in";
			btLogin.UseVisualStyleBackColor = false;
			btLogin.Click += btLogin_Click;
			// 
			// txbPassword
			// 
			txbPassword.Font = new Font("Segoe UI", 15F);
			txbPassword.Location = new Point(146, 135);
			txbPassword.Name = "txbPassword";
			txbPassword.PasswordChar = '*';
			txbPassword.Size = new Size(272, 34);
			txbPassword.TabIndex = 4;
			// 
			// txbUsername
			// 
			txbUsername.Font = new Font("Segoe UI", 15F);
			txbUsername.Location = new Point(146, 90);
			txbUsername.Name = "txbUsername";
			txbUsername.Size = new Size(272, 34);
			txbUsername.TabIndex = 3;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 17F);
			label4.ForeColor = Color.White;
			label4.Location = new Point(12, 136);
			label4.Name = "label4";
			label4.Size = new Size(121, 31);
			label4.TabIndex = 2;
			label4.Text = "Password: ";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 17F);
			label3.ForeColor = Color.White;
			label3.Location = new Point(12, 90);
			label3.Name = "label3";
			label3.Size = new Size(122, 31);
			label3.TabIndex = 1;
			label3.Text = "Username:";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 25F);
			label1.ForeColor = Color.White;
			label1.Location = new Point(146, 9);
			label1.Name = "label1";
			label1.Size = new Size(160, 46);
			label1.TabIndex = 0;
			label1.Text = "Welcome";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.ForeColor = Color.White;
			label2.Location = new Point(61, 9);
			label2.Name = "label2";
			label2.Size = new Size(155, 50);
			label2.TabIndex = 1;
			label2.Text = "Discord";
			// 
			// pictureBox1
			// 
			pictureBox1.BackgroundImage = Properties.Resources.Discord_icon;
			pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
			pictureBox1.Location = new Point(6, 13);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(51, 53);
			pictureBox1.TabIndex = 2;
			pictureBox1.TabStop = false;
			// 
			// Login
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.Navy;
			ClientSize = new Size(684, 461);
			Controls.Add(pictureBox1);
			Controls.Add(label2);
			Controls.Add(panel1);
			Name = "Login";
			Text = "Login";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
		private Label label1;
		private Label label2;
		private PictureBox pictureBox1;
		private TextBox txbUsername;
		private Label label4;
		private Label label3;
		private Button btLogin;
		private TextBox txbPassword;
		private Label lbRegister;
		private Label label5;
		private Label lbFaile;
	}
}