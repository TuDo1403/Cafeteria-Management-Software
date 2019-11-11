using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CoffeManagement
{
    public class EmployeeAccess: DatabaseAccess
    {
        public List<Employee> LayToanBoNhanVien()
        {
            List<Employee> dsNV = new List<Employee>();
            OpenConnection();


            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from EMPLOYEES";
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())   //co du lieu
            {
                string ma = reader.GetString(0);
                string ten = reader.GetString(1) + "";
                string phone = reader.GetString(2);
                string adress = reader.GetString(3);

                Employee sp = new Employee();
                sp.id = ma;
                sp.name = ten;
                sp.phone = phone;
                sp.adress = adress;
                dsNV.Add(sp);

            }

            CloseConnection();
            return dsNV;


        }
    }
}
