using System;
using System.IO;
using System.Collections.Generic;

namespace Assignment1
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
            Person person;

            string name = ReadString("Enter your name: ");

            if (File.Exists(name + ".txt"))
            {
                Console.WriteLine("Nice to see you again, {0}!", name);
                person = ReadPerson(name + ".txt");
                DisplayPerson(person);

            } else
            {
                Console.WriteLine("Welcome {0}!", name);
                person = ReadPerson();
                WritePerson(person, person.name + ".txt");
            }

            Console.ReadKey();
        }

        void DisplayPerson(Person p)
        {
            Console.WriteLine("Name : {0,-10}", p.name);
            Console.WriteLine("City : {0,-10}", p.city);
            Console.WriteLine("Age : {0,-10}", p.age);
        }

        void WritePerson(Person p, string filename)
        {
            List<string> information = new List<string> {p.name, p.city, Convert.ToString(p.age)};

            StreamWriter writer = new StreamWriter(filename);
            foreach (string line in information)
            {
                writer.WriteLine(line);
            }

            writer.Close();

        }

        Person ReadPerson(string filename)
        {
            StreamReader reader = new StreamReader(filename);

            Person p = new Person
            {
                name = reader.ReadLine(),
                city = reader.ReadLine(),
                age = Convert.ToInt32(reader.ReadLine())
            };

            return p;

        }

        Person ReadPerson()
        {
            Person p = new Person
            {
                name = ReadString("Enter your name: "),
                city = ReadString("Enter your city: "),
                age = ReadInt("Enter your age: ")
            };

            return p;
        }

        string ReadString(string question)
        {
            Console.Write(question);
            return Console.ReadLine();
        }

        int ReadInt(string question)
        {
            Console.Write(question);
            return Convert.ToInt32(Console.ReadLine());
        }


    }
}
