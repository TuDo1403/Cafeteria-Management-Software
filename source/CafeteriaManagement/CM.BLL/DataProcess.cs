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
                return string.Format("PD{0:000}", 0);
            }
            var nextIndex = Convert.ToInt32(lastId.Remove(0, 2)) + 1;
            return string.Format("PD{0:000}", nextIndex);
        }

        public static string GetNextBillId()
        {
            var lastId = DataProvider.GetLastBillId();
            if (string.IsNullOrEmpty(lastId))
            {
                return string.Format("B{0:00000}", 0);
            }
            var nextIndex = Convert.ToInt32(lastId.Remove(0, 1)) + 1;
            return string.Format("B{0:00000}", nextIndex);
        }


        public static void InsertProduct(PRODUCT addedProduct) => DataProvider.InsertRecord(addedProduct, "PRODUCT");



        public static void InsertBill(List<Product> list, string total)
        {
            var bill = new BILL()
            {
                Id = GetNextBillId(),
                Total = Convert.ToDecimal(total),
                DateCreated = DateTime.Today,
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
    }
}
