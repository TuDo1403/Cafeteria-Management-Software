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
    public partial class FormAnnouncement : MaterialSkin.Controls.MaterialForm
    {
        public FormAnnouncement()
        {
            InitializeComponent();

          //  InitializeComponent();
           // InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
        }

        private void FormAnnouncement_Load(object sender, EventArgs e)
        {

        }
    }
}
