using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _29_Delegat_calc
{
    delegate double CalcDel(double x, double y);
    class Calculate
    {
        public static double Add(double a, double b) => a + b;
        public static double Sub(double a, double b) => a - b;
        public double Mult(double a, double b) => lastRes =  a * b;
        private double lastRes = 1;
        public override string ToString()
        {
            return $"Mult res :: {lastRes}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            CalcDel deleg = Calculate.Add;
            Console.WriteLine($"Method :: {deleg.Method}");
            Console.WriteLine($"Result :: {deleg(5,3)}");

            Console.WriteLine();
            deleg += Calculate.Sub;
            Console.WriteLine($"Method :: {deleg.Method}");
            Console.WriteLine($"Result :: {deleg(5, 3)}");

            Console.WriteLine("Get Result from Invocation List");
            foreach (var item in deleg.GetInvocationList())
            {
                Console.WriteLine($"Operation :: {item.Method.Name}; Result :: {item.DynamicInvoke(2,3)}");
            }
            Calculate calc = new Calculate();
            deleg = calc.Mult; // calc = Target
            deleg(2, 6);
            Console.WriteLine("Result :: " + calc);
            Console.WriteLine($"_____ Del reference method {deleg.Method}");
            Console.WriteLine($"_____ Del target {deleg.Target.GetType().Name}");
        }
    }
}
