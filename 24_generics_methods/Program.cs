using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_generics_methods
{

    class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int CompareTo(Person other)
        {
            if(other == null) return 1;
            return this.Age.CompareTo(other.Age);
        }
        public virtual void Busy()
        {
            Console.WriteLine($"Person {Name} is busy ... ");
        }
    }
    class Employee:Person {
        public override void Busy()
        {
            Console.WriteLine($"Person {Name} is working ... ");
        }
    }
    internal class Program
    {
        static void Swap<T>(ref T x,ref T y)
        {
            var tmp = x;
            x = y;
            y = tmp;
        }
        static T Max<T>(T one, T two) where T : IComparable<T>
        {
            return one.CompareTo(two) > 0 ? one : two;
        }
        static void CheckBusy<T>(T person) where T:Person
        {
            person.Busy();
        }
        static void Main(string[] args)
        {
            /*int a = 5, b = 10;
            // ref, out
            double one = 2.5, two = 5.3;
            Console.WriteLine($"a = {a, -5} b = {b,-5}");
            Swap(ref a,ref b);
            Console.WriteLine($"a = {a, -5} b = {b,-5}");

            Console.WriteLine();
            Console.WriteLine($"one = {one, -5} two = {two,-5}");
            Swap(ref one,ref two);
            Console.WriteLine($"one = {one, -5} two = {two,-5}");*/

            /*Stack<int> stack = new Stack<int> (10);
            Console.WriteLine($"Count :: {stack.Count}, \t Capacity :: {stack.Capacity}");
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            Console.WriteLine($"Count :: {stack.Count}, \t Capacity :: {stack.Capacity}");
            Console.WriteLine($"Print Stack :: {stack}");


            stack.Pop();
            Console.WriteLine();
            Console.WriteLine($"Count :: {stack.Count}, \t Capacity :: {stack.Capacity}");*/

            Person person_1 = new Person { Name = "Oleg", Age = 22 };
            Person person_2 = new Person { Name = "Sasha", Age = 33 };

            Max(person_1,person_2).Busy();
            Employee employee= new Employee { Name = "Masha", Age = 21};
            CheckBusy<Employee>(employee);

            List<Employee> employees = new List<Employee>();
        }
    }
}
