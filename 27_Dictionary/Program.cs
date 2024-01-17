using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> people = new Dictionary<int, string>()
            {
                [10] = "Ann",
                [33] = "Alex",
                [22] = "Masha",
                [11] = "Pasha",
                [33] = "Stas",
            };
            Print(people, "Print Dictionary");
            people[77] = "new Name";
            Print(people, "Print Dictionary");

            people.Add(44, "Sasha");
            Print(people, "Print Dictionary");

            people.Remove(33);
            Print(people, "Print Dictionary");
            Console.WriteLine("\n\n");
            SortedDictionary<int, string> copy = new SortedDictionary<int, string>(people);
            foreach (var item in copy)
            {
                Console.WriteLine($"{item.Key,10} {item.Value}");
            }


           
        }
        
        
        static void Print(Dictionary<int,string> list, string text = "")
        {
            Console.WriteLine(text);
            foreach (var item in list)
            {
                Console.WriteLine($"{item.Key,10} {item.Value}");
            }
        }
    }
}
