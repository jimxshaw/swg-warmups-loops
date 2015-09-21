using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using StringSplosion;

namespace StringSplosionTests
{
    [TestFixture]
    public class StringSplosionTests
    {
        private Class1 _class1;

        [SetUp]
        public void BeforeTest()
        {
            _class1 = new Class1();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase("Code", "CCoCodCode")]
        [TestCase("abc", "aababc")]
        [TestCase("ab", "aab")]
        public void StringSplosion_String_ReturnNewString(string str, string expectedResult)
        {
            string result = _class1.StringSplosion(str);

            Assert.AreEqual(result, expectedResult);
        }
    }
}
