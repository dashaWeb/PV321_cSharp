using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_intro
{
    internal class Program
    {
        static void TestConsole()
        {
            Console.WindowWidth = 20;
            Console.WindowHeight = 5;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.ResetColor();
            Console.WriteLine("Width :: " + Console.WindowWidth);
            Console.WriteLine("Height :: " + Console.WindowHeight);
            Console.Write("Test\n");
            Console.WriteLine("Hello\\\\ \n\t\a \"World\" !!!");
            Console.Write("Test\n");

            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Green;
        }
        static void ReadSymbol()
        {
            char s = (char)Console.Read();
            // write
            //Console.WriteLine("Result press :: " + s + "\n\t" + char.ToUpper(s));
            // format line
            /* Console.WriteLine("Result press :: {0}, \n\t UpperCase {1} \n{0} \n{0} \n{0} ",s,char.ToUpper(s));*/
            // way 3
            //Console.WriteLine($"Result press :: {s}\n UpperCase :: {char.ToUpper(s),20} \n IsDigit :: {char.IsDigit(s),20}\nIsLetter :: {char.IsLetter(s),20}");

            float number = (float)2.5;
            float number_f = 3.5f;
            int number_int = (int)number;
            decimal money = 205551.654585556m;
            number_int = (int)money;
            Console.WriteLine($"Floor :: {Math.Floor(money),-30}, Round :: {Math.Round(money)}");

        }
        static void readNumber()
        {
            Console.Write($"Enter number [{int.MinValue} .... {int.MaxValue}]:: ");
            string text = Console.ReadLine();
            // way 1
            /*try
            {
                double res = Convert.ToDouble(text);
                Console.WriteLine(res + 100);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Message :: " + ex.Message);
            }*/
            // way 2
            /*int res = int.Parse( text );
            Console.WriteLine(res + 100);*/

            // way 3
            double res;
            if (double.TryParse(text, out res))
            {
                Console.WriteLine(res + 100);
            }
            else
            {
                Console.WriteLine("Error value");
            }
        }
        static void Main(string[] args)
        {

            //readNumber();
            //TestConsole();
            //ReadSymbol();
            /*
             */
            // value types
            // int a = 5;
            // int b = a;
            // b = 33

            // references types
            // object a;
            // object b = a;
            // a = new;


            // +,-,*,/,%;
            // ==, !=, >, <, >=, <=;
            // &&, ||
            // +, -, !
            // a++, --b;

            /*int number = 5;
            Console.WriteLine(number < 10 ? "True" : "False");*/

            /*int month = 2;
            int day;
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                    day = 31;
                    break;
                case 2:
                    int year = int.Parse(Console.ReadLine());
                    day = ((year % 400 == 0 || year % 4 == 0 && year % 100 != 0) ? 29 : 28);
                    break;
                case 4:
                    day = 30;
                    break;
                default:
                    Console.WriteLine("Error");
                    day = 0;
                    break;
            }
            Console.WriteLine(day);*/
            /*int i = 0;
            for (; ; )
            {
                i++;
                Console.WriteLine(i);
                if(i == 10)
                {
                    break;
                }
            }
            Console.WriteLine(i);*/
            /*int number = 0;
            while (number < 10)
            {
                number++;
                if (number % 2 == 0) {
                    continue;
                }
                Console.WriteLine(number);
            }*/
            /*int number;
            do
            {
                Console.Write("2 + 2 = ");
                number = int.Parse(Console.ReadLine());

            } while (number != 4);*/


            var res = Console.ReadKey();
            while (res.Key != ConsoleKey.Escape)
            {
                switch (res.Key)
                {
                    case ConsoleKey.LeftArrow:
                        Console.WriteLine("Left");
                        break;
                    case ConsoleKey.RightArrow:
                        Console.WriteLine("Right");
                        break;
                    case ConsoleKey.UpArrow:
                        Console.WriteLine("Up");
                        break;
                    case ConsoleKey.DownArrow:
                        Console.WriteLine("Down");
                        break;
                }
                res = Console.ReadKey();
            }
        }
    }
}
