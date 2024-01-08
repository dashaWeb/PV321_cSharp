using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Device device = new TV("LG",2000,1500);
            Device[] devices = {
                device,
                new SmartTV("Samsung",2005,1800),
                new SmartPhone("IPhone", 2023)
            };

            foreach (var item in devices)
            {
                Console.WriteLine("====================");
                Console.WriteLine(item);
            }

            TV[] devices_ = {
                new TV("LG",2000,1500),
                new SmartTV("Samsung",2005,1800),
            };
            Console.WriteLine("\n\n====================\n");

            foreach (var item in devices_)
            {
                Console.WriteLine("====================");
                item.Print();
            };
        }
    }
}
