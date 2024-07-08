namespace WinFormsApp1.PL
{
	partial class RoomUC
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			btSend = new Button();
			button2 = new Button();
			txbSendMessage = new TextBox();
			pnMessages = new Panel();
			label2 = new Label();
			label1 = new Label();
			pnListRoom = new Panel();
			button1 = new Button();
			pnChannel = new Panel();
			label3 = new Label();
			ptbAddRoom = new PictureBox();
			ptbAddChannel = new PictureBox();
			btInvite = new Button();
			((System.ComponentModel.ISupportInitialize)ptbAddRoom).BeginInit();
			((System.ComponentModel.ISupportInitialize)ptbAddChannel).BeginInit();
			SuspendLayout();
			// 
			// btSend
			// 
			btSend.BackColor = Color.Navy;
			btSend.Enabled = false;
			btSend.FlatStyle = FlatStyle.Popup;
			btSend.ForeColor = Color.White;
			btSend.Location = new Point(556, 399);
			btSend.Name = "btSend";
			btSend.Size = new Size(49, 50);
			btSend.TabIndex = 8;
			btSend.Text = "Send";
			btSend.UseVisualStyleBackColor = false;
			btSend.Click += btSend_Click;
			// 
			// button2
			// 
			button2.BackColor = Color.Navy;
			button2.Enabled = false;
			button2.FlatStyle = FlatStyle.Flat;
			button2.Location = new Point(119, 37);
			button2.Name = "button2";
			button2.Size = new Size(5, 412);
			button2.TabIndex = 12;
			button2.UseVisualStyleBackColor = false;
			// 
			// txbSendMessage
			// 
			txbSendMessage.BackColor = Color.FromArgb(64, 64, 64);
			txbSendMessage.BorderStyle = BorderStyle.None;
			txbSendMessage.ForeColor = Color.White;
			txbSendMessage.Location = new Point(268, 399);
			txbSendMessage.Multiline = true;
			txbSendMessage.Name = "txbSendMessage";
			txbSendMessage.PlaceholderText = "Message";
			txbSendMessage.ScrollBars = ScrollBars.Vertical;
			txbSendMessage.Size = new Size(280, 51);
			txbSendMessage.TabIndex = 6;
			// 
			// pnMessages
			// 
			pnMessages.AutoScroll = true;
			pnMessages.Location = new Point(268, 41);
			pnMessages.Name = "pnMessages";
			pnMessages.Size = new Size(325, 352);
			pnMessages.TabIndex = 11;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 13F);
			label2.ForeColor = Color.Navy;
			label2.Location = new Point(381, 9);
			label2.Name = "label2";
			label2.Size = new Size(90, 25);
			label2.TabIndex = 10;
			label2.Text = "Messages";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 13F);
			label1.ForeColor = Color.Navy;
			label1.Location = new Point(24, 9);
			label1.Name = "label1";
			label1.Size = new Size(68, 25);
			label1.TabIndex = 9;
			label1.Text = "Rooms";
			// 
			// pnListRoom
			// 
			pnListRoom.AutoScroll = true;
			pnListRoom.Location = new Point(4, 44);
			pnListRoom.Name = "pnListRoom";
			pnListRoom.Size = new Size(109, 340);
			pnListRoom.TabIndex = 7;
			pnListRoom.Paint += pnListRoom_Paint;
			// 
			// button1
			// 
			button1.BackColor = Color.Navy;
			button1.Enabled = false;
			button1.FlatStyle = FlatStyle.Flat;
			button1.Location = new Point(257, 37);
			button1.Name = "button1";
			button1.Size = new Size(5, 412);
			button1.TabIndex = 13;
			button1.UseVisualStyleBackColor = false;
			// 
			// pnChannel
			// 
			pnChannel.Location = new Point(130, 44);
			pnChannel.Name = "pnChannel";
			pnChannel.Size = new Size(121, 340);
			pnChannel.TabIndex = 14;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 13F);
			label3.ForeColor = Color.Navy;
			label3.Location = new Point(152, 9);
			label3.Name = "label3";
			label3.Size = new Size(73, 25);
			label3.TabIndex = 15;
			label3.Text = "Chanels";
			// 
			// ptbAddRoom
			// 
			ptbAddRoom.BackColor = SystemColors.ControlDarkDark;
			ptbAddRoom.BackgroundImage = Properties.Resources.Add_icon;
			ptbAddRoom.BackgroundImageLayout = ImageLayout.Stretch;
			ptbAddRoom.Location = new Point(24, 390);
			ptbAddRoom.Name = "ptbAddRoom";
			ptbAddRoom.Size = new Size(64, 59);
			ptbAddRoom.TabIndex = 0;
			ptbAddRoom.TabStop = false;
			ptbAddRoom.Click += ptbAddRoom_Click;
			// 
			// ptbAddChannel
			// 
			ptbAddChannel.BackColor = SystemColors.ControlDarkDark;
			ptbAddChannel.BackgroundImage = Properties.Resources.Add_icon;
			ptbAddChannel.BackgroundImageLayout = ImageLayout.Stretch;
			ptbAddChannel.Location = new Point(161, 390);
			ptbAddChannel.Name = "ptbAddChannel";
			ptbAddChannel.Size = new Size(64, 59);
			ptbAddChannel.TabIndex = 1;
			ptbAddChannel.TabStop = false;
			ptbAddChannel.Click += ptbAddChannel_Click;
			// 
			// btInvite
			// 
			btInvite.BackColor = Color.FromArgb(128, 255, 128);
			btInvite.FlatStyle = FlatStyle.Flat;
			btInvite.Font = new Font("Segoe UI", 11F);
			btInvite.Location = new Point(522, 5);
			btInvite.Name = "btInvite";
			btInvite.Size = new Size(71, 28);
			btInvite.TabIndex = 16;
			btInvite.Text = "Invite";
			btInvite.UseVisualStyleBackColor = false;
			btInvite.Click += btInvite_Click;
			// 
			// RoomUC
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ControlDarkDark;
			Controls.Add(btInvite);
			Controls.Add(ptbAddChannel);
			Controls.Add(ptbAddRoom);
			Controls.Add(button2);
			Controls.Add(label3);
			Controls.Add(pnChannel);
			Controls.Add(button1);
			Controls.Add(btSend);
			Controls.Add(txbSendMessage);
			Controls.Add(pnMessages);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(pnListRoom);
			Name = "RoomUC";
			Size = new Size(608, 459);
			((System.ComponentModel.ISupportInitialize)ptbAddRoom).EndInit();
			((System.ComponentModel.ISupportInitialize)ptbAddChannel).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btSend;
		private Button button2;
		private TextBox txbSendMessage;
		private Panel pnMessages;
		private Label label2;
		private Label label1;
		private Panel pnListRoom;
		private Button button1;
		private Panel pnChannel;
		private Label label3;
		private PictureBox ptbAddRoom;
		private PictureBox ptbAddChannel;
		private Button btInvite;
	}
}
