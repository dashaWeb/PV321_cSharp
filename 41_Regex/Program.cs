using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _41_Regex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example 1
            /*string pattern = @"\d"; // визначає в рядку цифру
            var regx = new Regex(pattern);

            while (true)
            {
                string symbol = Console.ReadKey().KeyChar.ToString();
                if(symbol == " ")
                {
                    break;
                }
                Console.WriteLine(regx.IsMatch(symbol)
                    ? $" match found {pattern}"
                    : $" match NOT found {pattern}");
                Console.WriteLine(new string('-',50));
            }*/


            // Example 2
            /*string pattern = @"\D+";
            var arr = new[] { "test", "123", "test123", "132test", "123test123", "test123test" };
            var regx = new Regex(pattern);

            foreach (var item in arr)
            {
                Console.WriteLine(regx.IsMatch(item)
                    ? $"String '{item}' matched '{pattern}'"
                    : $"String '{item}' NOT matched '{pattern}'"
                    );
                Console.WriteLine(new string('-', 50));
            }*/


            // Example 3
            /*string pattern = @"^[A-Z]*$";
            string test = "test \n test";
            //string pattern = @"^\w*$";
            var regx = new Regex(pattern,RegexOptions.IgnoreCase);

            while (true)
            {
                string input = Console.ReadLine();
                if(input == "exit")
                    break;
                Console.WriteLine(input != null && regx.IsMatch(input)
                    ? $" {input } matched '{pattern}'"
                    : $" {input } NOT matched '{pattern}'" );
            }*/

            // Example 4
            /*var arr = new[] { "test", "123", "test123", "132test", "123test123", "test123test" };
            //string pattern = @"\d+"; // "123", "test123", "132test", "123test123", "test123test"
            //string pattern = @"^\d+"; // "123, "132test", "123test123",
            //string pattern = @"\d+$"; // "123, "test123", "123test123",
            string pattern = @"^\d+$"; // "123"
            var regx = new Regex(pattern);
            foreach (var item in arr)
            {
                Console.WriteLine(regx.IsMatch(item)
                    ? $"String '{item}' matched '{pattern}'"
                    : $"String '{item}' NOT matched '{pattern}'"
                    );
                Console.WriteLine(new string('-', 50));
            }*/


            // Example 5
            /*string value = "4 - 5 AND 5 y 789";
            Match match = Regex.Match(value, @"\d+");
            Console.WriteLine(value);
            *//*if(match.Success)
            {
                Console.WriteLine($"Value {match.Value}, Index : {match.Index}, Length :: {match.Length}");
            }
            match = match.NextMatch();
            if (match.Success)
            {
                Console.WriteLine($"Value {match.Value}, Index : {match.Index}, Length :: {match.Length}");
            }*//*
            while (match.Success)
            {
                Console.WriteLine($"Value {match.Value}, Index : {match.Index}, Length :: {match.Length}");
                match = match.NextMatch();
            }
            Console.WriteLine(new string('=',50));*/

            //Example 6
            /*string text = "13 Axxx-1-yyyy \n Axxx-2-yyyy";
            string pattern = @"A.*y";
            Match res = Regex.Match(text, pattern);
            while (res.Success)
            {
                Console.WriteLine($"Value  :: {res.Value}");
                Console.WriteLine($"Index  :: {res.Index}");
                Console.WriteLine($"Length :: {res.Length}");
                Console.WriteLine(new string('=',50));

                res = res.NextMatch();
            }*/

            //Example 7
            /*string value = "said sa-idsaid see she she spear spread super";
            MatchCollection matches = Regex.Matches(value, @"s\w+d");
            foreach (Match match in matches)
            {
                Console.WriteLine($"Value :: {match.Value}, Index :: {match.Index}, Length :: {match.Length}");
            }*/

            /*string value = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam eros orci, molestie ut tellus id, venenatis rhoncus sapien. Donec mattis libero orci, quis tristique mauris elementum necLorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam eros orci, molestie ut tellus id, venenatis rhoncus sapien. Donec mattis libero orci, quis tristique mauris elementum nec";
            var res = Regex.Replace(value, @"d\w{3}r|ipsum|amet|elit", "*****");
            Console.WriteLine(value);
            Console.WriteLine(res);*/

            // +38(096)-45-45-456
            string text = "jjdhdh 454789658 ldkff ldfk slfk 845712547 kkglgf ididi didi 658452140";
            //var output = Regex.Replace(text, @"(\d{2})(\d{2})(\d{2})(\d{3,})", "+38(0$1)-$2-$3-$4");
            var output = Regex.Replace(text, @"\d{9}", m=> string.Format("{0:+38(0##)-##-##-###}",Convert.ToInt64(m.Value)));
            Console.WriteLine(text);
            Console.WriteLine(output);
        }
    }
}
