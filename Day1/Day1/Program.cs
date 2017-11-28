using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";

            // Declare second integer, double, and String variables.
            int inputI;
            double inputD;
            string inputS;

            // Read and save an integer, double, and String to your variables.
            inputI = Convert.ToInt32(Console.ReadLine());
            inputD = Convert.ToDouble(Console.ReadLine());
            inputS = Console.ReadLine();

            // Print the sum of both integer variables on a new line.
            Console.WriteLine(i + inputI);

            // Print the sum of the double variables on a new line.
            Console.WriteLine((d + inputD).ToString("N1"));

            // Concatenate and print the String variables on a new line
            // The 's' variable above should be printed first.
            Console.WriteLine(s + inputS);
        }
    }
}
