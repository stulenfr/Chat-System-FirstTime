namespace Chat
{
	partial class ucLogin
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lollipopLabel1 = new LollipopLabel();
			this.lollipopTextBox1 = new LollipopTextBox();
			this.btnSignIn = new LollipopButton();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Chat.Properties.Resources.squarescube_grande;
			this.pictureBox1.Location = new System.Drawing.Point(95, 108);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 100);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// lollipopLabel1
			// 
			this.lollipopLabel1.AutoSize = true;
			this.lollipopLabel1.BackColor = System.Drawing.Color.Transparent;
			this.lollipopLabel1.Font = new System.Drawing.Font("Arial Black", 10F);
			this.lollipopLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
			this.lollipopLabel1.Location = new System.Drawing.Point(57, 273);
			this.lollipopLabel1.Name = "lollipopLabel1";
			this.lollipopLabel1.Size = new System.Drawing.Size(108, 24);
			this.lollipopLabel1.TabIndex = 1;
			this.lollipopLabel1.Text = "Your name";
			// 
			// lollipopTextBox1
			// 
			this.lollipopTextBox1.FocusedColor = "#508ef5";
			this.lollipopTextBox1.FontColor = "blue";
			this.lollipopTextBox1.IsEnabled = true;
			this.lollipopTextBox1.Location = new System.Drawing.Point(61, 298);
			this.lollipopTextBox1.MaxLength = 32767;
			this.lollipopTextBox1.Multiline = false;
			this.lollipopTextBox1.Name = "lollipopTextBox1";
			this.lollipopTextBox1.ReadOnly = false;
			this.lollipopTextBox1.Size = new System.Drawing.Size(192, 24);
			this.lollipopTextBox1.TabIndex = 2;
			this.lollipopTextBox1.Text = "help me";
			this.lollipopTextBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.lollipopTextBox1.UseSystemPasswordChar = false;
			// 
			// btnSignIn
			// 
			this.btnSignIn.BackColor = System.Drawing.Color.Transparent;
			this.btnSignIn.BGColor = "#508ef5";
			this.btnSignIn.FontColor = "#ffffff";
			this.btnSignIn.Location = new System.Drawing.Point(61, 328);
			this.btnSignIn.Name = "btnSignIn";
			this.btnSignIn.Size = new System.Drawing.Size(143, 41);
			this.btnSignIn.TabIndex = 3;
			this.btnSignIn.Text = "Sign In";
			this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
			// 
			// ucLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btnSignIn);
			this.Controls.Add(this.lollipopTextBox1);
			this.Controls.Add(this.lollipopLabel1);
			this.Controls.Add(this.pictureBox1);
			this.Name = "ucLogin";
			this.Size = new System.Drawing.Size(290, 506);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private LollipopLabel lollipopLabel1;
		private LollipopTextBox lollipopTextBox1;
		private LollipopButton btnSignIn;
	}
}
