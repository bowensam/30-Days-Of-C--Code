using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    class Program
    {
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            String binary = Convert.ToString(n, 2);

            int count = 1, longest = 1;

            for (int i = 0; i < binary.Length - 1; i++)
            {
                if (binary[i] == binary[i + 1])
                {
                    count++;
                    if (count > longest)
                        longest = count;
                }
                else if (binary[i] != binary[i + 1])
                    count = 1;
            }
            Console.WriteLine(longest);
        }
    }
}
