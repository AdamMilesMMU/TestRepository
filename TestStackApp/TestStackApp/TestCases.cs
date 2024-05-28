using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStackApp;
using NUnit.Framework;

namespace TestStackAppTestCases
{
    internal class TestCases
    {

        //Don't forget to install both NUnit testing + NUnit test adaptors in order to run properly...

        private IntStack testStack;

        [OneTimeSetUp]
        //Executed ONCE before ANY test
        public void OneTimeSetUp()
        {
            testStack = new IntStack(20);

        }

        [SetUp]
        //Executed just before each test
        public void SetUp()
        {
            //If Required
        }

        [Test]
        public void TASK1TestPush()
        {
            int i = 1;

            while (!testStack.IsFull())
            {
                testStack.Push(i);
                i++;
            }



        }

        [Test]
        public void TASK2TestPushAndPop()
        {
            int i = 1;

            while (!testStack.IsFull())
            {
                testStack.Push(i);
                i++;
            }

            while (!testStack.IsEmpty())
            {
                testStack.Pop();
            }


        }

    }

}
