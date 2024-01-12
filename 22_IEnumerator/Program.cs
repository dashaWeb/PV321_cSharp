using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_IEnumerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Item apple = new Item { Name = "Apple", Price = 15 };
            Item plum = new Item { Name = "Plum", Price = 23 };
            Item orange = new Item { Name = "Orange", Price = 47 };
            Item banana = new Item { Name = "Banana", Price = 52 };

            ShopBucket shop = new ShopBucket();
            shop.AddItem(apple);
            shop.AddItem(plum);
            shop.AddItem(orange);
            shop.AddItem(banana);

            Console.WriteLine("\n Example Default Enumerator");
            foreach (var item in shop)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n Example Reverse Enumerator");
            foreach (var item in shop.GetReverse())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n Example GetCheaperItems Enumerator");
            foreach (var item in shop.GetCheaperItems(30))
            {
                Console.WriteLine(item);
            }

        }
    }
}
