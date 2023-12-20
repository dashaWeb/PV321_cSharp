using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Overload_operators
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int x, int y)
        {
            X= x;
            Y= y;
        }
        public override string ToString()
        {
            return $"({X},{Y})";
        }
    }
    partial class Fraction
    {
        public int Num { get; set; }
        private int denom;
        public int Denom
        {
            get => denom;
            set => denom = value != 0 ? value : throw new Exception("Error denominator");
        }
        public Fraction(int num = 0, int denom = 1)
        {
            Num = num;
            Denom = denom;
        }
        public override string ToString()
        {
            return $"{Num}/{Denom}";
        }
        public override bool Equals(object obj)
        {
            Fraction fraction = obj as Fraction;
            if (fraction == null)
            {
                return false;
            }
            return this.Num * fraction.Denom == fraction.Num * this.Denom;
        }
        public int this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0:
                        return Num;
                    case 1: return denom;
                    default: throw new Exception($"Error (get) index {index}");
                }
            }
            set
            {
                switch (index)
                {
                    case 0:
                        Num = value;
                        break;
                    case 1:
                        Denom = value;
                        break;
                    default: throw new Exception($"Error (set) index {index}");
                }
            }
        }
    }
}
