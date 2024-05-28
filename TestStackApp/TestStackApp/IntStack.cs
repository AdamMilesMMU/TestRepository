using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestStackApp
{
    internal class IntStack
    {
        int maxSize = 10;
        int top = 0;
        int[] store;

        public IntStack()
        {
            store = new int[maxSize];
        }

        public IntStack(int maxSize)
        {
            this.maxSize = maxSize;
        }


        public void Push(int value)
        {
            store[top++] = value;
        }

        public int Pop()
        {
            return store[--top];

        }

        public bool IsEmpty()
        {
            return top == 0;
        }

        public bool IsFull()
        {
            return top == maxSize;
        }

        public int Count()
        {
            return top;
        }


    }
}
