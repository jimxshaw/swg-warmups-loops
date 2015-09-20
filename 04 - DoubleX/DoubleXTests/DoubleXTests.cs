using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using DoubleX;

namespace DoubleXTests
{
    [TestFixture]
    public class DoubleXTests
    {
        private Class1 _class1;

        [SetUp]
        public void BeforeTest()
        {
            _class1 = new Class1();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase("axxbb", true)]
        [TestCase("axaxxax", false)]
        [TestCase("xxxxx", true)]
        public void DoubleX_String_ReturnBool(string str, bool expectedResult)
        {
            bool result = _class1.DoubleX(str);

            Assert.AreEqual(result, expectedResult);
        }
    }
}
