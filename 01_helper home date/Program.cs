using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_helper_home_date
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string date = Console.ReadLine();
            Console.WriteLine(date);
            int day, month, year;
            /*string tmp = "";
            int counter = 0;
            while (date[counter] != '.')
            {
                tmp += date[counter++];
            }
            day = int.Parse(tmp);
            counter++;
            tmp = "";
            while (date[counter] != '.')
            {
                tmp += date[counter++];
            }
            month = int.Parse(tmp);
            counter++;
            tmp = "";
            while (date.Length != counter)
            {
                tmp += date[counter++];
            }
            year = int.Parse(tmp);*/
            var res = date.Split('.');
            day = int.Parse(res[0]);
            month = int.Parse(res[1]);
            year = int.Parse(res[2]);
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Winter");
                    break;
            }
            var name = new DateTime(year,month,day);
            Console.WriteLine(name.DayOfWeek);
        }
    }
}
