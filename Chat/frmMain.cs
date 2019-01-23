using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat
{
	public partial class frmMain : MaterialForm
	{
		public frmMain()
		{
			InitializeComponent();
			MaterialSkinManager manager = MaterialSkinManager.Instance;
			manager.AddFormToManage(this);
			manager.Theme = MaterialSkinManager.Themes.DARK;
			manager.ColorScheme = new ColorScheme(Primary.Blue400, Primary.Blue500, Primary.Blue500, Accent.LightGreen400,TextShade.BLACK);

		}
	}
}
