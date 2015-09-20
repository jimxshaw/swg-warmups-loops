using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using FrontTimes;

namespace FrontTimesTests
{
    [TestFixture]
    public class FrontTimesTests
    {
        private Class1 _class1;

        [SetUp]
        public void BeforeTest()
        {
            _class1 = new Class1();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase("Chocolate", 2, "ChoCho")]
        [TestCase("Chocolate", 3, "ChoChoCho")]
        [TestCase("Abc", 3, "AbcAbcAbc")]
        public void FrontTimes_String_ReturnNewString(string str, int n, string expectedResult)
        {
            string result = _class1.FrontTimes(str, n);

            Assert.AreEqual(result, expectedResult);
        }
    }
}
