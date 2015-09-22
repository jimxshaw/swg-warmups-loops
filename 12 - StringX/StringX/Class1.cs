using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringX
{
    public class Class1
    {
        public string StringX(string str)
        {
            string last = str.Substring(str.Length - 1);
            string first = str.Substring(0, 1);
            string middle = str.Substring(1, str.Length - 2);

            for (int i = 0; i < str.Length; i++)
            {
                if (middle.Contains("x"))
                {
                    middle = middle.Replace("x", "");
                }
            }

            return first + middle + last;

        }
    }
}
