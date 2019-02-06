using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat
{
	public partial class ucLogin : UserControl
	{
		public ucLogin()
		{
			InitializeComponent();
		}

		private void btnSignIn_Click(object sender, EventArgs e)
		{
			frmMain.Instance.Content.Controls.Add(new ucMain() { Dock = DockStyle.Fill });
		}
	}
}
