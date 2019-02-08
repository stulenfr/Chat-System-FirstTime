namespace Chat
{
	partial class frmSend
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
			if (disposing && (components != null)) {
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.lollipopButton1 = new LollipopButton();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(12, 84);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(776, 307);
			this.textBox1.TabIndex = 0;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox2.Location = new System.Drawing.Point(12, 406);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(627, 32);
			this.textBox2.TabIndex = 1;
			// 
			// lollipopButton1
			// 
			this.lollipopButton1.BackColor = System.Drawing.Color.Transparent;
			this.lollipopButton1.BGColor = "#508ef5";
			this.lollipopButton1.FontColor = "#ffffff";
			this.lollipopButton1.Location = new System.Drawing.Point(645, 397);
			this.lollipopButton1.Name = "lollipopButton1";
			this.lollipopButton1.Size = new System.Drawing.Size(143, 41);
			this.lollipopButton1.TabIndex = 2;
			this.lollipopButton1.Text = "Send";
			// 
			// frmSend
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lollipopButton1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Name = "frmSend";
			this.Text = "frmSend";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private LollipopButton lollipopButton1;
	}
}