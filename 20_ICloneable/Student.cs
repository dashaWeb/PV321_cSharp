using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_ICloneable
{
    internal class Student : ICloneable
    {
        private string name;
        public string Name { get => name; set => name = !String.IsNullOrWhiteSpace(value) ? value : throw new ArgumentNullException(); }
        private int[] marks;
        public Student(string name = "None", int number = 5)
        {
            Name = name;
            marks = new int[number];
        }
        public Student(string name = "None", params int[] marks_)
        {
            Name = name;
            marks = marks_.Clone() as int[];
        }

        public int this[int index]
        {
            get => marks[index];
            set => marks[index] = value > 0 && value <= 12 ? value : throw new Exception("Bad value");
        }
        public override string ToString()
        {
            return $"Name :: {Name,-10} Marks :: {String.Join<int>(", ", marks)}";
        }

        public object Clone()
        {
            //return new Student(this);

            Student st = new Student(Name, marks);
            return st;
        }
    }
}
