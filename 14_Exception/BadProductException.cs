using System;

namespace _14_Exception
{
    internal class BadProductException:ApplicationException
    {
        public DateTime ErrorDate { get; set; }
        public BadProductException(string message, DateTime dt)
            :base(message) {
            ErrorDate = dt;
        }
    }
}
