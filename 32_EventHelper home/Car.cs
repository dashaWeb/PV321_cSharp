using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_EventHelper_home
{
    class MyArgs
    {
        public string Brand { get; set; }
        public int Distance { get; set; }
    }
    internal class Car
    {
        public event EventHandler<MyArgs> start;
        public event EventHandler<MyArgs> finish;
        public event EventHandler<MyArgs> go;
        public int Distance { get; set; } = 0;
        public string Brand { get; set; }
        public void Start()
        {
            Distance = 0;
            Console.WriteLine($"Car {Brand} started !!!");
            start?.Invoke(this, new MyArgs { Brand = Brand, Distance = 0 });
        }
        public bool Go(int speed)
        {
            Distance += speed;
            if(Distance >= 100)
            {
                finish?.Invoke(this, new MyArgs { Brand = Brand, Distance = Distance });
                return true;
            }
            go?.Invoke(this, new MyArgs { Brand = Brand, Distance = Distance });
            return false;
        }
    }

}
