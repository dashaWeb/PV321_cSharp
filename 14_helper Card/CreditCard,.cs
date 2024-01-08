using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_helper_Card
{
    public class BadNameException : Exception
    {
        public BadNameException(string message)
        :base(message){ }
    }
    public class BadNameCVV : Exception
    {
        public BadNameCVV(string message)
        : base(message) { }
    }
    internal class CreditCard_
    {
        private uint countDigits(long value)
        {
            uint counter = 0;
            while (value != 0)
            {
                counter++;
                value /= 10;
            }
            return counter;
        }
        private bool checkNumber(long value)
        {
            return countDigits(value) == 16;
        }
        private long number;
        private string name;
        private DateTime date;
        private uint cvv;
        public long Number { get => number; set => number = checkNumber(value) ? value : throw new Exception("Bad number card"); }
        public string Name { get => name; set=> name = String.IsNullOrWhiteSpace(value) ? throw new BadNameException("Bad Name") : value; }
        public DateTime Date { get=>date; set => date = value > DateTime.Now ? value : throw new Exception("Error expiration date"); }
        public uint CVv { get => cvv; set => cvv = countDigits(value) == 3 ? value : throw new BadNameCVV("Error CVV"); }

        public override string ToString()
        {
            return $"\n\t Name :: {Name, 30}, \n\t Number :: {Number,30}, \n\t Date :: {Date.ToShortDateString(),30}, \n\t CVV :: {CVv,30}";
        }
    }
}
