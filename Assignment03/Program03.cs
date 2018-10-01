using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03
{
    class Program03
    {
        static void Main(string[] args)
        {
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
            Console.WriteLine("Student {0} has maximum grade {1}", studentNames[bestStudent], studentGrades[bestStudent]);
            Console.WriteLine();

            // Display detailed student information
            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.WriteLine("Grade for student {0} (course {1}) is: {2}", studentNames[i], course, studentGrades[i]);
            }
            Console.ReadKey();
        }
    }
}
