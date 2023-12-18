using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Character_
{
    /*
     private - доступ дозволено тільки в межах класу
     public - максимально доступний рівень
     protected - доступ дозволено з поточного класу та спадкоємцям
     iternal - доступ обмежено поточною збіркою
     protected iternal 
     private protected 
     */
    internal class Character // неявно успадкувався від супертипу Object
    {
        private string name = "Unknown";
        private uint hp;
        public Character(string name, uint hp, uint damage) {
            Name = name;
            this.hp = hp;
            Damage = damage;
        }
        public Character(string name = "Unknown")
            : this(name, 100, 1) { }
        public string Name
        {
            get { return name; }
            set { 
                //name = value; 
                /*if(value.Length != 0)
                {
                    name = value;
                }*/
                if(!String.IsNullOrWhiteSpace(value)) // якщо прийшло не пусто null "" "  " \t \n
                {
                    name = value;
                }
            }
        }
        public uint Damage { get; set; } // авто-властивість, компілятор створить поле типу uint та для нього get; set;
        public uint KPD {
            //get{return hp * Damage;}
            get => Damage * hp;
        }
        public void Print()
        {
            Console.WriteLine($"Character name : {Name}");
            Console.WriteLine($"Character hp : {hp}");
            Console.WriteLine($"Character damage : {Damage}");
        }
        public override string ToString()
        {
            return $" Name : {name,-10} HP : {hp,-10} Damage : {Damage}";
        }
    }
}
