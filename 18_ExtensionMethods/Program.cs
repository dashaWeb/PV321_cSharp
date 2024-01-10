using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_ExtensionMethods
{
    static class IntExtension
    {
        static public int CountDigits(this int value)
        {
            return Math.Abs(value).ToString().Length;
        }
    }
    static class ArrayExtension
    {
        static public int SumPositive(this int[] arr) {
            return Array.FindAll(arr, x=>x>0).Sum();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = -1258;
            Console.WriteLine($"Number of digits {a} = {a.CountDigits()}");
        }
    }
}
