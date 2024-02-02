using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_Linq_to_object
{
    // Sum, Min, Max, Average
    class User
    {
        public string  Name { get; set; }
        public int Age { get; set; }
    }
    internal class TestAgregation
    {
        public static void Test()
        {
            List<User> users = new List<User>()
            { 
                new User(){Name = "Pasha", Age = 23 },
                new User(){Name = "Masha", Age = 43 },
                new User(){Name = "Oleg", Age = 35 },
            };

            int sum = users.Sum(x => x.Age);
            Console.WriteLine($"Sum :: {sum}");
            int max = users.Max(x => x.Age); 
            Console.WriteLine($"Max :: {max}");
            int min = users.Min(x => x.Age);
            Console.WriteLine($"Min :: {min}");
            double avg = users.Average(x => x.Age);
            Console.WriteLine($"Avg :: {avg}");
        }
    }
}
