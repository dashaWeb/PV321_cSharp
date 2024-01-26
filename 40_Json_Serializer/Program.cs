using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Newtonsoft.Json;
using System.Text.Json;
using System.Net;
namespace _40_Json_Serializer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(100, "Ford", 2.3);
            Car car2 = new Car(200, "BMW", 2.9);
            string fname = "car.json";

            /*string json = JsonConvert.SerializeObject(car);
            Console.WriteLine(json);
            File.WriteAllText(fname, json);*/

            /*var json = File.ReadAllText(fname);
            Car rCar = JsonConvert.DeserializeObject<Car>(json);
            Console.WriteLine(rCar);*/

            string salon = "salon.json";
            /*List<Car> listCar = new List<Car>() { car,car2};
            File.WriteAllText(salon, JsonConvert.SerializeObject(listCar));*/

            /*List<Car> list = JsonConvert.DeserializeObject<List<Car>>(File.ReadAllText(salon));
            Console.WriteLine($"Recovered \n{String.Join<Car>("\n",list)}");*/


            Dictionary<int, Car> list = new Dictionary<int, Car>()
            {
                [car.id] = car,
                [car2.id] = car2,
            };
            //File.WriteAllText(salon, JsonConvert.SerializeObject(list));

            /*var rDict = JsonConvert.DeserializeObject<Dictionary<int, Car>>(File.ReadAllText(salon));
            foreach (var item in rDict)
            {
                Console.WriteLine(item.Value);
            }*/
            /*var json = JsonSerializer.Serialize<Dictionary<int,Car>>(list); // only property
            Console.WriteLine(json);
            File.WriteAllText(salon, json);*/

            Dictionary<int, Car> res = JsonSerializer.Deserialize<Dictionary<int, Car>>(File.ReadAllText(salon));

            foreach (var item in res)
            {
                Console.WriteLine(item.Value);
            }

            Console.WriteLine("Home");
            WebClient client = new WebClient();
            var json = client.DownloadString("https://api.privatbank.ua/p24api/pubinfo?exchange&coursid=11");
            Console.WriteLine(json);
        }
    }
}
