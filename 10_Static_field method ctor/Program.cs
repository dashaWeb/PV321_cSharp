using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Static_field_method_ctor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main started");
            Console.WriteLine($"Last ID : {Employee.LastId}");

            Employee em1 = new Employee() { Name = "Denis", Birth = DateTime.Parse("30/10/1990"), Position = Position.QA };
            Console.WriteLine(em1);
            Console.WriteLine($"Age : {em1.Age}");

            Employee em2 = new Employee()
            {
                Name = "Ivan",
                Birth = new DateTime(2000, 9, 16),
                Position = Position.Director,
            };
            Console.WriteLine(em2);
            Console.WriteLine($"Age : {em2.Age}");
            Console.WriteLine($"Same position : {Employee.SamePosition(em1,em2)}");
        }
    }
}
