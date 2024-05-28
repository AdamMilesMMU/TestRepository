using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestStackApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IntStack testStack = new IntStack();

            int i = 1;

            while (!testStack.IsFull())
            {
                testStack.Push(i++);
            }

            while (!testStack.IsEmpty())
            {
                Console.WriteLine(testStack.Pop());
            }


            Console.ReadLine();

        }
    }
}
