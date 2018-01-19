using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16
{
    class Solution
    {
        static void Main(string[] args)
        {
            String S = Console.ReadLine();

            try
            {
                int i = Int32.Parse(S);
                Console.WriteLine(i);
            }
            catch (FormatException)
            {
                Console.WriteLine("Bad String");
            }
        }
    }
}
