namespace WinFormsApp1.PL
{
	partial class AddFriendUC
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
			button1 = new Button();
			label1 = new Label();
			label3 = new Label();
			txbSendMessage = new TextBox();
			pnPending = new Panel();
			pnAdd = new Panel();
			SuspendLayout();
			// 
			// button1
			// 
			button1.BackColor = Color.Navy;
			button1.Enabled = false;
			button1.FlatStyle = FlatStyle.Flat;
			button1.Location = new Point(415, -1);
			button1.Name = "button1";
			button1.Size = new Size(5, 460);
			button1.TabIndex = 5;
			button1.UseVisualStyleBackColor = false;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 13F);
			label1.ForeColor = Color.Navy;
			label1.Location = new Point(468, 0);
			label1.Name = "label1";
			label1.Size = new Size(103, 25);
			label1.TabIndex = 7;
			label1.Text = "Pending list";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 13F);
			label3.ForeColor = Color.Navy;
			label3.Location = new Point(151, -1);
			label3.Name = "label3";
			label3.Size = new Size(97, 25);
			label3.TabIndex = 9;
			label3.Text = "Add friend";
			// 
			// txbSendMessage
			// 
			txbSendMessage.BackColor = Color.FromArgb(64, 64, 64);
			txbSendMessage.BorderStyle = BorderStyle.None;
			txbSendMessage.Font = new Font("Segoe UI", 13F);
			txbSendMessage.ForeColor = Color.White;
			txbSendMessage.Location = new Point(3, 37);
			txbSendMessage.Multiline = true;
			txbSendMessage.Name = "txbSendMessage";
			txbSendMessage.PlaceholderText = "Message";
			txbSendMessage.ScrollBars = ScrollBars.Vertical;
			txbSendMessage.Size = new Size(406, 43);
			txbSendMessage.TabIndex = 10;
			txbSendMessage.TextChanged += txbSendMessage_TextChanged;
			// 
			// pnPending
			// 
			pnPending.AutoScroll = true;
			pnPending.Location = new Point(425, 28);
			pnPending.Name = "pnPending";
			pnPending.Size = new Size(189, 428);
			pnPending.TabIndex = 16;
			// 
			// pnAdd
			// 
			pnAdd.AutoScroll = true;
			pnAdd.Location = new Point(3, 91);
			pnAdd.Name = "pnAdd";
			pnAdd.Size = new Size(410, 371);
			pnAdd.TabIndex = 18;
			// 
			// AddFriendUC
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ControlDarkDark;
			Controls.Add(pnAdd);
			Controls.Add(pnPending);
			Controls.Add(txbSendMessage);
			Controls.Add(label3);
			Controls.Add(label1);
			Controls.Add(button1);
			Name = "AddFriendUC";
			Size = new Size(614, 459);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button1;
		private Label label1;
		private Label label3;
		private TextBox txbSendMessage;
		private Panel pnPending;
		private Panel pnAdd;
	}
}
