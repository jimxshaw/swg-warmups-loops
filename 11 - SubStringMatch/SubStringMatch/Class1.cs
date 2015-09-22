using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubStringMatch
{
    public class Class1
    {
        public int SubStringMatch(string a, string b)
        {
            int match = 0;

            for (int i = 0; i < a.Length - 2; i++)
            {
                if (a[i] == b[i] && a[i + 1] == b[i + 1])
                {
                    match++;
                }
            }

            if (a == b && a.Length < 4)
            {
                match++;
            }

            return match;
        }
    }
}
