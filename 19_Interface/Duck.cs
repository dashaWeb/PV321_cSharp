using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Interface
{
    class Duck : IMove, IFly, ISwim
    {

        public int Weight { get; set; }
        // одна реалізація для всіх інтерфейсів
        //public int Speed => 15; // неявна реалізація інтерфейсу (для кого явно не вказано, визначить компілятор)

        int IMove.Speed => 10;

        int IFly.Speed => 15;

        virtual public void Fly()
        {
            Console.WriteLine($"Duck can fly with {((IFly)this).Speed}");
        }

        public void Move()
        {
            Console.WriteLine($"Duck with weight {Weight} can walk with speed {((IMove)this).Speed}");
        }

        public void Swim()
        {
            Console.WriteLine("Duck can swim");
        }

    }
}
