using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CafeteriaManagement.CustomUserControl
{
    
    public partial class UCStaticNew : UserControl
    {
        public UCStaticNew()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            //Ngay chỗ AddXY dữ liệu trong đó thôi
            this.ChartStatic.Series["ChartLine"].Points.AddXY("1", 10);//  <===
            this.ChartStatic.Series["ChartLine"].Points.AddXY("2", 12);
            this.ChartStatic.Series["ChartLine"].Points.AddXY("3", 8);
            this.ChartStatic.Series["ChartLine"].Points.AddXY("4", 9);
            this.ChartStatic.Series["ChartLine"].Points.AddXY("5", 7);
            this.ChartStatic.Series["ChartLine"].Points.AddXY("6", 6);
            this.ChartStatic.Series["ChartLine"].Points.AddXY("7", 3);
            this.ChartStatic.Series["ChartLine"].Points.AddXY("8", 9);
            this.ChartStatic.Series["ChartLine"].Points.AddXY("9", 8);
            this.ChartStatic.Series["ChartLine"].Points.AddXY("10", 6);
            this.ChartStatic.Series["ChartLine"].Points.AddXY("11", 4);
            this.ChartStatic.Series["ChartLine"].Points.AddXY("12", 3);
        }
    }
}
