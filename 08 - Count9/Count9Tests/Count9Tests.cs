using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Count9;

namespace Count9Tests
{
    [TestFixture]
    public class Count9Tests
    {
        private Class1 _class1;

        [SetUp]
        public void BeforeTest()
        {
            _class1 = new Class1();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase(new int[] {1, 2, 9}, 1)]
        [TestCase(new int[] {1, 9, 9}, 2)]
        [TestCase(new int[] {1, 9, 9, 3, 9}, 3)]
        public void Count9_Array_ReturnInt(int[] numbers, int expectedResult)
        {
            int result = _class1.Count9(numbers);

            Assert.AreEqual(result, expectedResult);
        }
    }
}
