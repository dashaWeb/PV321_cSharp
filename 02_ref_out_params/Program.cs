using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ref_out_params
{
    internal class Program
    {
        static void BadSwap(int left, int right) // параметри передаються за значенням (приходить копія значень)
        {
            var tmp = left;
            left = right;
            right = tmp;
        }
        // ref, out - передача за посиланням
        // ref - переданий фактичний параметр ПОВИНЕН БУТИ ПРОІНІЦІАЛІЗОВАНИЙ
        // out - переданий фактичний параметр може БУТИ НЕ ПРОІНІЦІАЛІЗОВАНИЙ, тобто параметр для збереження результату
        static void Swap(ref int left,ref int right) // параметри передаються за посиланням
        {
            var tmp = left;
            left = right;
            right = tmp;
        }
        static void Main(string[] args)
        {
            // value types - (structs, int, double, enum)
            // reference types (class, string, StringBuilder, interface, delegate, array)
            int one = 10; int two = 20;
            Console.WriteLine($"Before :: \t one({one}); \t two({two})");
            //BadSwap(one, two);
            Swap(ref one,ref two);
            Console.WriteLine($"After  :: \t one({one}); \t two({two})");

        }
    }
}
