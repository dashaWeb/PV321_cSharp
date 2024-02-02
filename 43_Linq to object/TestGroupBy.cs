using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _43_Linq_to_object
{
    class Product
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public override string ToString()
        {
            return $"Product :: {Name,-7} : {Category}";
        }
    }
    internal class TestGroupBy
    {
        public static int[] arr = { 5, 34, 67, 12, 94, 42 };
        public static Product[] products = {
            new Product(){ Name = "Apple", Category = "Food"},
            new Product(){ Name = "Phone", Category = "Tech"},
            new Product(){ Name = "banana", Category = "Food"},
            new Product(){ Name = "Laptop", Category = "Tech"},
            new Product(){ Name = "Plum", Category = "Food"},
        };
        public static void TestGroupInt()
        {
            var query = from x in arr
                        where x > 10
                        group x by x % 10;

            Console.WriteLine("Forming groups of criteria");

            foreach (IGrouping<int, int> group in query)
            {
                Console.WriteLine($"Key :: {group.Key} \n Value ::");
                foreach (int item in group)
                {
                    Console.Write("\t" + item);
                }
                Console.WriteLine();
            }

            var res = arr.Where(x => x > 10).GroupBy(x => x % 10).OrderBy(g => g.Key);
            Console.WriteLine("\nForming groups of criteria");

            foreach (IGrouping<int, int> group in res)
            {
                Console.WriteLine($"Key :: {group.Key} \n Value ::");
                foreach (int item in group)
                {
                    Console.Write("\t" + item);
                }
                Console.WriteLine();
            }
        }
        public static void TestGroupProduct() {
            var res = products.GroupBy(g => g.Category);
            Console.WriteLine("\nForming groups of criteria");

            foreach (IGrouping<string, Product> group in res)
            {
                Console.WriteLine($"Key :: {group.Key} \n Value ::");
                foreach (var item in group)
                {
                    Console.Write("\t" + item.Name);
                }
                Console.WriteLine();
            }

            Console.WriteLine("---------------");
            var res2 = products.Where(pr => char.IsUpper(pr.Name[0]) && pr.Category == "Food").Select(pr => pr);
            foreach (var item in res2)
            {
                Console.WriteLine(item);
            }
        }
        public static void TestGroupInto() {

            /*var query = from gr in (from i in arr 
                        group i by i % 10)
                        where gr.Count() > 1
                        select gr;*/
            var query = from i in arr
                        group i by i % 10 into gr
                        where gr.Count() > 1
                        select gr;
            Console.WriteLine("Groups with the number of element is greater than 1");
            foreach (IGrouping<int, int> group in query)
            {
                Console.WriteLine($"Key :: {group.Key} \n Value ::");
                foreach (int item in group)
                {
                    Console.Write("\t" + item);
                }
                Console.WriteLine();
            }
            var res = arr.GroupBy(i => i % 10).Where(gr => gr.Count() >1).OrderBy(gr => gr.Key);
            Console.WriteLine("Groups with the number of element is greater than 1");
            foreach (IGrouping<int, int> group in res)
            {
                Console.WriteLine($"Key :: {group.Key} \n Value ::");
                foreach (int item in group)
                {
                    Console.Write("\t" + item);
                }
                Console.WriteLine();
            }
        }
    }
}
