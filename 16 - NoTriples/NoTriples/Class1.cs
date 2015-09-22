using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoTriples
{
    public class Class1
    {
        public bool NoTriples(int[] numbers)
        {
            bool noTriples = true;

            for (int i = 0; i < numbers.Length - 2; i++)
            {
                if (numbers[i] == numbers[i + 1] && numbers[i] == numbers[i + 2] && numbers[i + 1] == numbers[i + 2])
                {
                    noTriples = false;
                }
            }

            return noTriples;
        }
    }
}
