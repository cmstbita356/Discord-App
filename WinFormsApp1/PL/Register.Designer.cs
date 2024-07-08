namespace WinFormsApp1.PL
{
	partial class Register
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
			label3 = new Label();
			panel1 = new Panel();
			lbFaile = new Label();
			txbRePass = new TextBox();
			label6 = new Label();
			lbLogin = new Label();
			label5 = new Label();
			btRegister = new Button();
			txbPass = new TextBox();
			txbUsername = new TextBox();
			label4 = new Label();
			label1 = new Label();
			pictureBox1 = new PictureBox();
			label2 = new Label();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 17F);
			label3.ForeColor = Color.White;
			label3.Location = new Point(15, 91);
			label3.Name = "label3";
			label3.Size = new Size(122, 31);
			label3.TabIndex = 1;
			label3.Text = "Username:";
			// 
			// panel1
			// 
			panel1.BackColor = SystemColors.ControlDarkDark;
			panel1.Controls.Add(lbFaile);
			panel1.Controls.Add(txbRePass);
			panel1.Controls.Add(label6);
			panel1.Controls.Add(lbLogin);
			panel1.Controls.Add(label5);
			panel1.Controls.Add(btRegister);
			panel1.Controls.Add(txbPass);
			panel1.Controls.Add(txbUsername);
			panel1.Controls.Add(label4);
			panel1.Controls.Add(label3);
			panel1.Controls.Add(label1);
			panel1.Location = new Point(125, 86);
			panel1.Name = "panel1";
			panel1.Size = new Size(445, 363);
			panel1.TabIndex = 3;
			// 
			// lbFaile
			// 
			lbFaile.AutoSize = true;
			lbFaile.Font = new Font("Segoe UI", 11F);
			lbFaile.ForeColor = Color.Maroon;
			lbFaile.Location = new Point(15, 61);
			lbFaile.Name = "lbFaile";
			lbFaile.Size = new Size(0, 20);
			lbFaile.TabIndex = 10;
			// 
			// txbRePass
			// 
			txbRePass.Font = new Font("Segoe UI", 15F);
			txbRePass.Location = new Point(149, 220);
			txbRePass.Name = "txbRePass";
			txbRePass.PasswordChar = '*';
			txbRePass.Size = new Size(272, 34);
			txbRePass.TabIndex = 9;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 17F);
			label6.ForeColor = Color.White;
			label6.Location = new Point(6, 221);
			label6.Name = "label6";
			label6.Size = new Size(155, 31);
			label6.TabIndex = 8;
			label6.Text = "Re-Password: ";
			// 
			// lbLogin
			// 
			lbLogin.AutoSize = true;
			lbLogin.BackColor = SystemColors.ControlDarkDark;
			lbLogin.Font = new Font("Segoe UI", 11.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
			lbLogin.ForeColor = Color.Blue;
			lbLogin.Location = new Point(181, 330);
			lbLogin.Name = "lbLogin";
			lbLogin.Size = new Size(46, 20);
			lbLogin.TabIndex = 7;
			lbLogin.Text = "Login";
			lbLogin.Click += lbLogin_Click;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.BackColor = SystemColors.ControlDarkDark;
			label5.Font = new Font("Segoe UI", 11F);
			label5.ForeColor = Color.Silver;
			label5.Location = new Point(15, 330);
			label5.Name = "label5";
			label5.Size = new Size(160, 20);
			label5.TabIndex = 6;
			label5.Text = "already have account ?";
			// 
			// btRegister
			// 
			btRegister.AutoSize = true;
			btRegister.BackColor = Color.Navy;
			btRegister.FlatStyle = FlatStyle.Flat;
			btRegister.Font = new Font("Segoe UI", 17F);
			btRegister.ForeColor = Color.White;
			btRegister.Location = new Point(60, 271);
			btRegister.Name = "btRegister";
			btRegister.Size = new Size(326, 43);
			btRegister.TabIndex = 5;
			btRegister.Text = "Register";
			btRegister.UseVisualStyleBackColor = false;
			btRegister.Click += btRegister_Click;
			// 
			// txbPass
			// 
			txbPass.Font = new Font("Segoe UI", 15F);
			txbPass.Location = new Point(148, 156);
			txbPass.Name = "txbPass";
			txbPass.PasswordChar = '*';
			txbPass.Size = new Size(272, 34);
			txbPass.TabIndex = 4;
			// 
			// txbUsername
			// 
			txbUsername.Font = new Font("Segoe UI", 15F);
			txbUsername.Location = new Point(149, 91);
			txbUsername.Name = "txbUsername";
			txbUsername.Size = new Size(272, 34);
			txbUsername.TabIndex = 3;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 17F);
			label4.ForeColor = Color.White;
			label4.Location = new Point(15, 159);
			label4.Name = "label4";
			label4.Size = new Size(121, 31);
			label4.TabIndex = 2;
			label4.Text = "Password: ";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 25F);
			label1.ForeColor = Color.White;
			label1.Location = new Point(148, 9);
			label1.Name = "label1";
			label1.Size = new Size(160, 46);
			label1.TabIndex = 0;
			label1.Text = "Welcome";
			// 
			// pictureBox1
			// 
			pictureBox1.BackgroundImage = Properties.Resources.Discord_icon;
			pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
			pictureBox1.Location = new Point(12, 12);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(51, 53);
			pictureBox1.TabIndex = 5;
			pictureBox1.TabStop = false;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.ForeColor = Color.White;
			label2.Location = new Point(67, 8);
			label2.Name = "label2";
			label2.Size = new Size(155, 50);
			label2.TabIndex = 4;
			label2.Text = "Discord";
			// 
			// Register
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.Navy;
			ClientSize = new Size(684, 461);
			Controls.Add(panel1);
			Controls.Add(pictureBox1);
			Controls.Add(label2);
			Name = "Register";
			Text = "Register";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label3;
		private Panel panel1;
		private Label lbLogin;
		private Label label5;
		private Button btRegister;
		private TextBox txbPass;
		private TextBox txbUsername;
		private Label label4;
		private Label label1;
		private PictureBox pictureBox1;
		private Label label2;
		private TextBox txbRePass;
		private Label label6;
		private Label lbFaile;
	}
}