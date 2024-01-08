using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_inheritance
{
    internal class TV : Device
    {
        public int Diagonal { get; set; }
        public override bool HasBattery => true;
        public TV(string brand, int year,int diagonal)
            :base(brand,year)
        {
            Diagonal = diagonal;
        }
        public virtual void Print()
        {
            Console.WriteLine($"{this.GetType().Name} {Brand} can show tv-channels");
        }
        public override string ToString()
        {
            return base.ToString() + $"Diagonal :: {Diagonal,-10}";
        }
    }
}
