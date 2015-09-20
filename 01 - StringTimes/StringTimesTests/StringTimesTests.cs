using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using StringTimes;

namespace StringTimesTests
{
    [TestFixture]
    public class StringTimesTests
    {
        private Class1 _class1;

        [SetUp]
        public void BeforeTest()
        {
            _class1 = new Class1();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase("Hi", 2, "HiHi")]
        [TestCase("Hi", 3, "HiHiHi")]
        [TestCase("Hi", 1, "Hi")]
        public void StringTimes_String_ReturnNewString(string str, int n, string expectedResult)
        {
            string result = _class1.StringTimes(str, n);

            Assert.AreEqual(result, expectedResult);
        }
    }
}
