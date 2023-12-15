using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_2DArrays
{
    internal class Program
    {
        static void PrintArray(int[,] arr, string prompt = "")
        {
            /*Console.WriteLine(prompt);
            foreach (var item in arr)
            {
                Console.Write($"{item,7 }");
            }
            Console.WriteLine();*/
            for (int i = 0; i < arr.GetLength(0); i++) // по рядках
            {
                for (int j = 0; j < arr.GetLength(1); j++) // по column
                {
                    Console.Write($"{arr[i,j],7}");
                }
                Console.WriteLine();
            }
            
        }
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 4];
            int[,] arr2 = new int[,]
            {
                { 1, 2, 3 },
                { 10, 20, 30 },
                { 11, 12, 13 },
                { 21, 22, 23 },
                { 31, 32, 33 }
            };
            PrintArray(arr2,"Print first array");
        }
    }
}
