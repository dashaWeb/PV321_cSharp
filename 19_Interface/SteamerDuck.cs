using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Interface
{
    class SteamerDuck : Duck, IFly
    {
        override public void Fly()
        {
            Console.WriteLine($"SteamerDuck can not fly");
        }
        public void Beer()
        {
            Console.WriteLine("SteamerDuck Beer");
        }
    }
}
