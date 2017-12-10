using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    class Program
    {
        //Required Output Format: Integer denoting N! where 2 <= N <= 12
        static void Main(String[] args)
        {
            Program p = new Program();
            int n = Convert.ToInt32(Console.ReadLine());
            int result = p.factorial(n);
            Console.WriteLine(result);
        }

        private int factorial(int n)
        {
            // Complete this function
            if (n == 0)
                return 1;
            return n * factorial(n - 1);
        }
    }
}
