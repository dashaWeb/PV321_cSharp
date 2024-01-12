using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_iComparable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auditory auditory = new Auditory();

            Console.WriteLine(auditory);


            Console.WriteLine("\n Sort default \n");
            auditory.Sort();
            Console.WriteLine(auditory);

            Console.WriteLine("\n Sort Date \n");
            auditory.Sort(new DateComparer());
            Console.WriteLine(auditory);
        }
    }
}
