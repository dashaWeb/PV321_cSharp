using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_DelegatParams
{
    delegate bool CheckDel<T>(T data);
    internal class Program
    {
        static int CountArr<T>(T[] arr, CheckDel<T> fun)
        {
            int count = 0;
            foreach (var item in arr)
            {
                if (fun(item)) ++count;
            }
            return count;
        }
        static void Main(string[] args)
        {
            int[] arr = { 4, -5, 8, -9, -6, 5, 2, -10 };
            var res = Array.FindAll<int>(arr, i => i > 0);
            Console.WriteLine($"Positive :: {String.Join("\t",res)}");

            Console.WriteLine($"Count odd :: {CountArr(arr, numb => numb % 2 != 0)}");

            string[] colors = { "red", "green", "purple", "yellow", "gold", "lime" };
            Console.WriteLine($"Count colors :: {CountArr(colors, col => col.Contains('e'))}");
        }
    }
}
