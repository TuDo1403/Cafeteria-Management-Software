using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeteriaManagement
{
    public partial class LogIn3 : MaterialSkin.Controls.MaterialForm
    {
        public LogIn3()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green900, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.Amber700, MaterialSkin.TextShade.WHITE);
        }

        private void LogIn3_Load(object sender, EventArgs e)
        {

        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {
            LogIn3_SignIn lg = new LogIn3_SignIn();
            lg.ShowDialog();
        }
    }
}
