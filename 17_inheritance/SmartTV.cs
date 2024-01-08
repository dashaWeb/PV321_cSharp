using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_inheritance
{
    internal class SmartTV : TV
    {

        public bool Effect { get; set; } = true;
        public SmartTV(string brand, int year, int diagonal) : base(brand, year, diagonal)
        {
        }
        public override void Print()
        {
            Console.WriteLine($"{this.GetType().Name} {Brand} can show tv-channels and effects");
        }
        public override string ToString()
        {
            return base.ToString() + $"Effect :: {Effect,-10}" ;
        }
    }
}
