using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_IEnumerable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] ints = { 1, 2, 3, 4, 5 };
            // Enumerable --> те, що перелічується
            // Enumerator --> той хто проходить (С++ ітератор)

            var enArr = ints.GetEnumerator();
            while (enArr.MoveNext())
            {
                Console.Write($"{enArr.Current, 5}");
            }
            Console.WriteLine();

            string str = "Lorem ipsum dolor";
            var enChar = str.GetEnumerator();

            while (enChar.MoveNext())
            {
                Console.Write($"{enChar.Current} --- ");
            }
            Console.WriteLine();

            StringBuilder stringBuilder= new StringBuilder("");

            enChar.Reset();
            while (enChar.MoveNext())
            {
                stringBuilder.Append(enChar.Current);
                stringBuilder.Append(" * ");
            }

            Console.WriteLine($"Line 1 :: {str}");
            Console.WriteLine($"Line 2 :: {stringBuilder}");
        }
    }
}
