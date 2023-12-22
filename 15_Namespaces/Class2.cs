using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NS1
{
    internal class Class
    {
        public int a = 2;
        public void print()
        {
            Console.WriteLine("Print from NS1");
        }
    }
    namespace NS2
    {
        internal class Class
        {
            public int a = 2;
            public void print()
            {
                Console.WriteLine("Print from NS2");
            }
        }
    }
}
