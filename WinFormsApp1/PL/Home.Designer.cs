namespace WinFormsApp1
{
	partial class Home
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			pnSide = new Panel();
			pictureBox2 = new PictureBox();
			button3 = new Button();
			ptbAddFriend = new PictureBox();
			button1 = new Button();
			pictureBox1 = new PictureBox();
			pnMain = new Panel();
			button2 = new Button();
			button4 = new Button();
			pictureBox3 = new PictureBox();
			pnSide.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)ptbAddFriend).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			SuspendLayout();
			// 
			// pnSide
			// 
			pnSide.Controls.Add(pictureBox3);
			pnSide.Controls.Add(button4);
			pnSide.Controls.Add(pictureBox2);
			pnSide.Controls.Add(button3);
			pnSide.Controls.Add(ptbAddFriend);
			pnSide.Controls.Add(button1);
			pnSide.Controls.Add(pictureBox1);
			pnSide.Location = new Point(0, 0);
			pnSide.Name = "pnSide";
			pnSide.Size = new Size(69, 464);
			pnSide.TabIndex = 0;
			// 
			// pictureBox2
			// 
			pictureBox2.BackgroundImage = Properties.Resources.Room_icon;
			pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
			pictureBox2.Location = new Point(0, 144);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(65, 64);
			pictureBox2.TabIndex = 3;
			pictureBox2.TabStop = false;
			pictureBox2.Click += pictureBox2_Click;
			// 
			// button3
			// 
			button3.BackColor = Color.Navy;
			button3.Enabled = false;
			button3.FlatStyle = FlatStyle.Flat;
			button3.Location = new Point(1, 140);
			button3.Name = "button3";
			button3.Size = new Size(70, 5);
			button3.TabIndex = 3;
			button3.Text = "button3";
			button3.UseVisualStyleBackColor = false;
			// 
			// ptbAddFriend
			// 
			ptbAddFriend.BackgroundImage = Properties.Resources.AddFriend_icon;
			ptbAddFriend.BackgroundImageLayout = ImageLayout.Stretch;
			ptbAddFriend.Location = new Point(1, 74);
			ptbAddFriend.Name = "ptbAddFriend";
			ptbAddFriend.Size = new Size(65, 64);
			ptbAddFriend.TabIndex = 2;
			ptbAddFriend.TabStop = false;
			ptbAddFriend.Click += ptbAddFriend_Click;
			// 
			// button1
			// 
			button1.BackColor = Color.Navy;
			button1.Enabled = false;
			button1.FlatStyle = FlatStyle.Flat;
			button1.Location = new Point(1, 70);
			button1.Name = "button1";
			button1.Size = new Size(70, 5);
			button1.TabIndex = 1;
			button1.Text = "button1";
			button1.UseVisualStyleBackColor = false;
			// 
			// pictureBox1
			// 
			pictureBox1.BackgroundImage = Properties.Resources.Message_icon;
			pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
			pictureBox1.Location = new Point(2, 4);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(65, 64);
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			pictureBox1.Click += pictureBox1_Click;
			// 
			// pnMain
			// 
			pnMain.Location = new Point(77, 4);
			pnMain.Name = "pnMain";
			pnMain.Size = new Size(608, 459);
			pnMain.TabIndex = 1;
			// 
			// button2
			// 
			button2.BackColor = Color.Navy;
			button2.Enabled = false;
			button2.FlatStyle = FlatStyle.Flat;
			button2.Location = new Point(70, 11);
			button2.Name = "button2";
			button2.Size = new Size(5, 450);
			button2.TabIndex = 2;
			button2.Text = "button2";
			button2.UseVisualStyleBackColor = false;
			// 
			// button4
			// 
			button4.BackColor = Color.Navy;
			button4.Enabled = false;
			button4.FlatStyle = FlatStyle.Flat;
			button4.Location = new Point(-1, 210);
			button4.Name = "button4";
			button4.Size = new Size(70, 5);
			button4.TabIndex = 4;
			button4.Text = "button4";
			button4.UseVisualStyleBackColor = false;
			// 
			// pictureBox3
			// 
			pictureBox3.BackgroundImage = Properties.Resources.Asking_icon;
			pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
			pictureBox3.Location = new Point(2, 221);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new Size(65, 64);
			pictureBox3.TabIndex = 5;
			pictureBox3.TabStop = false;
			pictureBox3.Click += pictureBox3_Click;
			// 
			// Home
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ControlDarkDark;
			ClientSize = new Size(684, 461);
			Controls.Add(button2);
			Controls.Add(pnMain);
			Controls.Add(pnSide);
			Name = "Home";
			Text = "Form1";
			pnSide.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)ptbAddFriend).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel pnSide;
		private Button button1;
		private PictureBox pictureBox1;
		private Panel pnMain;
		private Button button2;
		private PictureBox ptbAddFriend;
		private Button button3;
		private PictureBox pictureBox2;
		private PictureBox pictureBox3;
		private Button button4;
	}
}
