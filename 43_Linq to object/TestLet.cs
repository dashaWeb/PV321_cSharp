using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _43_Linq_to_object
{
    internal class TestLet
    {
        public static string[] lines = {
            "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
            "Nunc mollis risus sed arcu malesuada, in lacinia nisi commodo.",
            "Phasellus finibus est non aliquet lacinia.",
            "Donec iaculis nisi id purus suscipit lobortis.",
            "In eleifend ante quis viverra laoreet."
        };
        public static void Test()
        {
            var query = from line in lines
                        let words = line.Split(',', '.', ' ')
                        from word in words
                        where word.Length > 5
                        select word;
            Console.WriteLine("Words in which more than 5 characters");
            foreach (var item in query)
            {
                Console.Write($"\t{item}");
            }
            Console.WriteLine();

            var res = lines.SelectMany(p => p.Split(',', '.', ' ')).Where(p => p.Length > 5);
            Console.WriteLine("Words in which more than 5 characters");
            foreach (var item in res)
            {
                Console.Write($"\t{item}");
            }
            Console.WriteLine();
        }
    }
}
