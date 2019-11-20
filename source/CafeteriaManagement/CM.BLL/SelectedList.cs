using CM.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SelectedList
    {
        private static readonly List<Product> _selectedItems = new List<Product>();

        public static void Add(Product product)
        {
            foreach (var item in _selectedItems)
            {
                if (item.Name == product.Name)
                {
                    item.Amount += 1;
                    return;
                }
            }

            product.Amount += 1;
            _selectedItems.Add(product);
        }

        public static void AddTopping(Product product, int index)
        {
            // remember to use regex
            _selectedItems[index].Description += $"{product.Name} ({product.Amount + 1}) ";
            _selectedItems[index].AddTopping(product.Name);
            Add(product);
        }

        public static List<Product> GetSelectedItems() => _selectedItems;

        public static void ClearList() => _selectedItems.Clear();
    }
}
