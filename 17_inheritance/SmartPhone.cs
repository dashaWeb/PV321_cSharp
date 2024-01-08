using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_inheritance
{
    internal class SmartPhone : Device
    {
        public SmartPhone(string brand, int year) : base(brand, year)
        {
        }

        public override bool HasBattery => true;

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
