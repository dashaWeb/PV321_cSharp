using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_EventHandler
{
    internal class Interviwer // subscriber
    {
        public string Name { get; set; }
        // метод, що може бути обробником події (підходить під делегат PositionDelegate);
        public void DoSomething(object sender, MyArg arg)
        {
            Console.WriteLine($"Interviwer {Name} notified about {arg.Description};  Date {arg.Date.ToShortDateString()}");
        }
    }
}
