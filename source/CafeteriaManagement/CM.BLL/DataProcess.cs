using CM.DAL;
using CM.DTO;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace CM.BLL
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

        public static void DeleteBillBy(string productName)
        {
            var productId = DataProvider.GetProductIdFrom(productName);
            DataProvider.DeleteBill(productId);
        }

        public static bool ValidateAccount(string username, string password)
        {
            var hashedPassword = password.GetMD5HashedString();
            var isValid = DataProvider.ValidateAccount(username, hashedPassword);
            return isValid;
        }



        public static void InsertProduct(PRODUCT addedProduct) => DataProvider.InsertRecord(addedProduct, "PRODUCT");



        public static void InsertBill(List<Product> list, string total, string userName)
        {
            var bill = new BILL()
            {
                Id = GetNextBillId(),
                Total = Convert.ToDecimal(total, CultureInfo.InvariantCulture),
                DateCreated = DateTime.Today,
                EmployeeId = DataProvider.GetEmployeeIdFrom(userName)
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

        public static void RegisterUser(string username, string password, string code)
        {
            var employeeId = "";
            foreach (var id in DataProvider.GetEmployeeId())
            {
                if (code == id.GetMD5HashedString())
                {
                    employeeId = id;
                    break;
                }
            }
            var account = new ACCOUNT()
            {
                Id = GetNextAccountID(),
                UserName = username,
                PassWord = password.GetMD5HashedString(),
                EmployeeId = employeeId
            };
            DataProvider.InsertRecord(account, "ACCOUNT");
        }

        public static bool ValidateEmployeeId(string code)
        {
            var result = false;
            foreach (var id in DataProvider.GetEmployeeId())
            {
                if (code == id.GetMD5HashedString())
                {
                    result = true;
                    break;
                }
            }

            return result;
        }

        private static string GetNextAccountID()
        {
            var lastId = DataProvider.GetLastAccountId();
            //remember to add out of range check
            if (string.IsNullOrEmpty(lastId))
            {
                return string.Format(CultureInfo.InvariantCulture, "U{0:0000}", 0);
            }
            var nextIndex = Convert.ToInt32(lastId.Remove(0, 1), CultureInfo.InvariantCulture) + 1;
            return string.Format(CultureInfo.InvariantCulture, "U{0:0000}", nextIndex);
        }

        public static string GetNextEmployeeId()
        {
            var lastId = DataProvider.GetLastEmployeeId();

            if (string.IsNullOrEmpty(lastId))
            {
                return string.Format(CultureInfo.InvariantCulture, "E{0:0000}", 0);
            }
            var nextIndex = Convert.ToInt32(lastId.Remove(0, 1), CultureInfo.InvariantCulture) + 1;
            return string.Format(CultureInfo.InvariantCulture, "E{0:0000}", nextIndex);
        }

        public static bool CheckExistedAccount(string code)
        {
            var result = false;
            foreach (var id in DataProvider.GetEmployeeIdFromAccountTable())
            {
                if (code == id.GetMD5HashedString())
                {
                    result = true;
                    break;
                }
            }

            return result;
        }
    }
    
}
