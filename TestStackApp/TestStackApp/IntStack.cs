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
            
        }

        public IntStack(int maxSize)
        {
            this.maxSize = maxSize;
        }


        public void Push(int value)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public int Count()
        {
            throw new NotImplementedException();
        }


    }
}
