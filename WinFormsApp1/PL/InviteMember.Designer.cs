﻿namespace WinFormsApp1.PL
{
	partial class InviteMember
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
			pnAdd = new Panel();
			txbSendMessage = new TextBox();
			label3 = new Label();
			SuspendLayout();
			// 
			// pnAdd
			// 
			pnAdd.AutoScroll = true;
			pnAdd.Location = new Point(12, 100);
			pnAdd.Name = "pnAdd";
			pnAdd.Size = new Size(410, 371);
			pnAdd.TabIndex = 21;
			// 
			// txbSendMessage
			// 
			txbSendMessage.BackColor = Color.FromArgb(64, 64, 64);
			txbSendMessage.BorderStyle = BorderStyle.None;
			txbSendMessage.Font = new Font("Segoe UI", 13F);
			txbSendMessage.ForeColor = Color.White;
			txbSendMessage.Location = new Point(12, 46);
			txbSendMessage.Multiline = true;
			txbSendMessage.Name = "txbSendMessage";
			txbSendMessage.PlaceholderText = "Message";
			txbSendMessage.ScrollBars = ScrollBars.Vertical;
			txbSendMessage.Size = new Size(406, 43);
			txbSendMessage.TabIndex = 20;
			txbSendMessage.TextChanged += txbSendMessage_TextChanged;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 13F);
			label3.ForeColor = Color.Navy;
			label3.Location = new Point(160, 8);
			label3.Name = "label3";
			label3.Size = new Size(118, 25);
			label3.TabIndex = 19;
			label3.Text = "Add Member";
			// 
			// InviteMember
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ControlDarkDark;
			ClientSize = new Size(435, 483);
			Controls.Add(pnAdd);
			Controls.Add(txbSendMessage);
			Controls.Add(label3);
			Name = "InviteMember";
			Text = "InviteMember";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel pnAdd;
		private TextBox txbSendMessage;
		private Label label3;
	}
}