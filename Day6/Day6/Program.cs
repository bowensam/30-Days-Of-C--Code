using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class Program
    {
        static void Main(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            int totalCase = Int32.Parse(Console.ReadLine());
            for (int testCase = 1; testCase <= totalCase; testCase++)
            {
                String word = Console.ReadLine();

                for (int i = 0; i < word.Length; i++)
                {
                    if (i % 2 == 0) //Even Index
                        Console.Write(word[i]);
                }
                Console.Write(" ");
                for (int i = 0; i < word.Length; i++)
                {
                    if (i % 2 != 0) //Odd Index
                        Console.Write(word[i]);
                }
                Console.WriteLine();
            }
        }
    }
}
