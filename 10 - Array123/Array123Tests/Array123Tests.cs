using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Array123;

namespace Array123Tests
{
    [TestFixture]
    public class Array123Tests
    {
        private Class1 _class1;

        [SetUp]
        public void BeforeTest()
        {
            _class1 = new Class1();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase(new int[] { 1, 1, 2, 3, 1 }, true)]
        [TestCase(new int[] { 1, 1, 2, 4, 1 }, false)]
        [TestCase(new int[] { 1, 1, 2, 1, 2, 3 }, true)]
        public void Array123_Array_ReturnBool(int[] numbers, bool expectedResult)
        {
            bool result = _class1.Array123(numbers);

            Assert.AreEqual(result, expectedResult);

            Console.WriteLine(expectedResult);
        }
    }
}
