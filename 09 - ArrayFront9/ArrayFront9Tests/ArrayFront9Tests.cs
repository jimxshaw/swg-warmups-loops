using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ArrayFront9;

namespace ArrayFront9Tests
{
    [TestFixture]
    public class ArrayFront9Tests
    {
        private Class1 _class1;

        [SetUp]
        public void BeforeTest()
        {
            _class1 = new Class1();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase(new int[] {1, 2, 9, 3, 4}, true)]
        [TestCase(new int[] { 1, 2, 3, 4, 9 }, false)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, false)]
        public void ArrayFront9_Array_ReturnBool(int[] numbers, bool expectedResult)
        {
            bool result = _class1.ArrayFront9(numbers);

            Assert.AreEqual(result, expectedResult);
        }
    }
}
