using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontTimes
{
    public class Class1
    {
        public string FrontTimes(string str, int n)
        {
            string front3 = "";
            string newStr = "";

            if (str.Length < 3)
            {
                front3 = str;
            }
            else
            {
                front3 = str.Substring(0, 3);
            }

            for (int i = 0; i < n; i++)
            {
                newStr += front3;
            }

            return newStr;
        }
    }
}
