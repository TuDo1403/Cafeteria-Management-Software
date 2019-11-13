using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CoffeManagement
{
   public class ProductAccess:DatabaseAccess
    {
        public List<Product> TakeAllProduct()
        {
            List<Product> dsPR = new List<Product>();
            OpenConnection();


            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from PRODUCTS";
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())   //co du lieu
            {
                string prId = reader.GetString(0);
                string prName = reader.GetString(1) + "";
                int prType = reader.GetInt32(2);
                int prPrice = reader.GetInt32(3);

                Product pr = new Product();
                pr.id = prId;
                pr.name = prName;
                pr.type = prType;
                pr.price = prPrice;
                dsPR.Add(pr);

            }

            CloseConnection();
            return dsPR;


        }


        public bool DeleteProduct(string deletedPosion)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Delete from PRODUCTS where PRODUCTID=@ma";

            command.Connection = conn;
            command.Parameters.Add("@ma", SqlDbType.Char).Value = deletedPosion;

            int kq = command.ExecuteNonQuery();

            return kq > 0;
        }

        public bool AddProduct(Product pr)
        {
            //...
            //...

            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;//TYPEPRODUCT,PRICEPRODUCT
            command.CommandText = "Insert into PRODUCTS(PRODUCTID,NAME,PRICEPRODUCT,TYPEPRODUCT) " +
                                    "values (@ma,@ten,@gia,@madm)";

            command.Connection = conn;
            command.Parameters.Add("@ma", SqlDbType.Char).Value = pr.id;
            command.Parameters.Add("@ten", SqlDbType.NVarChar).Value = pr.name;
            command.Parameters.Add("@gia", SqlDbType.Int).Value = pr.price;
            command.Parameters.Add("@madm", SqlDbType.Int).Value = pr.type;

            int kq = command.ExecuteNonQuery();



            CloseConnection();


            if (kq > 0)
                return true;
            return false;
        }


        public bool UpdateProduct(Product pr, string where)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;//NAME,TYPEPRODUCT,PRICEPRODUCT
            command.CommandText = "Update PRODUCTS set NAME=@name,PRICEPRODUCT=@priceproduct,TYPEPRODUCT=@typeproduct" +
                " where  PRODUCTID=@productid";

            command.Connection = conn;
            command.Parameters.Add("@productid", SqlDbType.Char).Value = where;
            command.Parameters.Add("@name", SqlDbType.VarChar).Value =pr.name;
            command.Parameters.Add("@priceproduct", SqlDbType.Int).Value = pr.price;
            command.Parameters.Add("@typeproduct", SqlDbType.Int).Value = pr.type;

            int kq = command.ExecuteNonQuery();

            return kq > 0;


        }
    }
}
