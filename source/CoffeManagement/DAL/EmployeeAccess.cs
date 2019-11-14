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
            command.CommandText = "Select * from EMPLOYEES order by EMPLOYEEID asc";
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

        public bool DeleteEmployee(string ma)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "delete from EMPLOYEES where EMPLOYEEID=@ma";

            command.Connection = conn;
            command.Parameters.Add("@ma", SqlDbType.Char).Value = ma;

            int kq = command.ExecuteNonQuery();

            return kq > 0;
        }

        public bool UpdateEmployee(Employee ep,string where)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Update EMPLOYEES set NAME=@name,PHONE=@phone,ADDRESS=@adress" +
                " where EMPLOYEEID=@employeeid";

            command.Connection = conn;
            command.Parameters.Add("@employeeid", SqlDbType.Char).Value =where;
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = ep.name;
            command.Parameters.Add("@phone", SqlDbType.NVarChar).Value =ep.phone;
            command.Parameters.Add("@adress", SqlDbType.NVarChar).Value =ep.adress;

            int kq = command.ExecuteNonQuery();

            return kq > 0;


        }



      
    }
}
