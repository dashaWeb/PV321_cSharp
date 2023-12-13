using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_array
{
    internal class Program
    {
        static void PrintArray<T>(T[] arr, string prompt = "")
        {
            Console.Write(prompt);
            /*for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i],10}");
            }*/
            foreach (var item in arr)
            {
                Console.Write($"{item,10}");
            }
            Console.WriteLine();
        }
        static void Swap<T>(ref T left, ref T right) // параметри передаються за посиланням
        {
            var tmp = left;
            left = right;
            right = tmp;
        }
        /*static void PrintArray(double[] arr, string prompt = "")
        {
            Console.Write(prompt);
            *//*for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i],10}");
            }*//*
            foreach (var item in arr)
            {
                Console.Write($"{item,10}");
            }
            Console.WriteLine();
        }*/
        static void FillRand(int[] arr, int left = 1, int right = 10)
        {
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(left, right+1);
            }
        }
        static void PushBack<T>(ref T[] arr, T value)
        {
            //way1
            /*var tmp = new int[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                tmp[i] = arr[i];
            }
            tmp[arr.Length] = value;
            arr = tmp;*/
            /*//way2
            var tmp = new int[arr.Length + 1];
            arr.CopyTo(tmp, 0 );
            tmp[arr.Length] = value;
            arr = tmp;*/
            //way2
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length-1] = value;
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3,45,85 };
            //Console.WriteLine(arr.Length);
            int[] mas = new int[10];
            PrintArray(arr, "Print Array :: \t");
            FillRand(mas);
            PrintArray(mas, "Print rand Array :: \t");
            PrintArray(arr, "\nPrint Array :: \t");
            PushBack(ref arr, 333);
            PrintArray(arr, "\nPrint Array :: \t");
            double[] arrD = { 4.2, 5.6, 2.02, 5.3, 9.2 };
            PrintArray(arrD, "Print double array :: ");
            int size = int.Parse(Console.ReadLine());
            int[] numbers = new int[size];
            FillRand(numbers);
            PrintArray(numbers, "Print Array \t");
            // бібліотека Linq - методи розширення для роботи з масивами
            int value = int.Parse(Console.ReadLine());
            int index = Array.IndexOf(numbers, value);
            if(index != -1)
            {
                Console.WriteLine($"Value {value} was found in index {index}");
                int indexLast = Array.LastIndexOf(numbers, value);
                Console.WriteLine($"Value {value}(last occur) was found in index {indexLast}");
            }
            else
            {
                Console.WriteLine($"Value {value} not found");
            }
            //Linq
            Console.WriteLine("Result Contains");
            if (numbers.Contains(value))
            {
                Console.WriteLine($"Value {value} was found");
            }
            else
            {
                Console.WriteLine($"Value {value} was not found");
            }
            FillRand(arr,-10,10);
            PrintArray(arr, "\n\nPrint array :: ");
            int indexFirstPositive = Array.FindIndex(arr, IsPositive);
            if(indexFirstPositive != -1)
            {
                Console.WriteLine($"Found positive (first occur) {arr[indexFirstPositive]}");
            }
            else
            {
                Console.WriteLine( $"Not found any positive in array");
            }
            //Linq Cout
            Console.WriteLine($"Number of positive elements :: {arr.Count(IsPositive)}");
            // (formal params) => {...; return ...}
            //Console.WriteLine($"Number of positive elements :: {arr.Count((int el) => { return el < 0; })}");
            Console.WriteLine($"Number of positive elements :: {arr.Count(el =>  el < 0)}");

            int[] positive = Array.FindAll(arr, IsPositive);
            PrintArray(positive, "Find all positive elements as new array");
            int[] negative = Array.FindAll(arr, e=>e<0);
            PrintArray(negative, "Find all negative elements as new array");
            int[] evens = Array.FindAll(arr, e => e % 2 == 0);
            PrintArray(evens, "Find all evens elements as new array");
            //var res = positive.Concat(negative);
            //PrintArray(res, "Find all negative elements as new array");
            bool isAllPositive = Array.TrueForAll(arr, IsPositive);
            Console.WriteLine($"All positive elements :: {isAllPositive}");
            Array.Sort(arr);
            PrintArray(arr, "Print sort asc array :: ");
            Array.Reverse(arr);
            PrintArray(arr, "Print reverse asc array :: ");

            string[] words = { "jan", "feb", "april", "august", "sept", "nov" };
            PrintArray(words, "\n\n Print words");
            Array.Sort(words);
            PrintArray(words, "\n\n Print sort words");
            Array.Sort(words, (s1, s2) => s1.Length.CompareTo(s2.Length));
            PrintArray(words, "\n\n Print sort words");
        }
        static bool IsPositive(int numb)
        {
            return numb > 0;
        }
    }
}
