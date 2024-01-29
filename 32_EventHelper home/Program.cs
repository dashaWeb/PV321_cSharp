using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_EventHelper_home
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car ford = new Car() { Brand = "Ford"};
            Car bmw = new Car() { Brand = "BMW"};
            List<Car> list = new List<Car>() { ford, bmw};

            Game game = new Game();
            foreach (var item in list)
            {
                item.start += game.DoStart;
                item.go += game.DoGo;
                item.finish += game.DoFinish;
            }
            ford.Start();
            while (true) { 
            
                Random rnd = new Random();
                foreach (var item in list)
                {
                    if(item.Go(rnd.Next(5, 15)))
                    {
                        return;
                    }
                }
            }
        }
    }
}
