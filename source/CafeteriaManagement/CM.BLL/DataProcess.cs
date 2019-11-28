using CM.DAL;
using CM.DTO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class DataProcess
    {
        public static IEnumerable<string> RetrieveMenuToppingFrom(string productName)
        {
            var isTopping = DataProvider.IsTopping(productName);
            if (isTopping)
            {
                return null;
            }
            return DataProvider.RetrieveMenuToppingFrom(productName);
        }

       
        public static string GetNextProductId()
        {
            var lastId = DataProvider.GetLastProductId();
            //remember to add out of range check
            if (string.IsNullOrEmpty(lastId))
            {
                return string.Format(CultureInfo.InvariantCulture, "PD{0:000}", 0);
            }
            var nextIndex = Convert.ToInt32(lastId.Remove(0, 2), CultureInfo.InvariantCulture) + 1;
            return string.Format(CultureInfo.InvariantCulture, "PD{0:000}", nextIndex);
        }

        public static string GetNextBillId()
        {
            var lastId = DataProvider.GetLastBillId();
            if (string.IsNullOrEmpty(lastId))
            {
                return string.Format(CultureInfo.InvariantCulture, "B{0:00000}", 0);
            }
            var nextIndex = Convert.ToInt32(lastId.Remove(0, 1), CultureInfo.InvariantCulture) + 1;
            return string.Format(CultureInfo.InvariantCulture, "B{0:00000}", nextIndex);
        }

        public static string GetAccountId(string username, string password)
        {
            var bytesFromPassword = Encoding.UTF8.GetBytes(password);
            using var hashAlgorithm = MD5.Create();
            var hash = hashAlgorithm.ComputeHash(bytesFromPassword);

            var stringBuilder = new StringBuilder();
            foreach (var item in hash)
            {
                // convert to hexadecimal
                stringBuilder.Append(item.ToString("x2", CultureInfo.InvariantCulture));
            }
            var hashedPassword = stringBuilder.ToString();
            var id = DataProvider.GetAccountId(username, hashedPassword);
            return id;
        }

        public static void InsertProduct(PRODUCT addedProduct) => DataProvider.InsertRecord(addedProduct, "PRODUCT");



        public static void InsertBill(List<Product> list, string total, string userId)
        {
            var bill = new BILL()
            {
                Id = GetNextBillId(),
                Total = Convert.ToDecimal(total, CultureInfo.InvariantCulture),
                DateCreated = DateTime.Today,
                EmployeeId = DataProvider.GetEmployeeIdFrom(userId)
            };
            DataProvider.InsertRecord(bill, "BILL");
            foreach (var item in list)
            {
                var billDetail = new PRODUCT_BILL()
                {
                    BillId = bill.Id,
                    ProductId = DataProvider.GetProductIdFrom(item.Name),
                    Amount = item.Amount
                };
                DataProvider.InsertRecord(billDetail, "PRODUCT_BILL");
            }
        }

        public static void DeleteProduct(string text)
        {
            var record = DataProvider.GetProductInfo(text);
            DataProvider.DeleteRecord(record, "PRODUCT");
        }

        public static void RegisterUser(string username, string password, string  email)
        {
            var account = new ACCOUNT()
            {
                Id = GetNextAccountID(),
                UserName = username,
                PassWord = password,
            };
            DataProvider.InsertRecord(account, "ACCOUNT");
        }

        private static string GetNextAccountID()
        {
            var lastId = DataProvider.GetLastAccountId();
            //remember to add out of range check
            if (string.IsNullOrEmpty(lastId))
            {
                return string.Format(CultureInfo.InvariantCulture, "U{0:0000}", 0);
            }
            var nextIndex = Convert.ToInt32(lastId.Remove(0, 2), CultureInfo.InvariantCulture) + 1;
            return string.Format(CultureInfo.InvariantCulture, "U{0:0000}", nextIndex);
        }
    }
    
}
