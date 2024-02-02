using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_Linq_to_object
{
    internal class Intro
    {
        public static int[] arr = { 5, 34, 67, 12, 94, 42 };
        public static string[] words = { "red", "grey", "blue", "gold", "yellow", "lime", "purple" };
        public static void TestSelect()
        {
            var query = from i in arr
                        select i * -1;
            Console.WriteLine($"Origin      :: {string.Join("\t", arr)}");
            Console.WriteLine($"Linq select :: {string.Join("\t", query)}");
        }
        public static void TestWhere()
        {
            var query = from i in arr
                        where i % 2 == 0
                        select i;
            Console.WriteLine($"Origin      :: {string.Join("\t", arr)}");
            Console.WriteLine($"Linq where  :: {string.Join("\t", query)}");

            query = arr.Where(item => item % 2 == 0).Select(i => i * -1);
            Console.WriteLine($"Origin      :: {string.Join("\t", arr)}");
            Console.WriteLine($"Linq where  :: {string.Join("\t", query)}");


            /*var res = from word in words
                      where word.Length == 4
                      select word;*/
            var res = words.Where(word => word.Length == 4);
            Console.WriteLine($"\n\nOrigin      :: {string.Join("\t", words)}");
            Console.WriteLine($"Linq where  :: {string.Join("\t", res)}");
        }
        public static void TestOrderBy()
        {
            var query = from i in arr
                        where i % 2 == 0
                        orderby i //descending
                        select i;

            Console.WriteLine("Even elements ascending");
            Console.WriteLine($"Linq where  :: {string.Join("\t", query)}");

            var res = arr.Where(i => i%2 == 0).OrderByDescending(i => Math.Abs(i));
            Console.WriteLine("Even elements descending");
            Console.WriteLine($"Linq where  :: {string.Join("\t", res)}");
        }
    }
}
