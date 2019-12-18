using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CM.DAL;
using System.Globalization;
using CM.BLL;

namespace CafeteriaManagement.CustomUserControl
{

    public partial class UCStaticNew : UserControl
    {
        private int[] _pointPerMonths = new int[12];
        private int _currentPageIndex = 1;
        private int _currentYear = 2019;



        public UCStaticNew()
        {
            InitializeComponent();
            GetDataFromDataBase(_currentYear);
            UCOrderNew.Billed += UCOrderNew_BilledHandler;
        }

        private void GetDataFromDataBase(int selectedYear)
        {
            GetDataToChart(selectedYear);
            GetDataToGridView(selectedYear);
            GetDataToOverview(selectedYear);
        }

        private void GetDataToOverview(int selectedYear)
        {
            var totalBills = DataProvider.CountAllBills(selectedYear);
            labelTotalBill.Text = $"{totalBills} Bills";
            var totalIncome = DataProvider.GetTotalIncomeFromBill(selectedYear);
            labelTotalIncome.Text = $"{totalIncome} VND";
        }

        private void GetDataToGridView(int selectedYear)
        {
            dataGridBill.DataSource = null;
            dataGridBill.DataSource = DataProvider.GetBILLS(selectedYear);
            dataGridBill.Columns[5].Visible = false;
            dataGridBill.Columns[6].Visible = false;
            labelCurrentPageIndex.Text = "1";
            _currentPageIndex = 1;
        }

        private void GetDataToChart(int selectedYear)
        {
            for (int i = 0; i < 12; ++i)
            {
                _pointPerMonths[i] = 0;
            }
            ChartStatic.Series["ChartLine"].Points.Clear();
            foreach (var point in DataProvider.GetIncomeFromBillEachMonth(selectedYear))
            {
                _pointPerMonths[point.Month - 1] = (int)point.Point;
            }
            for (int i = 0; i < 12; ++i)
            {
                int point = _pointPerMonths[i];
                ChartStatic.Series["ChartLine"].Points.AddXY(i + 1, point);
            }
        }

        private void UCOrderNew_BilledHandler(object sender, EventArgs e)
        {
            GetDataFromDataBase(_currentYear);
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            var result = DataProvider.GetBILLS(_currentYear, _currentPageIndex + 1);
            if (!string.IsNullOrEmpty(textBoxSearch.Text))
            {
                result = DataProcess.GetBillsSortedById(textBoxSearch.Text, _currentYear, _currentPageIndex);
            }
            if (result.Any(c => true))
            {
                _currentPageIndex += 1;
                dataGridBill.DataSource = null;
                dataGridBill.DataSource = result;
                dataGridBill.Columns[5].Visible = false;
                dataGridBill.Columns[6].Visible = false;
                labelCurrentPageIndex.Text = _currentPageIndex.ToString(CultureInfo.InvariantCulture);
            }

        }

        private void ButtonPrevious_Click(object sender, EventArgs e)
        {
            _currentPageIndex -= 1;
            if (_currentPageIndex == 0)
                _currentPageIndex = 1;
            var result = DataProvider.GetBILLS(_currentYear, _currentPageIndex);
            if (!string.IsNullOrEmpty(textBoxSearch.Text))
            {
                result = DataProcess.GetBillsSortedById(textBoxSearch.Text, _currentYear, _currentPageIndex);
            }
            dataGridBill.DataSource = null;
            dataGridBill.DataSource = result;
            dataGridBill.Columns[5].Visible = false;
            dataGridBill.Columns[6].Visible = false;
            labelCurrentPageIndex.Text = _currentPageIndex.ToString(CultureInfo.InvariantCulture);
        }

        private void ButtonNextYear_Click(object sender, EventArgs e)
        {
            _currentYear += 1;
            labelCurrentYear.Text = _currentYear.ToString(CultureInfo.InvariantCulture);
            GetDataFromDataBase(_currentYear);
        }

        private void ButtonPreviousYear_Click(object sender, EventArgs e)
        {
            _currentYear -= 1;
            if (_currentYear <= 0)
            {
                _currentYear = 1;
            }
            labelCurrentYear.Text = _currentYear.ToString(CultureInfo.InvariantCulture);
            GetDataFromDataBase(_currentYear);
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty((sender as TextBox).Text))
            {
                dataGridBill.DataSource = null;
                dataGridBill.DataSource = DataProcess.GetBillsSortedById(textBoxSearch.Text, _currentYear, _currentPageIndex);
                dataGridBill.Columns[5].Visible = false;
                dataGridBill.Columns[6].Visible = false;
            }
            else
            {
                GetDataFromDataBase(_currentYear);
            }
        }

        private void TextBoxSearch_Leave(object sender, EventArgs e)
        {
            if (textBoxSearch.Text.Length == 0)
            {
                GetDataFromDataBase(_currentYear);
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
