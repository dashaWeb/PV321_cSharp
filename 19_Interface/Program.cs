using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duck duck = new Duck();
            duck.Fly();
            duck.Move();
            duck.Swim();

            Console.WriteLine($"Speed :: {((IFly)duck).Speed}");


            Console.WriteLine("\n\nDuck can Fly");
            IFly fl = duck;
            fl.Fly();
            Console.WriteLine($"Speed Fly:: {fl.Speed}");


            Console.WriteLine("\n\nDuck can Move");
            IMove mv = duck;
            mv.Move();
            Console.WriteLine($"Speed Move:: {mv.Speed}");


            Eagle eagle =  new Eagle();
           
            SteamerDuck steamerDuck = new SteamerDuck();
            IFly[] all_ = { duck, steamerDuck, eagle };

            foreach ( IFly item in all_ )
            {
                // is, as
                Console.WriteLine("\n===========================\n");
                item.Fly();
                if(item is IMove)
                {
                    (item as IMove).Move();
                }
                if(item is IHunting)
                {
                    (item as IHunting).Hunting();
                }
                if (item is ISwim)
                {
                    (item as ISwim).Swim();
                }
                if(item is SteamerDuck) {
                    (item as SteamerDuck).Beer();
                }
            }
            Console.WriteLine("\n===========================\n"); 
            Console.WriteLine("\n===========================\n");
            Duck[] el = { duck, steamerDuck };
            foreach (var item in el)
            {
                item.Fly(); 
            }

        }
    }
}
