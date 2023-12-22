
using System;
using one = NS.Class;
using two = NS1.Class;
using three = NS1.NS2.Class;
using static System.Console;
using static System.Math;
namespace A
{
    class Incrementer
    {
        private int count;
        public Incrementer(int count)
        {
            this.count = count;
        }
        public int MultyIncrement()
        {
            for (int i = 0; i < 5; i++) {
                count++;
            }
            return count;
        }
    }
}
namespace B
{
    class Incrementer
    {
        private int count;
        public Incrementer(int count)
        {
            this.count = count;
        }
        public int MultyIncrement()
        {
            for (int i = 0; i < 5; i++)
            {
                count += 10;
            }
            return count;
        }
    }
}
namespace _15_Namespaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A.Incrementer a = new A.Incrementer(10);
            B.Incrementer b = new B.Incrementer(10);
            Console.WriteLine(a.MultyIncrement());
            Console.WriteLine(b.MultyIncrement());

            one demo = new one();
            two demo2 = new two();
            three demo3 = new three();
            demo.print();
            demo2.print();
            demo3.print();
            WriteLine($"Square root 81 = {Sqrt(81)}");
            WriteLine($"2 reised to the 5 = {Pow(2,5)}");
        }
    }
}
