using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program
    {
        static void Main(String[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());

            if (N % 2 == 1) //N is Odd
                Console.WriteLine("Weird");

            else
            { //N is Even
                if (6 <= N && N <= 20)
                    Console.WriteLine("Weird");
                else
                    Console.WriteLine("Not Weird");
            }
        }
    }
}
