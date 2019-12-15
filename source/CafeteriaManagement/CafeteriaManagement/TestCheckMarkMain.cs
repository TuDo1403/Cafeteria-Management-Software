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
    public partial class TestCheckMarkMain : Form
    {
        public TestCheckMarkMain()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            TestCheckMark.showDialog("Awsome");
        }

        private void TestCheckMarkMain_Load(object sender, EventArgs e)
        {

        }
    }
}
