namespace WinFormsApp1.PL
{
	partial class AskingUC
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
			pnFriend = new Panel();
			label2 = new Label();
			button1 = new Button();
			pnRoom = new Panel();
			label1 = new Label();
			SuspendLayout();
			// 
			// pnFriend
			// 
			pnFriend.AutoScroll = true;
			pnFriend.Location = new Point(16, 41);
			pnFriend.Name = "pnFriend";
			pnFriend.Size = new Size(291, 400);
			pnFriend.TabIndex = 19;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 13F);
			label2.ForeColor = Color.Navy;
			label2.Location = new Point(110, 7);
			label2.Name = "label2";
			label2.Size = new Size(117, 25);
			label2.TabIndex = 18;
			label2.Text = "Added friend";
			// 
			// button1
			// 
			button1.BackColor = Color.Navy;
			button1.Enabled = false;
			button1.FlatStyle = FlatStyle.Flat;
			button1.Location = new Point(313, -4);
			button1.Name = "button1";
			button1.Size = new Size(5, 460);
			button1.TabIndex = 6;
			button1.UseVisualStyleBackColor = false;
			// 
			// pnRoom
			// 
			pnRoom.AutoScroll = true;
			pnRoom.Location = new Point(324, 41);
			pnRoom.Name = "pnRoom";
			pnRoom.Size = new Size(276, 400);
			pnRoom.TabIndex = 21;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 13F);
			label1.ForeColor = Color.Navy;
			label1.Location = new Point(419, 7);
			label1.Name = "label1";
			label1.Size = new Size(119, 25);
			label1.TabIndex = 20;
			label1.Text = "Invited Room";
			// 
			// AskingUC
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ControlDarkDark;
			Controls.Add(pnRoom);
			Controls.Add(label1);
			Controls.Add(button1);
			Controls.Add(pnFriend);
			Controls.Add(label2);
			Name = "AskingUC";
			Size = new Size(614, 459);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel pnFriend;
		private Label label2;
		private Button button1;
		private Panel pnRoom;
		private Label label1;
	}
}
