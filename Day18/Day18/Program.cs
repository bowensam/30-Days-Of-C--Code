using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day18
{
    class Solution
    {
        private List<char> stack = new List<char> ();
        private List<char> queue = new List<char> ();

        private void PushCharacter(char ch)
        {
            stack.Add(ch);
        }

        private void EnqueueCharacter(char ch)
        {
            queue.Add(ch);
        }

        private char PopCharacter()
        {
            char last = stack.ElementAt(stack.Count - 1);
            stack.RemoveAt(stack.Count - 1);
            return last;
        }

        private char DequeueCharacter()
        {
            char first = stack.ElementAt(0);
            stack.RemoveAt(0);
            return first;
        }


        static void Main(string[] args)
        {
            //Read the String s.
            String s = Console.ReadLine();

            //Create the Solution class object p.
            Solution obj = new Solution();

            //Push/Enqueue all the characters of String s to stack
            foreach (char c in s)
            {
                obj.PushCharacter(c);
                obj.EnqueueCharacter(c);
            }

            bool isPalindrome = true;

            //Pop the top character from stack.
            //Dequeue the first character from queue.
            //Compare both the characters.
            for (int i = 0; i < s.Length/2; i++)
            {
                if (obj.PopCharacter() != obj.DequeueCharacter())
                {
                    isPalindrome = false;
                    break;
                }
            }

            //Finally print whether String s is palindrome or not.
            if (isPalindrome)
                Console.Write("The word, {0}, is a palindrome.", s);
            else
                Console.Write("The word, {0}, is not a palindrome.", s);
        }
    }
}
