using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_Linq_to_object
{
    internal class Book
    {
        public enum CategoryBook { Cooking = 1, Children, Web, NET};
        public string Title { get; set; }
        public string Author { get; set; }
        public CategoryBook Category { get; set; }
        public ushort Year { get; set; }
        public float Price { get; set; }
        public override string ToString()
        {
            return $"{Author,-20}{Title,-30}{Category.ToString(),-10}{Year,-6}{Price}";
        }
    }
    class TestBook
    {
        public static void Test()
        {
            List<Book> books = new List<Book>
            {
                new Book{Title = "Web Development", Author = "Aki Iskandar ", Category = Book.CategoryBook.Web, Year = 2019, Price=39.99f },
                new Book{Title = "Bootstrap 4 ", Author = "Jacob Lett", Category = Book.CategoryBook.Web, Year = 2018, Price=31.5f },
                new Book{Title = "Professional C# 7 ", Author = "Christian Nagel ", Category = Book.CategoryBook.NET, Year = 2018, Price=60.0f },
                new Book{Title = "Pro C# 7: With .NET", Author = "Andrew Troelsen", Category = Book.CategoryBook.NET, Year = 2017, Price=39.0f },
                new Book{Title = "C# 7.0 in a Nutshell", Author = "Jozeph Albahari", Category = Book.CategoryBook.NET, Year = 2017, Price=79.99f },
                new Book{Title = "harry Potter", Author = "Rowling", Category = Book.CategoryBook.Children, Year = 2017, Price=19.99f }
            };
            var res_1 = from book in books
                        where book.Year <= 2018
                        orderby book.Author descending
                        select book;

            Console.WriteLine(string.Join<Book>("\n",res_1));

            Console.WriteLine($"Max Price {books.Max(i => i.Price)}");
            var res_2 = books.Where(b => b.Category == Book.CategoryBook.NET).OrderBy(b => b.Author);
            Console.WriteLine(string.Join<Book>("\n",res_2));

            Console.WriteLine();
            var res_3 = from book in books group book by book.Category;

            Console.WriteLine();
            foreach (var item in res_3)
            {
                Console.WriteLine($"____Key - {item.Key} ____ Count - {item.Count()} ______ Max Price {item.Max(i=>i.Price)}");
                foreach (var b in item)
                {
                    Console.WriteLine(b);
                }
            }
        }
    }
}
