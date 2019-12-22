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
    public partial class TestCheckMark : Form
    {
        private Timer _timer = new Timer();
        private int tick;

        public TestCheckMark(string _message)
        {
            InitializeComponent();
            lblText.Text = _message;
            _timer.Start();
            _timer.Tick += _timer_TickHandler;
        }

        private void _timer_TickHandler(object sender, EventArgs e)
        {
            tick += 1;
            if (tick == 5000)
            {
                _timer.Stop();
                this.Close();
            }
        }

        public TestCheckMark()
        {
            InitializeComponent();
        }

        private void TestCheckMark_Load(object sender, EventArgs e)
        {
            //bunifuFormFadeTransition1.ShowAsyc(this);
            this.Show();
        }

        private void iconDelay_Tick(object sender, EventArgs e)
        {
            icon.Enabled = false;
            iconDelay.Stop();
            // bunifuFlatButton1.Visible = true;
            this.Close();
        }

        private void bunifuFormFadeTransition1_TransitionEnd(object sender, EventArgs e)
        {
            iconDelay.Start();
            icon.Enabled = true;
           
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static void showDialog(string message)
        {
            TestCheckMark cd = new TestCheckMark(message);
            cd.ShowDialog();
        }
    }
}
