using System;

namespace Assignment2
{
    class Program
    {
        /// <summary>
        /// Entry point
        /// </summary>
        static void Main()
        {
            Program myProgram = new Program();
            myProgram.Start();
        }

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

            Console.ReadKey();
        }


        /// <summary>
        /// Read personal information and return a Person struct
        /// </summary>
        /// <returns></returns>
        Person ReadPerson()
        {
            Person person;

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
        }
    }
}
