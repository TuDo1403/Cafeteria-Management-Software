using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CoffeManagement
{
   public  class BillDetailsAcccess:DatabaseAccess
    {
        public bool AddProduct(BillDetails pr)
        {
            //...
            //...

            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;//TYPEPRODUCT,PRICEPRODUCT
            command.CommandText = "Insert into BILLDETAILS(BILLID,PRODUCTID,NUMBER) " +
                                    "values (@billed,@productid,@number)";

            command.Connection = conn;
           command.Parameters.Add("@billed", SqlDbType.Char).Value = "0002";
           command.Parameters.Add("@productid", SqlDbType.Char).Value = pr.idProduct;
           command.Parameters.Add("@number", SqlDbType.Int).Value = pr.number;
         //   command.Parameters.Add("@name", SqlDbType.NVarChar).Value = pr.type;

            int kq = command.ExecuteNonQuery();



            CloseConnection();


            if (kq > 0)
                return true;
            return false;
        }

    }
}
