using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Null_Nullable
{
    class Contact
    {
        public string Email { get; set; }
    }
    class Person
    {
        public string Name { get; set; }
        public Contact Contact { get; set; }
        public override string ToString()
        {
            return $"Name :: {Name} \t Email :: {Contact?.Email ?? "No Contact"}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            // values types --> int, double, Struct, Enum
            // reference types ---> class, string, array

            /*int a;
            //Console.WriteLine();
            int[] arr;*/

            //string name = "Masha";
            //string name = null;
            /*if (name== null)
            {
                Console.WriteLine($"Person name :: NoneName");
            }
            else
            {
                Console.WriteLine($"Person name :: {name}");
            }*/

            // ??
            //Console.WriteLine($"Person name :: {name??"NoneName"}");


            /* int[] arr = { 1, 2, 3, 4, 5 };
             arr = null;*/


            /*if (arr == null)
            {
                Console.WriteLine($"Sum :: {0}");
            }
            else
            {
                Console.WriteLine($"Sum :: {arr.Sum()}");
            }*/

            // ?
            //Console.WriteLine($"Sum :: {arr?.Sum()}")
            /*var res = arr?.Sum();
            if (res == null)
            {
                Console.WriteLine($"Sum :: {0}");
            }
            else
            {
                Console.WriteLine($"Sum :: {res}");
            }*/

            //Console.WriteLine($"Sum :: {arr?.Sum() ?? 0}");
            //Person person = new Person
            //{
            //    Name = "Ivan",
            //    Contact = new Contact { Email = "blabla@gmail.com" }
            //};
            ////Person person = new Person
            ////{
            ////    Name = "Ivan",
            ////};
            ////Person person = null;
            //var res = person?.ToString() ?? "Error";
            //Console.WriteLine(res);
            /*if(person != null)
            {
                if (person.Contact != null)
                {
                    Console.WriteLine(person.ToString());
                }
                else
                {
                    Console.WriteLine("Errro Contact");
                }
            }
            else
            {
                Console.WriteLine("Errro Person");
            }*/


            // Nullable

            Nullable<int> age = null;
            //int? age = null;

            age = 22;
            if (age.HasValue)
            {
                Console.WriteLine("Result :: " + age.Value);
            }
            else
            {
                Console.WriteLine("Error");
            }

        }
    }
}
