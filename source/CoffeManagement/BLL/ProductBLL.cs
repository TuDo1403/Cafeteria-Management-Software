using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeManagement
{
    public class ProductBLL
    {
        ProductAccess psa = new ProductAccess();

        public List<Product> TakeAllProductBLL()
        {
            return psa.TakeAllProduct();
        }
        public bool DeleteProductBLL(string deletedPosion)
        {
            return psa.DeleteProduct(deletedPosion);
        }


        public bool AddProductBLL(Product pr)
        {

           // if (sp.TenSp.Length == 0) return false;// chu y
            //...
            return psa.AddProduct(pr);
        }

        public bool UpdateProduct(Product pr, string where)
        {
            return psa.UpdateProduct(pr, where);
        }
    }

}
