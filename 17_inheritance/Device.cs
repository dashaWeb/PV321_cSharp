using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_inheritance
{
    internal abstract class Device
    {
        protected string brand;
        public string Brand { 
            get=> brand; 
            set => brand = value ?? "NoBrand"; 
        }
        private int year;
        public int Year { 
            get=> year; 
            set => year = value <= DateTime.Today.Year? value : throw new Exception("Error year"); 
        }
        public Device(string brand, int year)
        {
            Brand = brand;
            Year = year;
        }
        //public virtual bool HasBattery { get => false; }
        public abstract bool HasBattery { get; }
        public override string ToString()
        {
            return $"Name :: {this.GetType().Name, -10}, Brand :: {Brand, -10}, Year :: {Year,-10}, HasBattery :: {HasBattery,-10}";
        }
    }
}
