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
            store = new int[maxSize];
        }


        public void Push(int value)
        {
            store[top++] = value;
        }

        public int Pop()
        {
            throw new NotImplementedException();

        }

        public bool IsEmpty()
        {
            throw new NotImplementedException();
        }

        public bool IsFull()
        {
            return top == maxSize;
        }

        public int Count()
        {
            throw new NotImplementedException();
        }


    }
}
