using CM.DTO;
using System;
using System.Collections.Generic;
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
                             select type.TYPENAME;
            return categories;
        }


        public static IEnumerable<string> RetrieveMenuFrom(string categoryName)
        {
            var typeId = (from type in _database.PRODUCTTYPEs
                          where type.TYPENAME == categoryName
                          select type.TYPEID).FirstOrDefault();
            var menu = from product in _database.PRODUCTs
                       where product.PRODTYPE == typeId
                       select product.PRODNAME;
            return menu;
        }

        public static Product RetrieveProductFrom(string productName)
        {
            var item = (from product in _database.PRODUCTs
                       where product.PRODNAME == productName
                       select new Product()
                       {
                           Name = product.PRODNAME,
                           Price = (int)product.PRICE
                       }).FirstOrDefault();
            return item;
        }

        public static IEnumerable<string> RetrieveMenuToppingFrom(string productName)
        {
            var typeId = (from product in _database.PRODUCTs
                          where product.PRODNAME == productName
                          select product.PRODTYPE).FirstOrDefault();
            var menu = from product in _database.PRODUCTs
                       where product.PRODTYPE == typeId && product.ISTOPPING == true
                       select product.PRODNAME;
            return menu;
        }
    }
}
