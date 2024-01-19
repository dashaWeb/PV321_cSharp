using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _28_Delegate
{
    delegate void DelMessage(string text);
    static class Message
    {
        public static void Hello(string name)
        {
            Console.WriteLine($"Hello, {name}");
        }
        public static void Bye(string name)
        {
            Console.WriteLine($"Bye, {name}");
        }
        public static void HowAreYou(string name)
        {
            Console.WriteLine($"How Are You, {name}");
        }
        public static void HowAreYou(string name, string surname)
        {
            Console.WriteLine($"How Are You, {name} {surname}");
        }
        public static void DrawLine(int number, ConsoleColor color)
        {
            Console.WriteLine();
            Console.ForegroundColor = color;
            Console.WriteLine(new string('*',number));
            Console.ResetColor();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Message.Hello("Alex"); // явний виклик методу
            Message.DrawLine(50,ConsoleColor.Red);

            DelMessage del = new DelMessage(Message.Hello);
            Console.WriteLine($"_____ Del reference method {del.Method}");
            Console.WriteLine($"_____ Del target {del.Target}");

            del.Invoke("Dmytro"); // неявний виклик методу
            del("Ivan");

            del = Message.HowAreYou;
            del("Pasha");
            //del = null;
            /*if(del != null)
            {
                del("Maria");
            }
            del?.Invoke("Maria");*/
            Message.DrawLine(50, ConsoleColor.Green);
            DelMessage group = Message.Hello;
            group += Message.HowAreYou;
            group += Message.Bye;
            group += Message.HowAreYou;

            group("Olena");
            Message.DrawLine(50, ConsoleColor.Green);
            group -= Message.HowAreYou;
            group("Masha");

            Message.DrawLine(50, ConsoleColor.Magenta);
            group = new DelMessage(Message.Hello) + Message.Bye;
            group("Den");
        }
    }
}
