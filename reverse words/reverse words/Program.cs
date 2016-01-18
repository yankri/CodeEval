using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse_words
{
    class Program
    {
        static void Reverse(string[] toReverse)
        {
            for (int index = 0; index < toReverse.Length / 2; index++)
            {
                string temp = toReverse[index];
                toReverse[index] = toReverse[toReverse.Length - index - 1]; 
                toReverse[toReverse.Length - index - 1] = temp;
            }
        }

        static void PrintWords(string[] wordsToPrint) //Prints out the values in the array plus a space to make them readable
        {
            StringBuilder returrn = new StringBuilder();

            foreach (string word in wordsToPrint)
            {
                returrn.Append(word + " ");
            }
            Console.Write(returrn.ToString().Trim());
        }

        static void Main(string[] args)
        {
            string line = "poop and butts and poop and butts";

            string[] words = line.Trim().Split(' ');

            Reverse(words);
            PrintWords(words);
            Console.WriteLine();
        }
    }
}
