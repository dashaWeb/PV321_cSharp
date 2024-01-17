using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_SortedList
{
    internal class Program
    {
        static void SortedListDemo()
        {
            SortedList colors = new SortedList()
            {
                {5,"blue"},
                {2,"pink"},
                {9,"brown"},
                {6,"yellow"},
                {3,"red"},
                //{2,"red"}, // exceptio
                //{2.5,"red"}, // exception
            };
            Print(colors, "\n\n Print SortedList ");
            colors[9] = "purple"; // edit
            colors[1] = "orange"; // new pair
            Print(colors, "\n\n Print SortedList ");
            if (!colors.ContainsKey(3))
                colors.Add(3, "gold");

            while (true)
            {
                try
                {
                    int index = new Random().Next(1, 10);
                    colors.Add(index, "gold");
                    break;
                }
                catch (Exception ex)
                {
                    //Console.WriteLine(ex.Message);
                }
            }

            Print(colors, "\n\n Print SortedList ");

            colors.Remove(1);
            Print(colors, "\n\n Print SortedList ");
            colors.RemoveAt(0);
            Print(colors, "\n\n Print SortedList ");

            //var keys = colors.Keys;
            var keys = colors.GetKeyList();
            foreach (var key in keys)
            {
                Console.WriteLine(key);
            }
            //var values = colors.Values;
            var values = colors.GetValueList();
            foreach (var value in values)
            {
                Console.WriteLine(value);
            }
            //Console.WriteLine(values);
        }
        static void SortedListGenDemo()
        {
            SortedList<string,string> colors = new SortedList<string, string>()
            {
                ["white"] = "#FFFFFF",
                ["gray"] = "#CCCCCC",
                ["black"] = "#000000",
                ["yellow"] = "#FFFF00"
            };
            Print(colors, "\n\n Print SortedLIst Gen ");
            colors["red"] = "#FF0000";
            colors["white"] = "none";
            Print(colors, "\n\n Print SortedLIst Gen ");
            if(!colors.ContainsKey("red"))
                colors.Add("red", "exception");
            Print(colors, "\n\n Print SortedLIst Gen ");
            colors.Remove("red");
            colors.RemoveAt(2);
            Print(colors, "\n\n Print SortedLIst Gen ");
        }
        static void Main(string[] args)
        {

            //SortedListDemo();
            SortedListGenDemo();
        }
        static void Print(IDictionary list, string text = "")
        {
            Console.WriteLine(text);
            foreach (DictionaryEntry item in list)
            {
                Console.WriteLine($"{item.Key,10}. {item.Value}");
            }
        }
    }
}
