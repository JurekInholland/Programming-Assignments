using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTools
{
    public class ReadTools
    {
        /// <summary>
        /// Print a given question and return it's answer as int.
        /// </summary>
        /// <param name="question"></param>
        /// <returns></returns>
        public static int ReadInt(string question)
        {
            Console.Write(question);
            return Convert.ToInt32(Console.ReadLine());
        }

        /// <summary>
        /// Overload ReadInt and additionally check if the input value is within a certain range.
        /// </summary>
        /// <param name="question"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static int ReadInt(string question, int min, int max)
        {
            // Call the original ReadInt method
            int result = ReadInt(question);

            // Ask again if the result is out of bounds
            while (result < min || result > max)
            {
                result = ReadInt(question);
            }

            return result;
        }

        /// <summary>
        /// Ask for a question and return the answer.
        /// </summary>
        /// <param name="question"></param>
        /// <returns></returns>
        public static string ReadString(string question)
        {
            Console.Write(question);
            return Console.ReadLine();
        }
    }
}
