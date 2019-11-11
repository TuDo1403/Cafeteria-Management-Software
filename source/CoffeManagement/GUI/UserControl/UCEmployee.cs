using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeManagement
{
    public partial class UCEmployee : UserControl
    {
        public UCEmployee()
        {
            InitializeComponent();
        }

        private void UCEmployee_Load(object sender, EventArgs e)
        {
          

                EmployeeBLL spbll = new EmployeeBLL();
                List<Employee> dsSP = spbll.LayToanBoNhanVienBLL();
                lvEmployee.Items.Clear();
                foreach (Employee sp in dsSP)
                {
                    ListViewItem lvi = new ListViewItem(sp.id + " ");
                    lvi.SubItems.Add(sp.name);
                    lvi.SubItems.Add(sp.phone + "");
                    lvi.SubItems.Add(sp.adress + "");

                    lvEmployee.Items.Add(lvi);
                    // lvi.Tag = sp;

                }
            
        }
    }
}
