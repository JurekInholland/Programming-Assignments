using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03
{
    class Program03
    {
<<<<<<< HEAD
        /// <summary>
        /// Assignment 3 (Console Application)
        /// Several numbers are entered. Determine and print the sum of the 5th,
        /// 10th, 15th number, etc
        /// </summary>
        static void Main(string[] args)
        {
            // Declare and set iterator and sum; make loop exitable
            int i = 0;
            int sum = 0;
            int stop = 0;


            while (stop != 1)
            {
                // Get user input
                Console.Write("Enter a number: ");
                string userInput = Console.ReadLine();

                // Increase iterator to keep track of the number of entered numbers
                i++;

                // Output sums once 0 is entered
                if (userInput == "0")
                {
                    Console.Write("Sum of 5th, 10th, 15th, ... number is: ");
                    Console.WriteLine(sum);
                    stop = 1;
                }

                int inputInt = int.Parse(userInput);

                // Sum if iterator is diviseable by 5
                if (i % 5 == 0)
                {
                    sum += inputInt;
                }
=======
        static void Main(string[] args)
        {
            // Use a dot as decimal seperator unaffected by os locale settings
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            // Parse user input
            Console.Write("Enter course name: ");
            string course = Console.ReadLine();

            Console.Write("Enter number of students: ");
            string numberOfStudentsStr = Console.ReadLine();
            int numberOfStudents = Convert.ToInt32(numberOfStudentsStr);

            Console.WriteLine();

            // Create arrays that will hold student names and grades
            var studentNames = new string[numberOfStudents];
            var studentGrades = new double[numberOfStudents];

            double totalGrades = 0;
            double highestGrade = 0;
            int bestStudent = 0;

            // Ask for and store student's names
            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.Write("Enter name of student {0}: ", i + 1);
                studentNames[i] = Console.ReadLine();
            }

            Console.WriteLine();

            // Ask for and store student's grades
            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.Write("Enter grade of {0}: ", studentNames[i]);
                string gradeStr = Console.ReadLine();
                double grade = Convert.ToDouble(gradeStr);
                studentGrades[i] = grade;
                totalGrades += grade;

                // Store the index of the student with the highest grade
                if (grade > highestGrade)
                {
                    highestGrade = grade;
                    bestStudent = i;
                }
            }

            double averageGrade = totalGrades / numberOfStudents;

            // Output average and top student
            Console.WriteLine();
            Console.WriteLine("Average grade: {0}", averageGrade.ToString("0.00"));
            Console.WriteLine("Student {0} has maximum grade {1}", studentNames[bestStudent], studentGrades[bestStudent].ToString("0.00"));
            Console.WriteLine();

            // Display detailed student information
            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.WriteLine("Grade for student {0} (course {1}) is: {2}", studentNames[i], course, studentGrades[i].ToString("0.0"));
>>>>>>> programming-week5/master
            }
            Console.ReadKey();
        }
    }
}
