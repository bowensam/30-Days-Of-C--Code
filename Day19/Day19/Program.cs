using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day19
{
    public interface IAdvancedArithmetic
    { //C# Convention: Interface identifer should begin with "I"
        int DivisorSum(int n);
    }

    class Calculator : IAdvancedArithmetic
    {
        public int DivisorSum (int n)
        {
            int sum = 0;
            for (int divisor = n; divisor > 0; divisor--)
            {
                if (n % divisor == 0)
                    sum += divisor;
            }
            return sum;
        }
    }

    class Solution
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            IAdvancedArithmetic myCalculator = new Calculator();
            int sum = myCalculator.DivisorSum(n);
            Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum);
        }
    }
}
