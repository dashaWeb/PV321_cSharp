using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Character_;
namespace _09_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Character ch1 = new Character("Elf", 100,5);
            ch1.Print();
            Console.WriteLine();
            ch1.Name = "    ";
            Console.WriteLine(ch1.ToString());
            ch1.Name = "King Elf";
            Console.WriteLine(ch1.ToString());
            //ch1.KPD = 455;

            Character ch2 = new Character(hp: 150, damage: 2, name: "Mage");
            Console.WriteLine();
            ch2.Print();
            Console.WriteLine();

            Character ch3 = new Character { Name = "Warrior", Damage = 10 };
            Console.WriteLine(ch3);

            
        }
    }
}
