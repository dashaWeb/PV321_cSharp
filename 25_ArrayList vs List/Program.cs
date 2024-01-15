using System;
using System.Collections;
using System.Collections.Generic; // узагальнені колекції та інтерфейси
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_ArrayList_vs_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int a = 5;

            object obj = a;

            Console.WriteLine($"Obj {obj}");
           
            if(obj is int)
            {
                int res = (int)obj;
            }*/

            ArrayList list= new ArrayList() { 1, true, 2.5, "test"};
            Print(list, " demo ArrayList");
            Console.WriteLine($"Capacity :: {list.Capacity}, \t Count :: {list.Count}");

            list[0] = 1111.1111;
            Print(list, " demo ArrayList");

            list.Add(456);
            list.AddRange(new int[] { 4,5,2,8,6});
            Print(list, " demo AddRange");

            list.Insert(2, 999);
            Print(list, " demo AddRange");

            list.InsertRange(5, new ArrayList() { "lime", false, 563 });
            Print(list, " demo InsertRange");


            Console.WriteLine("\n\n===================");

            list.Remove("test");
            Print(list, " demo Remove");
            list.RemoveRange(0, 2);
            Print(list, " demo RemoveRange");
            list.RemoveAt(2);
            Print(list, " demo RemoveAt");


            list.Clear();
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                list.Add(rnd.Next(-10, 10));
            }
            Console.WriteLine("\n\n");
            Print(list);
            list.Sort();
            Print(list);
            Console.WriteLine($"\n\n\n {new string('-',40)}\n");

            List<string> li = new List<string>()
            {
                "pen","book","bag","study","pupil", "pencil"
            };
            Print(li);
            li.InsertRange(0, new[] { "ruler", "copybook" });
            Print(li);
            //li.RemoveAll(x => x.Contains("o"));

            li.Sort();
            Print(li);


            li.Sort((s1,s2) => s1.Length.CompareTo(s2.Length));
            Print(li);
        }

        static void Print(IEnumerable list, string text = "")
        {
            Console.Write($"Print {text} :: ");
            foreach (var item in list)
            {
                Console.Write($"{item,-10}");
            }
            Console.WriteLine();
        }
    }
}
