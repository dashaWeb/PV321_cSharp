using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_iComparable
{
    class Student : IComparable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }

        public int CompareTo(object obj)
        {

            // left > right --> 1
            // left < right --> -1
            // left = right --> 0
            if (obj is Student)
            {
                return LastName.CompareTo(((Student)obj).LastName);
            }
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"First Name :: {FirstName,-15} Last Name :: {LastName,-15} Birthdate :: {Birthdate.ToShortDateString(),-10}";
        }
    }
    class Auditory : IEnumerable
    {
        Student[] students =
            {
            new Student { 
                FirstName = "Candice",
                LastName = "Lemen",
                Birthdate = new DateTime(1998,05,23)
            },
            new Student {
                FirstName = "John",
                LastName = "Miller",
                Birthdate = new DateTime(2000,12,14)
            },
            new Student {
                FirstName = "Joey",
                LastName = "Finch",
                Birthdate = new DateTime(2002,01,01)
            },
            new Student {
                FirstName = "Nicole",
                LastName = "Taylor",
                Birthdate = new DateTime(1996,03,31)
            }
        };
        public IEnumerator GetEnumerator()
        {
            return students.GetEnumerator();
        }
        public void Sort()
        {
            Array.Sort(students);
        }
        public void Sort(IComparer comparer)
        {
            Array.Sort(students,comparer);
        }
        public override string ToString()
        {
            return $"{String.Join<Student>("\n", students)}";
        }
    }
    class DateComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            if(x is Student && y is Student)
            {
                return DateTime.Compare((x as Student).Birthdate, (y as Student).Birthdate);
            }
            throw new NotImplementedException();
        }
    }
    
}
