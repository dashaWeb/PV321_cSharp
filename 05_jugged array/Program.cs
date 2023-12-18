using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _05_jugged_array
{
    /*1. Створити статичні методи для роботи з рваним 2-вимірним масивом(масив масивів).
	- заповнення масиву випадковими числами+
	- вивід на екран +
	- циклічний зсув рядків матриці вверх на певну кількість рядків
	- циклічний зсув рядків матриці вниз на певну кількість рядків
 	- додавання до матриці нового рядка(як останнього)  void AddRow(ref int[][] matrix, int[] newRow)+
	- вилучення рядка з матриці за індексом

--------------------------Методи ------------------
3. Визначити метод для знаходження у рваному двовимірному масиві максимального та мінімального.
    Метод повинен повертати ці значення через свої параметри.

* Створити тривимірний прямокутний(чи масив масивів) з цілих чисел.Знайти суми елементів кожного підмасиву(матриці).
Для виконання задачі створити відповідні методи(створення масиву, заповнення числами, вивід, обрахунок суми).*/
    internal class Program
    {
        static void printJugged(int[][] arr, string prompt = "")
        {
            Console.WriteLine(prompt);
            /*for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write($"{arr[i][j],7}");
                }
                Console.WriteLine();
            }*/
            foreach (var line in arr)
            {
                foreach (var item in line)
                {
                    Console.Write($"{item,7}");
                }
                Console.WriteLine();
            }
        }
        static int[][] CreateJugged(int row, int start_col, int step = 0)
        {
            int[][] tmp = new int[row][];
            for (int i = 0; i < tmp.Length; i++)
            {
                tmp[i] = new int[start_col];
                start_col += step;
            }
            return tmp;
        }
        static void FillRand(int[][]arr, int min = 1, int max = 25)
        {
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                   arr[i][j] = rand.Next(min, max + 1);
                }
            }
        }
        static void SwapRow(int[][] arr, int row1, int row2)
        {
            if(row1 >= 0 && row2 >= 0 && row1< arr.Length && row2<arr.Length)
            {
                int[] tmp = arr[row1];
                arr[row1] = arr[row2];
                arr[row2] = tmp;
            }
        }
        static void ReverseRows(int[][] arr)
        {
            for (int i = 0; i < arr.Length/2; i++)
            {
                SwapRow(arr, i, arr.Length - 1 - i);
            }
        }
        static void PushRow(ref int[][]arr, int[] newRow)
        {
            /*int[][] tmp = new int[arr.Length + 1][];
            for (int i = 0; i < arr.Length; i++)
            {
                tmp[i] = arr[i];
            }
            tmp[arr.Length] = new int[size];
            arr = tmp;*/
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = newRow;
        }
        static void Remove(ref int[][] arr, int index)
        {
            if(index >= 0 && index < arr.Length)
            {
                int[][] tmp = new int[arr.Length - 1][];
                for (int i = 0;i < tmp.Length;i++)
                {
                    if (i < index)
                    {
                        tmp[i] = arr[i];
                    }
                    else
                    {
                        tmp[i] = arr[i+1];
                    }
                }
                arr = tmp;
            }
        }
        static void Up(int[][] arr, int count)
        {
            for (int j = 0; j < count%arr.Length; j++)
            {
                var tmp = arr[0];
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }
                arr[arr.Length - 1] = tmp;
            }
            
        }
        static void Down(int[][] arr, int count)
        {
            for (int j = 0; j < count % arr.Length; j++)
            {
                var tmp = arr[arr.Length - 1];
                for (int i = arr.Length - 1; i > 0; i--)
                {
                    arr[i] = arr[i - 1];
                }
                arr[0] = tmp;
            }
        }
        static void MinMax(int [][] arr, out int min, out int max)
        {
            min = arr[0].Min();
            max = arr[0].Max();
            for (int i = 1; i < arr.Length; i++)
            {
                if(min > arr[i].Min())
                {
                    min = arr[i].Min();
                }
                if (max < arr[i].Max())
                {
                    max = arr[i].Max();
                }
            }
        }
        static void SumInRow(int[][]arr)
        {
            
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Sum in line {i} = {arr[i].Sum()}"); 
            }
            Console.WriteLine("\n\n");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Min in line {i} = {arr[i].Min()}");
            }
            Console.WriteLine("\n\n");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Max in line {i} = {arr[i].Max()}");
            }
            Console.WriteLine("\n\n");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Average in line {i} = {arr[i].Average()}");
            }
            Console.WriteLine("\n\n");
        }
        static void Main(string[] args)
        {
            int[][] arr = new int[][]
            {
                new int[]{1,2,3 },
                new []{11,12,13,14 },
                new int[7]{21,22,23,24,25,26,28}
            };
            int[][] mas = CreateJugged(5, 4, 2);
            FillRand(mas);

            printJugged(arr, "\nPrint first array");
            printJugged(mas, "\nPrint second array");

            Console.WriteLine();
            SwapRow(mas, 0, mas.Length - 1);
            printJugged(mas, "\nPrint second array");

            Console.WriteLine();
            PushRow(ref mas, new int[11]);
            printJugged(mas, "\nPrint second array");
            SumInRow(mas);
            printJugged(mas, "\nPrint second array");
            ReverseRows(mas);
            printJugged(mas, "\nPrint second array");

            Console.WriteLine();
            Down(mas, 3);
            printJugged(mas, "\nPrint second array");
            int min,max;
            MinMax(mas, out min, out max);
            Console.WriteLine($"Min : {min}, Max : {max}");
        }
    }
}
