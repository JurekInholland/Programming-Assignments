using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main()
        {
            Program prog = new Program();
            prog.Start();
        }

        void Start()
        {
            string word = ReadString("Enter a word: ");
            Console.WriteLine();
            int occurences = SearchWordInFile("tweets.txt", word);
            Console.WriteLine("{0} occurences", occurences);
            Console.ReadKey();

        }

        void DisplayAllWordsInLine(string line, string word)
        {
            IEnumerable<int> index = line.ToLower().AllIndexesOf(word.ToLower());

            int start = 0;
            int count = 0;
            int firstLen = 0;
            int wordLen = word.Length;
            foreach (int ind in index)
            {
                //Console.Write("iter: {0} start: {1} ind: {2} greyLen: {3}", count, start, ind, firstLen);
                if (count == 0)
                {
                    firstLen = ind;
                }
                else
                {
                    firstLen = ind - start;
                }

                string first = line.Substring(start, firstLen);
                string colored = line.Substring(ind, word.Length);
                //string rest = line.Substring(ind + word.Length);

                start = ind + word.Length + 1;
                firstLen = first.Length;
                count++;
                Console.Write(first);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(colored);
                Console.ResetColor();
                //Console.Write(rest);
                //Console.WriteLine();
            }
            Console.Write(line.Substring(index.Last() + wordLen));
            Console.WriteLine();
            Console.WriteLine();

        }

        void DisplayWordInLine(string line, string word)
        {
            int start = line.ToLower().IndexOf(word);
            //Console.WriteLine("START: {0}", start);
            string first = line.Substring(0, start);
            string colored = line.Substring(start, word.Length);
            string rest = line.Substring(start + word.Length);

            Console.Write(first);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(colored);
            Console.ResetColor();
            Console.Write(rest);
            Console.WriteLine();
            Console.WriteLine();
        }

        bool WordInLine(string line, string word)
        {
            if (line.ToLower().Contains(word.ToLower()))
            {
                return true;
            }
            return false;
        }

        int SearchWordInFile(string filename, string word)
        {
            StreamReader reader = new StreamReader(filename);
            int occurences = 0;
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (WordInLine(line, word))
                {
                    occurences++;
                    //DisplayWordInLine(line, word);
                    //Console.WriteLine("displaying all words:");
                    DisplayAllWordsInLine(line, word);
                }
            }
            return occurences;
        }

        string ReadString(string question)
        {
            Console.Write(question);
            return Console.ReadLine();
        }


        
    }

    
}
