using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _32_EventHelper_home
{
    internal class Game
    {
        public void DoStart(object sender, MyArgs arg)
        {
            Console.WriteLine($"Car {arg.Brand} '{arg.Distance}' Start !!!");
        }
        public void DoFinish(object sender, MyArgs arg)
        {
            Console.WriteLine($"Car {arg.Brand} '{arg.Distance}' finished !!!");
        }
        public void DoGo(object sender, MyArgs arg)
        {
            Console.WriteLine($"Car {arg.Brand} '{arg.Distance}' Go !!!");
        }
    }
}
