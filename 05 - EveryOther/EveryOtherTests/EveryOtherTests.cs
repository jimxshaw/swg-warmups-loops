using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using EveryOther;

namespace EveryOtherTests
{
    [TestFixture]
    public class EveryOtherTests
    {
        private Class1 _class1;

        [SetUp]
        public void BeforeTest()
        {
            _class1 = new Class1();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase("Hello", "Hlo")]
        [TestCase("Hi", "H")]
        [TestCase("Heeololeo", "Hello")]
        public void EveryOther_String_ReturnNewString(string str, string expectedResult)
        {
            string result = _class1.EveryOther(str);

            Assert.AreEqual(result, expectedResult);
        }
    }
}
