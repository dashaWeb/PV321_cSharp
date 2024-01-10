using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Interface
{
    internal class Eagle : IFly, IMove, IHunting
    {
        int IFly.Speed => 50;

        int IMove.Speed => 30;

        public void  Fly()
        {
            Console.WriteLine($"Eagle can fly with {((IFly)this).Speed}");
        }

        public void Hunting()
        {
            Console.WriteLine($"Eagle can hunt");
        }

        public void Move()
        {
            Console.WriteLine($"Eagle can move with {((IFly)this).Speed}");
        }
    }
}
