namespace WinFormsApp1.PL
{
	partial class CreateRoom
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
			label1 = new Label();
			label2 = new Label();
			txbName = new TextBox();
			btCreate = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 17F);
			label1.ForeColor = Color.Navy;
			label1.Location = new Point(90, 9);
			label1.Name = "label1";
			label1.Size = new Size(196, 31);
			label1.TabIndex = 0;
			label1.Text = "Create Your Room";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 11F);
			label2.ForeColor = Color.White;
			label2.Location = new Point(0, 70);
			label2.Name = "label2";
			label2.Size = new Size(125, 20);
			label2.TabIndex = 1;
			label2.Text = "Name your room:";
			// 
			// txbName
			// 
			txbName.BackColor = Color.DarkGray;
			txbName.Font = new Font("Segoe UI", 11F);
			txbName.Location = new Point(129, 71);
			txbName.Name = "txbName";
			txbName.Size = new Size(243, 27);
			txbName.TabIndex = 2;
			txbName.TextChanged += textBox1_TextChanged;
			// 
			// btCreate
			// 
			btCreate.BackColor = Color.Navy;
			btCreate.FlatStyle = FlatStyle.Popup;
			btCreate.Font = new Font("Segoe UI", 11F);
			btCreate.ForeColor = Color.White;
			btCreate.Location = new Point(72, 116);
			btCreate.Name = "btCreate";
			btCreate.Size = new Size(240, 33);
			btCreate.TabIndex = 3;
			btCreate.Text = "Create";
			btCreate.UseVisualStyleBackColor = false;
			btCreate.Click += button1_Click;
			// 
			// CreateRoom
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ControlDarkDark;
			ClientSize = new Size(384, 161);
			Controls.Add(btCreate);
			Controls.Add(txbName);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "CreateRoom";
			Text = "CreateRoom";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private TextBox txbName;
		private Button btCreate;
	}
}