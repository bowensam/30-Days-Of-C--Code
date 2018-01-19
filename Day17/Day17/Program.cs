using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day17
{
    class Calculator
    {
        internal int Power (int powerBase, int exponent)
        {
            if (powerBase < 0 || exponent < 0)
            {
                throw new Exception("n and p should be non-negative");
            }

            return Convert.ToInt32(Math.Pow(powerBase, exponent));
        }
    }

    class Solution
    {
        static void Main (String[] args)
        {
            Calculator myCalculator = new Calculator();

            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                String[] num = Console.ReadLine().Split();
                int n = int.Parse(num[0]);
                int p = int.Parse(num[1]);

                try
                {
                    int ans = myCalculator.Power(n, p);
                    Console.WriteLine(ans);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
