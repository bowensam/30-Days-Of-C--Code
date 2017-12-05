using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    class Program
    {
        static void Main(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            Dictionary<String, String> phonebook = new Dictionary<String, String>();
            int entries = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < entries; i++)
            {
                String[] entry = Console.ReadLine().Split(' ');
                phonebook.Add(entry[0], entry[1]);
            }

            bool query = false;
            String tempInput = Console.ReadLine();
            if (tempInput != "")
                query = true;

            while (query)
            {
                if (phonebook.ContainsKey(tempInput) == true)
                    Console.WriteLine(tempInput + "=" + phonebook[tempInput]);

                else
                    Console.WriteLine("Not found");

                tempInput = Console.ReadLine();
                if (tempInput != "")
                    query = true;
                else
                    query = false;
            }
        }
    }
}
