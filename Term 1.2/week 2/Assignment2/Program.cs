using System;

namespace Assignment2
{
    class Program
    {
<<<<<<< HEAD
        /// <summary>
        /// Entry point
        /// </summary>
=======
>>>>>>> programming2-week2/master
        static void Main()
        {
            Program myProgram = new Program();
            myProgram.Start();
        }

<<<<<<< HEAD
        /// <summary>
        /// Create an array of 3 Persons; Parse user information; print gathered information
        /// </summary>
        void Start()
        {
            // Create Person array with 3 persons
            Person[] persons = new Person[3];

            for (int i = 0; i < persons.Length; i++)
            {
                persons[i] = ReadPerson();
            }

            for (int i = 0; i < persons.Length; i++)
            {
                PrintPerson(persons[i]);
            }


            Console.WriteLine("Celebrating birthday!");

            CelebrateBirthday(persons[0]);

            PrintPerson(persons[0]);

            Console.ReadKey();
        }

        /// <summary>
        /// Takes a person and increases their age by 1
        /// </summary>
        void CelebrateBirthday(Person p)
        {
            p.Age += 1;
        }

        /// <summary>
        /// Read personal information and return a Person struct
        /// </summary>
        /// <returns></returns>
        Person ReadPerson()
        {
            // Pass by reference to be able to celebreate birthday
            Person person = new Person();

            // Use various Read methods to gather all information
            person.FirstName = ReadString("Enter first name: ");
            person.LastName = ReadString("Enter last name: ");
            person.City = ReadString("Enter city: ");
            person.Age = ReadInt("Enter age: ");
            person.Gender = ReadGender("Enter gender (m/f): ");

            // Return the Person object
            return person;
                
        }


        /// <summary>
        /// Reads gender from user; Returns a GenderType enum
        /// </summary>
        /// <param name="question"></param>
        /// <returns></returns>
        GenderType ReadGender(string question)
        {
            Console.Write(question);

            string gender = Console.ReadLine();

            GenderType gT = GenderType.Male;

            switch (gender)
            {
                case "m":
                    gT = GenderType.Male;
                    break;
                case "f":
                    gT = GenderType.Female;
                    break;

            }
            Console.WriteLine();

            return gT;
        }

        /// <summary>
        /// Prints all of a person's information
        /// </summary>
        /// <param name="p"></param>
        void PrintPerson(Person p)
        {
            Console.Write("{0} {1} ", p.FirstName, p.LastName);

            PrintGender(p.Gender);

            Console.WriteLine("{0} years old, {1}", p.Age.ToString(), p.City);

            Console.WriteLine();
        }

        /// <summary>
        /// Prints either (m) or (f) depending on gender
        /// </summary>
        /// <param name="gender"></param>
        void PrintGender(GenderType gender)
        {
            string genderShort = "";

            switch (gender)
            {
                case GenderType.Male:
                    genderShort = "(m)";
                    break;

                case GenderType.Female:
                    genderShort = "(f)";
                    break;
            }
            Console.WriteLine(genderShort);
        }

        /// <summary>
        /// Print a given question and return it's answer as an int.
        /// </summary>
        /// <param name="question"></param>
        /// <returns></returns>
        int ReadInt(string question)
        {
            Console.Write(question);
            return Convert.ToInt32(Console.ReadLine());
        }

        /// <summary>
        /// Ask for a question and return the answer.
        /// </summary>
        /// <param name="question"></param>
        /// <returns></returns>
        string ReadString(string question)
        {
            Console.Write(question);
            return Console.ReadLine();
=======
        void Start()
        {
            int[,] aMatrix = new int[11, 11];

            InitMatrixRandom(aMatrix, 1, 100);
            DisplayMatrix(aMatrix);

            Console.Write("Enter number (to search for): ");
            int searchNr = Convert.ToInt32(Console.ReadLine());

            Position userSearchPos = new Position();
            userSearchPos = SearchNumber(aMatrix, searchNr);
      

            Console.WriteLine("Number {0} is found (first) at position [{1},{2}]", searchNr, userSearchPos.row, userSearchPos.column);

            userSearchPos = SearchNumberBackwards(aMatrix, searchNr);
            Console.WriteLine("Number {0} is found (last) at position [{1},{2}]", searchNr, userSearchPos.row, userSearchPos.column);



            Console.ReadKey();
        }

        Position SearchNumberBackwards(int[,] matrix, int number)
        {
            Position searchPosition = new Position();

            // used to break out of both loops
            bool found = false;

            // Iterate backwards through array
            for (int row = matrix.GetLength(0); row > 0; row--)
            {
                for (int col = matrix.GetLength(1); col > 0; col--)
                {

                    // If a match is found, store current row and col in class and break out of the loop
                    if (matrix[row - 1, col - 1] == number)
                    {
                        searchPosition.row = row - 1;
                        searchPosition.column = col - 1;
                        found = true;
                        break;
                    }
                }

                // If a match was found, break the second loop as well.
                if (found)
                {
                    break;
                }
            }
            return searchPosition;
        }

        Position SearchNumber(int[,] matrix, int number)
        {
            Position searchPosition = new Position();

            // used to break out of both loops
            bool found = false;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    // If a match is found, store current row and col in class and break out of the loop
                    if (matrix[row, col] == number)
                    {
                        searchPosition.row = row;
                        searchPosition.column = col;

                        found = true;
                        break;
                    }
                }
                
                // If a match was found, break the second loop as well.
                if (found)
                {
                    break;
                }
            }
            return searchPosition;
        }

        void InitMatrixRandom(int[,] matrix, int min, int max)
        {
            Random rng = new Random();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rng.Next(min, max);
                }
            }
        }

        void DisplayMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0,2} ", matrix[row, col]);
                }

                Console.WriteLine();
            }
>>>>>>> programming2-week2/master
        }
    }
}
