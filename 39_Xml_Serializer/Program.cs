using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _39_Xml_Serializer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(100, "Ford", 2.3);
            Car car2 = new Car(200, "BMW", 2.9);
            string fname = "car.xml";

            XmlSerializer xs = new XmlSerializer(typeof(Car));
            using(FileStream fs = new FileStream(fname, FileMode.Create))
            {
                xs.Serialize(fs, car);

                fs.Position = 0;
                Car rcar = (Car)xs.Deserialize(fs);
                Console.WriteLine(rcar);
            }

            string fnameCar = "listCars.xml";
            List<Car> list = new List<Car>() { car,car2};
            XmlSerializer xsL = new XmlSerializer(typeof(List<Car>));
            using(FileStream fs = new FileStream(fnameCar, FileMode.Create))
            {
                xsL.Serialize(fs, list);

                fs.Position = 0;
                List<Car> reList = xsL.Deserialize(fs) as List<Car>;
                Console.WriteLine($"\n\n Recovered list of car \n{String.Join<Car>("\n",reList)}");
            }
        }
    }
}
