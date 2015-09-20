using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CountXX;

namespace CountXXTests
{
    [TestFixture]
    public class CountXXTests
    {
        private Class1 _class1;

        [SetUp]
        public void BeforeTest()
        {
            _class1 = new Class1();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase("abcxx", 1)]
        [TestCase("xxx", 2)]
        [TestCase("xxxx", 3)]
        public void CountXX_String_ReturnInt(string str, int expectedResult)
        {
            int result = _class1.CountXX(str);

            Assert.AreEqual(result, expectedResult);
        }
    }
}
