using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_static_class_demo
{
    static class AreaShape
    {
        const double PI = 3.14;
        public static double TrianArea(double height, double side)
        {
            return 0.5 * height * side;
        }
        public static double CircleArea(double radius)
        {
            return PI * Math.Pow(radius,2);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //AreaShape ar = new AreaShape();
            Console.WriteLine($"Trian area : {AreaShape.TrianArea(10,20)}");
        }
    }
}
