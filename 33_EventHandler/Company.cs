using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_EventHandler
{
    //delegate void PositionDelegate(string description); // 1) визначити тип делегату для нашої події (NewPosition) у класі Company
    class MyArg:EventArgs
    {
        public string Description { get; set; }
        public DateTime Date => DateTime.Now;
    }
    internal class Company // publisher
    {
        public string Name { get; set; }
        public event EventHandler<MyArg> NewPosition; // 2) подія - екземпляр делегату
        public void AddPosition(string description) // 3) логіка
        {
            MyArg myArg = new MyArg()
            {
                Description = description,
            };
            NewPosition?.Invoke(this,myArg);// 4) ініціювання(запуск) події
        }

    }
}
