using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_helper_Card
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var card = new CreditCard_
            {
                CVv = 123,
                Date = new DateTime(2025, 05, 05),
                Name = "Masha",
                Number = 1111111111111111
            };
            try
            {
                /*uint cvv = uint.Parse(Console.ReadLine());
                DateTime date = DateTime.Parse(Console.ReadLine());*/
                Console.WriteLine(card);
                card.CVv = 1234;
            }
            catch (BadNameException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (BadNameCVV ex)
            {
                Console.WriteLine(ex.Message);
                card.CVv = 999;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine(card);
        }
    }
}
