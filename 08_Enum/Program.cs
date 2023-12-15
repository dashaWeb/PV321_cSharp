using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Enum
{
    internal class Program
    {
        enum State:byte
        {
            STOP =1,JUMP,RUN=11,GUN
        }
        static void Main(string[] args)
        {
            /*int state = int.Parse(Console.ReadLine());
            while (true)
            {
                switch (state)
                {
                    case (int)State.STOP:
                        Console.WriteLine("STOP");
                        break;
                    case (int)State.JUMP:
                        Console.WriteLine("JUMP");
                        break;
                    case (int)State.RUN:
                        Console.WriteLine("RUN");
                        break;
                    case (int)State.GUN:
                        Console.WriteLine("GUN");
                        break;
                }
                if(state == 0)
                { break; }
                state = int.Parse(Console.ReadLine());
            }*/
            Console.WriteLine(String.Join("\n", Enum.GetNames(typeof(ConsoleColor))));
            ConsoleColor[] colors = (ConsoleColor[])Enum.GetValues(typeof(ConsoleColor));
            foreach (var item in colors)
            {
                Console.WriteLine((int)item);
            }
            Console.WriteLine("Input color (Red = 4; Blue = 15)");
            ConsoleColor color;
            if (Enum.TryParse<ConsoleColor>(Console.ReadLine(),out color))
            {
                Console.BackgroundColor = color;
            }
        }
    }
}
