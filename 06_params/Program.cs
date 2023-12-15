using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_params
{
    internal class Program
    {
        static int Sum(int a, int b)
        { return a + b; }
        static int Sum(int a, int b, int c)
        { return a + b + c; }
        static int Sum(params int[] arr)
        {
            return arr.Sum();
        }
        static void CloneStr(int size, params string[] arr)
        {
            foreach (var item in arr)
            {
                for (int i = 0; i < size; i++)
                {
                    Console.Write(item);
                }
                Console.WriteLine();
            }
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(2,7));
            Console.WriteLine(Sum(2,7,5));
            Console.WriteLine(Sum(2,7,5,4));
            Console.WriteLine(Sum(2,7,5,4,5,4,6,3,4,5,6));
            CloneStr(5, "C++", "C#", "JavaScript", "Python");
        }
    }
}
