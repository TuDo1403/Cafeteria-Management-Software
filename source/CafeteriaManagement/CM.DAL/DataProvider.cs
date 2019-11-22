using CM.DTO;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.DAL
{
    public static class DataProvider
    {
        private static readonly CMDataContext _database = new CMDataContext();


        public static IEnumerable<string> RetrieveCategory()
        {
            var categories = from type in _database.PRODUCTTYPEs
                             select type.Name;
            return categories;
        }


        public static IEnumerable<string> RetrieveMenuFrom(string categoryName)
        {
            var typeId = (from type in _database.PRODUCTTYPEs
                          where type.Name == categoryName
                          select type.Id).FirstOrDefault();
            var menu = from product in _database.PRODUCTs
                       where product.ProductId == typeId && product.IsTopping == false
                       select product.Name;
            return menu;
        }

        public static Product RetrieveProductFrom(string productName)
        {   
            var item = (from product in _database.PRODUCTs
                       where product.Name == productName
                       select new Product()
                       {
                           Name = product.Name,
                           Price = (int)product.Price
                       }).FirstOrDefault();
            return item;
        }

        public static IEnumerable<string> RetrieveMenuToppingFrom(string productName)
        {
            var typeId = (from product in _database.PRODUCTs
                          where product.Name == productName
                          select product.ProductId).FirstOrDefault();
            var menu = from product in _database.PRODUCTs
                       where product.ProductId == typeId && product.IsTopping == true
                       select product.Name;
            return menu;
        }

        public static string GetAccountId(string username, string hashedPassword)
        {
            var id = "";
            if (_database.ACCOUNTs.Any(a => a.UserName == username))
            {
                id = (from account in _database.ACCOUNTs
                      where account.UserName == username && account.PassWord == hashedPassword
                      select account.Id).Single();
            }
            return id;
        }

        public static void InsertRecord(object record, string tableName)
        {
            var table = EntityFactory.GetTableFrom(_database, tableName);
            table.InsertOnSubmit(record);
            _database.SubmitChanges();
        }

        public static void DeleteRecord(object record, string tableName)
        {
            
            var table = EntityFactory.GetTableFrom(_database, tableName);
            table.DeleteOnSubmit(record);
            _database.SubmitChanges();
        }

        public static void UpdateProduct(PRODUCT updatedProduct)
        {
            var item = (from product in _database.PRODUCTs
                        where product.Id == updatedProduct.Id
                        select product).Single();
            UpdateItemMember(updatedProduct, ref item);
            _database.SubmitChanges();
        }

        private static void UpdateItemMember(PRODUCT updatedProduct, ref PRODUCT item)
        {
            item.Name = updatedProduct.Name;
            item.Price = updatedProduct.Price;
            item.ProductId = updatedProduct.ProductId;
            item.Description = updatedProduct.Description;
        }

        public static bool IsTopping(string productName)
        {
            var isTopping = (from product in _database.PRODUCTs
                             where product.Name == productName
                             select (bool)product.IsTopping).FirstOrDefault();
            return isTopping;
        }

        public static PRODUCT GetProductInfo(string productName)
        {
            var productInfo = (from product in _database.PRODUCTs
                               where product.Name == productName
                               select product).Single();
            return productInfo;
        }




        public static string GetProductTypeFrom(string id)
        {
            var typeName = (from productType in _database.PRODUCTTYPEs
                            where productType.Id == id
                            select productType.Name).Single();
            return typeName;
        }

        public static string GetProductTypeIDFrom(string typeName)
        {
            var typeId = (from productType in _database.PRODUCTTYPEs
                          where productType.Name == typeName
                          select productType.Id).Single();
            return typeId;
        }

        public static string GetProductIdFrom(string productName)
        {
            var id = (from product in _database.PRODUCTs
                      where product.Name == productName
                      select product.Id).Single();
            return id;
        }

        public static string GetLastProductId()
        {
            var hasElement = _database.PRODUCTs.Any();
            if (!hasElement)
            {
                return "";
            }
            var id = (from product in _database.PRODUCTs
                      select product.Id).AsEnumerable().LastOrDefault();
            return id;
        }



        public static string GetLastBillId()
        {
            var hasElement = _database.BILLs.Any();
            if (!hasElement)
            {
                return "";
            }
            var id = (from bill in _database.BILLs
                      select bill.Id).AsEnumerable().Last();
            return id;
        }



    }
}
