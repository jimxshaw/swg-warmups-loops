using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleX
{
    public class Class1
    {
        public bool DoubleX(string str)
        {
            int findXX = str.IndexOf("xx");

            string newStr = str.Substring(0, findXX);

            if (newStr.Contains("x"))
            {
                return false;
            }

            return true;
        }
    }
}
