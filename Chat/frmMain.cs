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

		private static frmMain _Instance;

		public static frmMain Instance
		{
			get 
			{
				if (_Instance == null) 
					_Instance = new frmMain();
				return _Instance;
			}
		}

		public frmMain()
		{
			InitializeComponent();
			MaterialSkinManager manager = MaterialSkinManager.Instance;
			manager.AddFormToManage(this);
			manager.Theme = MaterialSkinManager.Themes.DARK;
			manager.ColorScheme = new ColorScheme(Primary.Blue400, Primary.Blue500, Primary.Blue500, Accent.LightGreen400,TextShade.BLACK);

		}

		public Panel Content
		{
			get { return MainContainer; }
			set { MainContainer = value; }
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
			_Instance = this;
			MainContainer.Controls.Add(new ucLogin() {Dock=DockStyle.Fill });
		}
	}
}
