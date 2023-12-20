using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Overload_operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // -, !, ++, --
            // +,-,*,/,%
            // ==, !=. >, < , >=, <=
            // true, false
            // explicit, implicit

            /*int a;
            double b = 2.5;
            a = (int)b; // явне перетворення
            b = a; // неявне перетворення

            int d = 1, e = 2;
            Console.WriteLine(d + e);*/
           Fraction one = new Fraction(1,2);
           Fraction two = new Fraction(1,3);
           Console.WriteLine($"{one} --- {two}");

            Fraction sum = one + two;
            Console.WriteLine($"{one} + {two} = {sum}");

            sum += one;
            Console.WriteLine($"sum += one : {sum}");

            Fraction three = new Fraction(1,2);
            Console.WriteLine($"{one} == {three} ? {one == three}");
            Console.WriteLine($"{one} == {two} ? {one == two}");
            Console.WriteLine($"{one} != {three} ? {one != three}");
            Console.WriteLine($"{one} != {two} ? {one != two}");


            Console.WriteLine($"++{one} = {++one}");
            Console.WriteLine($"{one}++ = {one++}");
            Console.WriteLine($"one {one}");

            // int value = sum; // так можна якщо перевантажили як implicit
            Console.WriteLine($"{sum} cast to int {(int)sum}");
            Console.WriteLine($"{sum} cast to double {(double)sum}");

            double dValue = sum;
            Console.WriteLine($"{sum} cast to double implicitly (dValue) : {dValue}");
            Console.WriteLine(one.ToString());
            Console.WriteLine(one[0]);
            Console.WriteLine(one[1]);
            /*Console.WriteLine(one[2]);*/

            Point test = one;
            Console.WriteLine(test);
        }
    }
}
