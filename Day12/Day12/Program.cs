using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] inputs = Console.ReadLine().Split();
            String firstName = inputs[0];
            String lastName = inputs[1];
            int id = Convert.ToInt32(inputs[2]);
            int numScores = Convert.ToInt32(Console.ReadLine());
            inputs = Console.ReadLine().Split();
            int[] scores = new int[numScores];
            for (int i = 0; i < numScores; i++)
            {
                scores[i] = Convert.ToInt32(inputs[i]);
            }

            Student s = new Student(firstName, lastName, id, scores);
            s.printPerson();
            Console.WriteLine("Grade: " + s.Calculate() + "\n");
        }
    }

    class Person
    {
        protected String firstName;
        protected String lastName;
        protected int id;

        public Person() {}
        public Person(String firstName, String lastName, int identification)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = identification;
        }

        public void printPerson()
        {
            Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
        }
    }

    class Student : Person
    {
        private int[] testScores;

        /*	
        *   Class Constructor
        *   
        *   Parameters: 
        *   firstName - A string denoting the Person's first name.
        *   lastName - A string denoting the Person's last name.
        *   id - An integer denoting the Person's ID number.
        *   scores - An array of integers denoting the Person's test scores.
        */
        // Write your constructor here
        public Student(String firstName, String lastName, int id, int[] testScores) : base(firstName, lastName, id)
        {
            this.testScores = testScores;
        }
        /*	
        *   Method Name: Calculate
        *   Return: A character denoting the grade.
        */
        // Write your method here
        public char Calculate()
        {
            int sum = 0;
            for (int i = 0; i < testScores.Length; i++)
                sum += testScores[i];

            int average = sum / testScores.Length;

            if (average < 40) // average < 40
                return 'T';
            else if (average < 55) // 40 <= average < 55
                return 'D';
            else if (average < 70) // 55 <= average < 70
                return 'P';
            else if (average < 80) // 70 <= average < 80
                return 'A';
            else if (average < 90) // 80 <= average < 90
                return 'E';
            else // 90 <= average <= 100
                return 'O';
        }
    }
}
