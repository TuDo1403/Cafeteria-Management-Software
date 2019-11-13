using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeManagement
{
   public class EmployeeBLL
    {
        EmployeeAccess spa = new EmployeeAccess();

        public List<Employee> LayToanBoNhanVienBLL()
        {

            return spa.LayToanBoNhanVien();
        }

        public bool DeleteEmployeeBLL(string ma)
        {
            return spa.DeleteEmployee(ma);
        }

        public bool UpdateEmployeeBLL(Employee ep,string where)
        {
            return spa.UpdateEmployee(ep,where);
        }
    }
}
