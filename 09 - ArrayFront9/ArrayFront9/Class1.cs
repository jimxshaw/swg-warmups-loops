using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayFront9
{
    public class Class1
    {
        public bool ArrayFront9(int[] numbers)
        {
            bool nineExists = false;

            for (int i = 0; i < numbers.Length - 2; i++)
            {
                if (numbers[i] == 9)
                {
                    nineExists = true;
                }
            }

            return nineExists;
        }
    }
}
