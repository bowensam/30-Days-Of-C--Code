using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11
{
    class Program
    {
        static void Main(String[] args)
        {
            int[][] arr = new int[6][];
            for (int arr_i = 0; arr_i < 6; arr_i++)
            {
                string[] arr_temp = Console.ReadLine().Split(' ');
                arr[arr_i] = Array.ConvertAll(arr_temp, Int32.Parse);
            }

            int largestSum = arr[0][0] + arr[0][1] + arr[0][2] + arr[1][1] + arr[2][0] + arr[2][1] + arr[2][2];
            for (int i = 0; i < arr.Length - 2; i++)
            {
                for (int j = 0; j < arr[i].Length - 2; j++)
                {
                    int currentSum = arr[0 + i][0 + j] + arr[0 + i][1 + j] + arr[0 + i][2 + j] + arr[1 + i][1 + j] + arr[2 + i][0 + j] + arr[2 + i][1 + j] + arr[2 + i][2 + j];

                    if (currentSum > largestSum)
                        largestSum = currentSum;
                }
            }
            Console.WriteLine(largestSum);
        }
    }
}
