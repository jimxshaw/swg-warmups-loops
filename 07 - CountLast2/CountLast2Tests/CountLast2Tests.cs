using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CountLast2;

namespace CountLast2Tests
{
    [TestFixture]
    public class CountLast2Tests
    {
        private Class1 _class1;

        [SetUp]
        public void BeforeTest()
        {
            _class1 = new Class1();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase("hixxhi", 1)]
        [TestCase("xaxxaxaxx", 1)]
        [TestCase("axxxaaxx", 2)]
        public void CountLast2_String_ReturnInt(string str, int expectedResult)
        {
            int result = _class1.CountLast2(str);

            Assert.AreEqual(result, expectedResult);
        }
    }
}
