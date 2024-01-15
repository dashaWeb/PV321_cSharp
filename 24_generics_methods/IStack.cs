using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_generics_methods
{
    interface IStack<T>
    {
        void Push(T item);
        void Pop();
        T Peek();
        int Count { get; }
    }
}
