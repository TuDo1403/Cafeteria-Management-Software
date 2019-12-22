using CM.DAL;
using CM.DTO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

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

        public static string ValidateAccount(string username, string password)
        {
            var userId = "";
            var hashedPassword = password.GetMD5HashedString();
            userId = DataProvider.ValidateAccount(username, hashedPassword);
            return userId;
        }



        public static void InsertProduct(PRODUCT addedProduct) => DataProvider.InsertRecord(addedProduct, "PRODUCT");



        public static void InsertBillAndBillDetails(List<Product> list, string total, string userName)
        {
            if (list == null)
            {
                throw new ArgumentNullException(nameof(list));
            }
            var bill = new BILL()
            {
                Id = GetNextBillId(),
                Total = Convert.ToDecimal(total, CultureInfo.InvariantCulture),
                DateCreated = DateTime.Today.AddMonths(-10),
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
            var employeeId = (from id in DataProvider.GetEmployeeId()
                              where id.GetMD5HashedString() == code
                              select id).Single();
            var account = new ACCOUNT()
            {
                Id = GetNextAccountID(),
                AccountType = 0,
                UserName = username,
                PassWord = password.GetMD5HashedString(),
                EmployeeId = employeeId
            };
            var accountImage = new ACCOUNT_IMAGE { Id = GetNextAccountID(), Img = null };
            DataProvider.InsertRecord(account, "ACCOUNT");
            DataProvider.InsertRecord(accountImage, "ACCOUNT_IMAGE");
        }

        public static List<PRODUCT> GetProductSortedByName(string text, string categoryName)
        {
            if (string.IsNullOrEmpty(text))
            {
                throw new ArgumentNullException(nameof(text));
            }
            var productsName = DataProvider.RetrieveMenuFrom(categoryName);
            var productsList = new List<PRODUCT>();
            foreach (var name in productsName)
            {
                productsList.Add(DataProvider.GetProductInfo(name));
            }
            var products = productsList.Where(c => c.Name.ToLower().StartsWith(text.ToLower())).ToList();
            return products;
        }

        public static IEnumerable<BILL> GetBillsSortedById(string text, int currentYear, int currentPageIndex)
        {
            if (string.IsNullOrEmpty(text))
            {
                throw new ArgumentNullException(nameof(text));
            }

            var employees = DataProvider.GetBILLS(currentYear, currentPageIndex).Where(c => c.Id.ToLower().StartsWith(text.ToLower())).ToList();
            return employees;
        }

        public static bool ValidateEmployeeId(string code)
        {
            var result = false;
            result = DataProvider.GetEmployeeId().Any(c => c.GetMD5HashedString() == code);
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
            result = DataProvider.GetEmployeeIdFromAccountTable().Any(c => c.GetMD5HashedString() == code);
            return result;
        }

        public static List<EMPLOYEE> GetEmployeesSortedByName(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                throw new ArgumentNullException(nameof(text));
            }

            var employees = DataProvider.GetEMPLOYEEs().Where(c => c.Name.ToLower().StartsWith(text.ToLower())).ToList();
            return employees;
        }
    }

}
