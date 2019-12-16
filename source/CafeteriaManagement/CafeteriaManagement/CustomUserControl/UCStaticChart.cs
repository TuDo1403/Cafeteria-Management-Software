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
    public partial class UCStaticChart : UserControl
    {
        public UCStaticChart()
        {
            InitializeComponent();
        }

        private void timerChart_Tick(object sender, EventArgs e)
        {
            timerChart.Stop();


            // Nhóm: cafe, soda,trà sữa, sinh tố, đá xay, bánh

            //chart nằm ngang 1 là thống kê số lượng theo nhóm 

            //chart 2 theo giá tiền

            //chart tròn là tỷ lệ phần trăm theo só lượng

            this.chartNumber.Series["SeriesNumber"].Points.AddXY("LUNE", 10);
            this.chartNumber.Series["SeriesNumber"].Points.AddXY("LUNE12", 2);
            this.chartNumber.Series["SeriesNumber"].Points.AddXY("LUNE32d", 42);
            this.chartNumber.Series["SeriesNumber"].Points.AddXY("LUNEdf", 42);
            this.chartNumber.Series["SeriesNumber"].Points.AddXY("LUNEsd", 11);
            this.chartNumber.Series["SeriesNumber"].Points.AddXY("LUNEfd", 12);
            this.chartNumber.Series["SeriesNumber"].Points.AddXY("LUNEdf", 44);
        }
    }
}
