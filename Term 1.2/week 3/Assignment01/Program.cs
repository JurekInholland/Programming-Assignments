using System;
using System.Collections.Generic;

namespace Assignment01
{
    class Program
    {
        static void Main()
        {
            Program myProgram = new Program();
            myProgram.Start();
        }

        void Start()
        {
            List<Course> report = ReadReport();
            DisplayReport(report);

            Console.ReadKey();
        }

        /// <summary>
        /// Generate a report by creating and filling 3 courses with user provided information
        /// </summary>
        /// <returns></returns>
        List<Course> ReadReport()
        {
            List<Course> reportList = new List<Course>();

            // Create and fill 3 courses
            for (int i = 0; i < 3; i++)
            {
                Course newCourse = ReadCourse("Name of the course: ");

                reportList.Add(newCourse);
            }
            // Return a list of courses
            return reportList;
        }

        /// <summary>
        /// Evaluate a list of courses. Determine if student has graduated or not
        /// </summary>
        /// <param name="courseList"></param>
        void DisplayReport(List<Course> courseList)
        {
            int remainingRetakes = 3;
            int cumLaudeCount = 0;

            // Iterate over list with a regular for loop (use .Count instead of .Length for lists)
            for (int i = 0; i < courseList.Count; i++)
            {
                DisplayCourse(courseList[i]);


                if (courseList[i].CumLaude() == true)
                {
                    cumLaudeCount++;
                } else if (courseList[i].Passed() == false)
                {
                    remainingRetakes--;
                }
            }

            if (remainingRetakes < 3)
            {
                Console.WriteLine("Too bad, you did not graduate, you got {0} retake(s).", remainingRetakes);

            // Check if every course was passed cum laude and make compliments
            } else if (cumLaudeCount == courseList.Count)
            {
                Console.WriteLine("Wow you graduated cum laude! You must be very smart!");
           
            // Passed but not cum laude, congratulate regardless
            } else
            {
                Console.WriteLine("Congrats, you graduated!");
            }
        }

        /// <summary>
        /// Read and convert a practical grade from the user
        /// </summary>
        /// <param name="question"></param>
        /// <returns></returns>
        PracticalGrade ReadPracticalGrade(string question)
        {
            Console.Write(question);

            Console.ForegroundColor = ConsoleColor.Green;
            int gradeIndex = Convert.ToInt32(Console.ReadLine());

            PracticalGrade grade = (PracticalGrade)gradeIndex;

            return grade;

        }
        
        /// <summary>
        /// Displays a practical grade
        /// </summary>
        /// <param name="practical"></param>
        void DisplayPracticalGrade(PracticalGrade practical)
        {
            Console.WriteLine(practical);
        }

        /// <summary>
        /// Read various course information from the user
        /// </summary>
        /// <param name="question"></param>
        /// <returns></returns>
        Course ReadCourse(string question)
        {
            
            Console.WriteLine("Enter a course.");

            Course course = new Course
            {
                name = ReadString(question)
            };

            Console.ResetColor();

            course.theoryGrade = ReadInt(string.Format("Grade for {0}: ", course.name));
            Console.ResetColor();

            // Print possible practical results; Enumerate over all possible enum values
            for (int i = 0; i < Enum.GetValues(typeof(PracticalGrade)).Length; i++)
            {
                Console.Write("{0}. {1} ", i, (PracticalGrade)i);
            }

            Console.WriteLine();

            course.practicalGrade = ReadPracticalGrade(string.Format("Practical grade for {0}: ", course.name));
            Console.ResetColor();

            Console.WriteLine();

            return course;
        }

        /// <summary>
        /// Display summarized course information
        /// </summary>
        /// <param name="course"></param>
        void DisplayCourse(Course course)
        {
            Console.WriteLine("{0}  : {1}    {2}", course.name, course.theoryGrade, course.practicalGrade);
        }

        /// <summary>
        /// Read a string input by the user
        /// </summary>
        /// <param name="question"></param>
        /// <returns></returns>
        string ReadString(string question)
        {
            Console.Write(question);
            Console.ForegroundColor = ConsoleColor.Green;

            return Console.ReadLine();
        }

        /// <summary>
        /// Read an int input by the user
        /// </summary>
        /// <param name="question"></param>
        /// <returns></returns>
        int ReadInt(string question)
        {
            Console.Write(question);
            Console.ForegroundColor = ConsoleColor.Green;

            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
