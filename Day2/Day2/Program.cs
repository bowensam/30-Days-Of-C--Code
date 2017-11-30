using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Program
    {
        static void Main(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            decimal mealCost = Convert.ToDecimal(Console.ReadLine());
            decimal tipPercent = Convert.ToInt32(Console.ReadLine());
            decimal taxPercent = Convert.ToInt32(Console.ReadLine());

            decimal totalCost = mealCost + mealCost * (tipPercent / 100) + mealCost * (taxPercent / 100);
            int roundedTotalCost = (int)Math.Round(totalCost);

            Console.WriteLine("The total meal cost is " + roundedTotalCost + " dollars.");
        }
    }
}
