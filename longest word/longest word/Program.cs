using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace longest_word
{
    class Program
    {
        static void Main(string[] args)
        {

            //In this challenge you need to find the longest word in a sentence. 
            //If the sentence has more than one word of the same length you should pick the first one.
            //Each line has one or more words. Each word is separated by space char.


            string line = "kitty cat fluffymcfluff butt";

            string[] split = line.Split(' ');
            string longest = "";

            foreach (string word in split)
            {
                if (word.Length > longest.Length)
                {
                    longest = word;
                }
            }

            Console.WriteLine(longest);

        }
    }
}
