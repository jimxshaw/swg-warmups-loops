using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern51
{
    public class Class1
    {
        public bool Pattern51(int[] numbers)
        {
            bool patternExists = false;

            for (int i = 0; i < numbers.Length - 2; i++)
            {
                int x = numbers[i];
                int y = x + 5;
                int z = numbers[i] - 1;

                if (numbers[i] == x && numbers[i + 1] == y && numbers[i + 2] == z)
                {
                    patternExists = true;
                }
            }

            return patternExists;
        }
    }
}
