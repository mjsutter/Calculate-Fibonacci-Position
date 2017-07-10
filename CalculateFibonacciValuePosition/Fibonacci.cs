using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateFibonacciValuePosition
{
    public class Fibonacci
    {
        public int CalculateFibonacci(int position)
        {
            if (position <= 0)
            {
                return 0;
            }
            else if (position == 1)
            {
                return 1;
            }
            else
            {
                return CalculateFibonacci(position - 1) + CalculateFibonacci(position - 2);
            }
        }
    }
}
