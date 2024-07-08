namespace WinFormsApp1.PL
{
	partial class CreateChannel
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
			btCreate = new Button();
			txbName = new TextBox();
			label2 = new Label();
			label1 = new Label();
			SuspendLayout();
			// 
			// btCreate
			// 
			btCreate.BackColor = Color.Navy;
			btCreate.FlatStyle = FlatStyle.Popup;
			btCreate.Font = new Font("Segoe UI", 11F);
			btCreate.ForeColor = Color.White;
			btCreate.Location = new Point(78, 117);
			btCreate.Name = "btCreate";
			btCreate.Size = new Size(240, 33);
			btCreate.TabIndex = 7;
			btCreate.Text = "Create";
			btCreate.UseVisualStyleBackColor = false;
			btCreate.Click += btCreate_Click;
			// 
			// txbName
			// 
			txbName.BackColor = Color.DarkGray;
			txbName.Font = new Font("Segoe UI", 11F);
			txbName.Location = new Point(165, 71);
			txbName.Name = "txbName";
			txbName.Size = new Size(210, 27);
			txbName.TabIndex = 6;
			txbName.TextChanged += txbName_TextChanged;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 11F);
			label2.ForeColor = Color.White;
			label2.Location = new Point(6, 71);
			label2.Name = "label2";
			label2.Size = new Size(153, 20);
			label2.TabIndex = 5;
			label2.Text = "Name room's channel";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 17F);
			label1.ForeColor = Color.Navy;
			label1.Location = new Point(80, 10);
			label1.Name = "label1";
			label1.Size = new Size(234, 31);
			label1.TabIndex = 4;
			label1.Text = "Create Room Channel";
			// 
			// CreateChannel
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ControlDarkDark;
			ClientSize = new Size(384, 161);
			Controls.Add(btCreate);
			Controls.Add(txbName);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "CreateChannel";
			Text = "CreateChannel";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btCreate;
		private TextBox txbName;
		private Label label2;
		private Label label1;
	}
}