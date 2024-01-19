using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_Std_delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action act = Hello;
            act();

            act += () => Console.WriteLine("Test Action");
            act();

            Console.WriteLine();
            Action<string> msg = (name) => Console.WriteLine("Hello, " + name);
            msg("Alex");


            Console.WriteLine();

            Func<int, int, double> avg = (a, b) => (a + b) / 2.0;
            Console.WriteLine($"Average (2,5):: {avg(2,5)}");


            Predicate<int> pred = (number) => number % 2 == 0;
            Console.WriteLine($"3 ---> {pred(3)}");
            Console.WriteLine($"4 ---> {pred(4)}");

            Comparison<string> cmp = (s1,s2) => s1.Length.CompareTo(s2.Length);
            string word1 = "Program", word2 = "Python";
            Console.WriteLine($"{word1} > {word2} = {cmp(word1,word2)}");
            Console.WriteLine($"{word2} > {word1} = {cmp(word2,word1)}");
            Console.WriteLine($"{word1} > {word1} = {cmp(word1,word1)}");

        }
        static void Hello()
        {
            Console.WriteLine("Hello");
        }
    }
}
