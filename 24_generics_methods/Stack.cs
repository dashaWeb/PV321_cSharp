using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_generics_methods
{
     class Stack<T>:IStack<T>
    {
        T[] stack;
        const int Empty = -1;
        int top = Empty;
        public int Capacity { get => stack.Length; }
        public int Count => top + 1;

        public Stack(int capacity)
        {
            if (capacity < 0) capacity = 5;
            stack = new T[capacity];
        }
        bool Full()
        {
            return top == Capacity - 1;
        }
        public T Peek()
        {
            return stack[top];
        }

        public void Pop()
        {
            if(top >= 0)
            {
                top--;
            }
        }

        public void Push(T item)
        {
            if(Full())
            {
                Array.Resize(ref stack, Capacity * 2);
            }
            stack[++top] = item;
        }
        public override string ToString()
        {
            return String.Join<T>(". ", stack);
        }
    }
}
