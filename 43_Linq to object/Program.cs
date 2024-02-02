using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_Linq_to_object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\nTest Select");
            Intro.TestSelect();
            Console.WriteLine(new string('-',50));

            Console.WriteLine("\n\nTest Where even");
            Intro.TestWhere();
            Console.WriteLine(new string('-',50));

            Console.WriteLine("\n\nTest OrderBy even");
            Intro.TestOrderBy();
            Console.WriteLine(new string('-', 50));

            Console.WriteLine("\n\nTest Group by");
            TestGroupBy.TestGroupInt();
            TestGroupBy.TestGroupProduct();
            TestGroupBy.TestGroupInto();
            Console.WriteLine(new string('-', 50));

            Console.WriteLine("\n\nTest Let");
            TestLet.Test();
            Console.WriteLine(new string('-', 50));

            Console.WriteLine("\n\nTest Join");
            TestJoin.Test();
            Console.WriteLine(new string('-', 50));


            Console.WriteLine("\n\nTest Agregation");
            TestAgregation.Test();
            Console.WriteLine(new string('-', 50));

            Console.WriteLine("\n\nTest Book");
            TestBook.Test();
            Console.WriteLine(new string('-', 50));
        }
    }
}
