using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_ICloneable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student ann = new Student("Anna", 7, 8, 9, 10, 11);
            Console.WriteLine("OBJ ann   -- > :: " + ann);

            Student clone;
            clone = ann.Clone() as Student;
            Console.WriteLine("OBJ clone -- > :: " + clone);


            Console.WriteLine("\n\n");
            clone.Name = "Clone";
            clone[0] = 12;
            Console.WriteLine("OBJ ann   -- > :: " + ann);
            Console.WriteLine("OBJ clone -- > :: " + clone);

        }
    }
}
