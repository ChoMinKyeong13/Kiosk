using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiosk
{
    public static class Cartstore
    {

        private static List<Product> cart = new List<Product>();

        public static void Add(Product product)
        {
            cart.Add(product);
        }

        public static void RemoveAt(int index)
        {
            if (index >= 0 && index < cart.Count)
            {
                cart.RemoveAt(index);
            }
        }

        public static List<Product> GetItems()
        {
            return cart;
        }

        public static int GetTotal()
        {
            return cart.Sum(p => p.Price);
        }

        public static void Clear()
        {
            cart.Clear();
        }
    }
}
