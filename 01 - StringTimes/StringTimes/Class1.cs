using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTimes
{
    public class Class1
    {
        public string StringTimes(string str, int n)
        {
            string newStr = "";

            for (int i = 0; i < n; i++)
            {
                newStr += str;
            }

            return newStr;
        }
    }
}
