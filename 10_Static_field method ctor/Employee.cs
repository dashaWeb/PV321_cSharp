using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Static_field_method_ctor
{
    enum Position { None, Manager, Developer, QA, Economist, Director}
    internal class Employee
    {
        private static int lastId;
        public readonly int ID = ++lastId;
        public string Name { get; set; } = "Noname";
        public DateTime Birth { get; set; }
        public Position Position { get; set; }

        public static int LastId { get => lastId; }
        public static bool SamePosition(Employee e1, Employee e2)
        {
            return e1.Position == e2.Position;
        }
        static Employee()
        {
            Console.WriteLine("Static ctor done");
            lastId = new Random().Next(1,10)*1000;
        }
        public int Age => (int)((DateTime.Today - Birth).TotalDays / 365.25);
        public override string ToString()
        {
            return $"ID :{ID,-5} Name : {Name,-10} Birth : {Birth.ToShortDateString(),-15} Position : {Position}";
        }
    }
}
