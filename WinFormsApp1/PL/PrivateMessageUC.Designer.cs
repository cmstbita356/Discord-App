namespace WinFormsApp1.PL
{
	partial class PrivateMessageUC
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
			panel1 = new Panel();
			label1 = new Label();
			label2 = new Label();
			panel2 = new Panel();
			button1 = new Button();
			txbSendMessage = new TextBox();
			btSend = new Button();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.AutoScroll = true;
			panel1.Location = new Point(5, 46);
			panel1.Name = "panel1";
			panel1.Size = new Size(152, 400);
			panel1.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 13F);
			label1.ForeColor = Color.Navy;
			label1.Location = new Point(25, 14);
			label1.Name = "label1";
			label1.Size = new Size(92, 25);
			label1.TabIndex = 1;
			label1.Text = "Friend List";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 13F);
			label2.ForeColor = Color.Navy;
			label2.Location = new Point(327, 14);
			label2.Name = "label2";
			label2.Size = new Size(90, 25);
			label2.TabIndex = 2;
			label2.Text = "Messages";
			// 
			// panel2
			// 
			panel2.AutoScroll = true;
			panel2.Location = new Point(163, 46);
			panel2.Name = "panel2";
			panel2.Size = new Size(431, 352);
			panel2.TabIndex = 3;
			// 
			// button1
			// 
			button1.BackColor = Color.Navy;
			button1.Enabled = false;
			button1.FlatStyle = FlatStyle.Flat;
			button1.Location = new Point(158, 43);
			button1.Name = "button1";
			button1.Size = new Size(5, 412);
			button1.TabIndex = 4;
			button1.UseVisualStyleBackColor = false;
			// 
			// txbSendMessage
			// 
			txbSendMessage.BackColor = Color.FromArgb(64, 64, 64);
			txbSendMessage.BorderStyle = BorderStyle.None;
			txbSendMessage.ForeColor = Color.White;
			txbSendMessage.Location = new Point(169, 404);
			txbSendMessage.Multiline = true;
			txbSendMessage.Name = "txbSendMessage";
			txbSendMessage.PlaceholderText = "Message";
			txbSendMessage.ScrollBars = ScrollBars.Vertical;
			txbSendMessage.Size = new Size(380, 51);
			txbSendMessage.TabIndex = 0;
			// 
			// btSend
			// 
			btSend.BackColor = Color.Navy;
			btSend.Enabled = false;
			btSend.FlatStyle = FlatStyle.Popup;
			btSend.ForeColor = Color.White;
			btSend.Location = new Point(557, 404);
			btSend.Name = "btSend";
			btSend.Size = new Size(49, 50);
			btSend.TabIndex = 1;
			btSend.Text = "Send";
			btSend.UseVisualStyleBackColor = false;
			btSend.Click += btSend_Click;
			// 
			// PrivateMessageUC
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ControlDarkDark;
			Controls.Add(btSend);
			Controls.Add(button1);
			Controls.Add(txbSendMessage);
			Controls.Add(panel2);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(panel1);
			Name = "PrivateMessageUC";
			Size = new Size(614, 459);
			Load += PrivateMessageUC_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
		private Label label1;
		private Label label2;
		private Panel panel2;
		private Button button1;
		private TextBox txbSendMessage;
		private Button btSend;
	}
}
