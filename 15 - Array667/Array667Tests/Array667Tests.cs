using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Array667;

namespace Array667Tests
{
    [TestFixture]
    public class Array667Tests
    {
        private Class1 _class1;

        [SetUp]
        public void BeforeTest()
        {
            _class1 = new Class1();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase(new int[] { 6, 6, 2 }, 1)]
        [TestCase(new int[] { 6, 6, 2, 6 }, 1)]
        [TestCase(new int[] { 6, 7, 2, 6 }, 1)]
        public void Array667_Array_ReturnInt(int[] numbers, int expectedResult)
        {
            int result = _class1.Array667(numbers);

            Assert.AreEqual(result, expectedResult);

            Console.WriteLine(expectedResult);
        }
    }
}
