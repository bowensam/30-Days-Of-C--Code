using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20
{
    class Solution
    {
        private int numSwaps = 0;

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            String[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            
            Solution s = new Solution();
            s.BubbleSort(a);

            Console.WriteLine("Array is sorted in {0} swaps.", s.numSwaps);
            Console.WriteLine("First Element: " + a[0]);
            Console.WriteLine("Last Element: " + a[a.Length-1]);
        }

        private void BubbleSort (int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {                
                bool noSwap = true;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        Swap(array, i, j);
                        noSwap = false;
                    }
                }
                if (noSwap)
                    break;
            }
        }

        private void Swap (int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;

            numSwaps++;
        }
    }
}
