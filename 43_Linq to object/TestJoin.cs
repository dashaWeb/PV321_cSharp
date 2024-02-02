using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_Linq_to_object
{
    class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    class Student
    {
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public int GroupId { get; set; }
    }
    internal class TestJoin
    {
        public static List<Group> groups = new List<Group>()
        { 
            new Group() { Id = 1, Name = "PD322"},
            new Group() { Id = 2, Name = "PV321"},
        };
        public static List<Student> students = new List<Student>()
        {
            new Student(){FirsName = "John", LastName = "Miller", GroupId = 2},
            new Student(){FirsName = "Alex", LastName = "Leman", GroupId = 1},
            new Student(){FirsName = "Joey", LastName = "Finch", GroupId = 2},
            new Student(){FirsName = "Nicole", LastName = "Taylor", GroupId = 3},
        };

        public static void Test()
        {
            var query = from g in groups
                        join st in students on g.Id equals st.GroupId
                        select new { FirstName = st.FirsName, LastName = st.LastName, GroupName = g.Name };
            Console.WriteLine("\n Students in group");
            foreach (var item in query)
            {
                Console.WriteLine($"Surname : {item.LastName}, Name : {item.FirstName}, Group : {item.GroupName}");
            }

            query = groups.Join(students, g => g.Id, st => st.GroupId, (g, st) => new { FirstName = st.FirsName, LastName = st.LastName, GroupName = g.Name });
            Console.WriteLine("\n Students in group");
            foreach (var item in query)
            {
                Console.WriteLine($"Surname : {item.LastName}, Name : {item.FirstName}, Group : {item.GroupName}");
            }
        }

    }
}
