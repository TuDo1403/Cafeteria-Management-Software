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


            LoadEmployees();
            
        }


        void LoadEmployees()
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
                lvi.Tag = sp;

            }
        }



        private void lvEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvEmployee.SelectedItems.Count == 0)
                return;

            ListViewItem lvi = lvEmployee.SelectedItems[0];
            //thu 0 la no.1
            txtNo.Text = lvi.SubItems[0].Text;
            txtName.Text = lvi.SubItems[1].Text;
            txtPhone.Text = lvi.SubItems[2].Text;
            txtAdress.Text = lvi.SubItems[3].Text;
           
        }

        private void btnDeleteE_Click(object sender, EventArgs e)
        {
            if (lvEmployee.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvEmployee.SelectedItems[0];
                Employee sp = lvi.Tag as Employee;
                EmployeeBLL spbll = new EmployeeBLL();
                
                bool kq = spbll.DeleteEmployeeBLL(sp.id);

                if (kq)
                    LoadEmployees();
            }
            else
            {
                MessageBox.Show("Ban chua chon nhan vien");
            }
        }

        private void btnModifyE_Click(object sender, EventArgs e)
        {
            EmployeeBLL spbll = new EmployeeBLL();
            Employee ep = new Employee();

            ListViewItem lvi = lvEmployee.SelectedItems[0];
            Employee epmain = lvi.Tag as Employee;

          //  ep.id = txtNo.Text;
            ep.name = txtName.Text;
            ep.phone = txtPhone.Text;
            ep.adress = txtAdress.Text;


            if(spbll.UpdateEmployeeBLL(ep,epmain.id))
            {
                LoadEmployees();
                MessageBox.Show("Cập Nhật Thành công");
            }
            else
            {
                MessageBox.Show("something wrong");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
    
}
