using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_Event
{
    delegate void PositionDelegate(string description); // 1) визначити тип делегату для нашої події (NewPosition) у класі Company
    internal class Company // publisher
    {
        public string Name { get; set; }
        public event PositionDelegate NewPosition; // 2) подія - екземпляр делегату
        public void AddPosition(string description) // 3) логіка
        {
            NewPosition?.Invoke(description);// 4) ініціювання(запуск) події
        }

    }
}
