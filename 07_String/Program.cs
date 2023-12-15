using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "lorem ipsum dolor lorem";
            //text[0] = Char.ToUpper(text[0]);// compile error because String - immutable
            char[] chars = text.ToCharArray();
            chars[0] = Char.ToUpper(chars[0]);
            Console.WriteLine(chars);
            text = new string(chars);
            StringBuilder line = new StringBuilder("text test");
            Console.WriteLine($"Size :: {line.Length}, \t Capacity :: {line.Capacity}");
            line.Append("text test");
            Console.WriteLine($"Size :: {line.Length}, \t Capacity :: {line.Capacity}");
            line.Append("lorem ipsum dolor lorem");
            Console.WriteLine($"Size :: {line.Length}, \t Capacity :: {line.Capacity}");
            Console.WriteLine(line);
            line.Remove(11,5);
            Console.WriteLine(line);
            line.Replace("te", "**");
            Console.WriteLine(line);
            Console.WriteLine("\n\n");
            Console.WriteLine(text);
            string word = "rem";
            Console.WriteLine($"Contains '{word}' :: {text.Contains(word)}");
            Console.WriteLine($"IndexOf '{word}' :: {text.IndexOf(word)}");
            Console.WriteLine($"StartsWith '{word}' :: {text.StartsWith(word)}");
            Console.WriteLine($"EndsWith '{word}' :: {text.EndsWith(word)}");
            string letters = "is,";
            Console.WriteLine($"IndexOfAny '{letters}' :: {text.IndexOfAny(letters.ToCharArray())}");
            string one = "Apple", two = "Apricot";
            Console.WriteLine($"{one} == {two} :: {one == two}");
            Console.WriteLine($"{one}.CompareTo({two}) :: {one.CompareTo(two)}");

            two = "apple";
            Console.WriteLine($"{one}.CompareTo({two}) :: {one.CompareTo(two)}");
            Console.WriteLine($"String.CompareOrdinal({one},{two}) :: {String.CompareOrdinal(one,two)}");
            Console.WriteLine($"String.CompareOrdinal({one},{two}) :: {String.Compare(one,two,true)}");

            Console.WriteLine($"Origin line {text}");
            Console.WriteLine($"Remove {text.Remove(5)}");
            Console.WriteLine($"Remove {text.Remove(5,13)}");
            Console.WriteLine($"Replace {text.Replace('o','$')}");
            Console.WriteLine($"Insert {text.Insert(5,"new text")}");
            Console.WriteLine($"Substring {text.Substring(5)}");
            Console.WriteLine($"Substring {text.Substring(5,13)}");
            string phone = "(+380)96-452-52-32";
            string[] number_phone = phone.Split("()-+".ToCharArray());
            Console.WriteLine(String.Join("\n",number_phone));
        }
    }
}
