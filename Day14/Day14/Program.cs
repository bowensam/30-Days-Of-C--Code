using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14
{
    class Difference
    {
        private int[] elements;
        public int maximumDifference;

        public Difference(int[] elements)
        {
            this.elements = elements;
        }

        public int ComputeDifference()
        {
            int lowestNum = elements[0];
            int highestNum = elements[0];

            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i] > highestNum)
                    highestNum = elements[i];
                if (elements[i] < lowestNum)
                    lowestNum = elements[i];
            }

            maximumDifference = highestNum - lowestNum;
            return maximumDifference;
        }
    }

    class Solution
    {
        static void Main (String[] args)
        {
            Convert.ToInt32(Console.ReadLine());

            int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Difference d = new Difference(a);

            d.ComputeDifference();

            Console.WriteLine(d.maximumDifference);
        }
    }
}
