using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter score: ");
            string score = Console.ReadLine();

            int scoreInt = int.Parse(score);

            string grade = "F";

            switch (scoreInt)
            {
                case var _ when scoreInt >= 90:
                    grade = "A";
                    break;
                case var _ when scoreInt >= 80:
                    grade = "B";
                    break;
                case var _ when scoreInt >= 70:
                    grade = "C";
                    break;
                case var _ when scoreInt >= 60:
                    grade = "D";
                    break;
                
            }

            Console.WriteLine("grade: {0}", grade);

            if (scoreInt >= 70)
            {
                Console.WriteLine("course passed");
            }
            else
            {
                Console.WriteLine("course not passed");
            }

            Console.ReadKey();
        }
    }
}
