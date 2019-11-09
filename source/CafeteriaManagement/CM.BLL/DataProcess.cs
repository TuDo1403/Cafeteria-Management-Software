using CM.DAL;
using CM.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class DataProcess
    {
        public static IEnumerable<string> RetrieveCategory() => DataProvider.RetrieveCategory();

        public static IEnumerable<string> RetrieveMenuFrom(string categoryName) => DataProvider.RetrieveMenuFrom(categoryName);

        public static Product RetrieveProductFrom(string productName) => DataProvider.RetrieveProductFrom(productName);

        public static IEnumerable<string> RetrieveMenuToppingFrom(string productName) => DataProvider.RetrieveMenuToppingFrom(productName);

    }
}
