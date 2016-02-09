using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swap_case
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program which swaps letters' case in a sentence. All non-letter characters should remain the same.

            string line = "Hello World!";

            char[] letters = line.ToCharArray();
            StringBuilder newword =  new StringBuilder();
            foreach (char letter in letters)
            {
                if (Convert.ToInt32(letter) < 91 && Convert.ToInt32(letter) > 64) //checks against the char integral value for uppercase characters
                {
                    newword.Append(Char.ToLower(letter));
                }
                else if (Convert.ToInt32(letter) > 96 && Convert.ToInt32(letter) < 123) //checks against the char integral value for lowercase characters
                {
                    
                    newword.Append(Char.ToUpper(letter));
                }
                else
                {
                    newword.Append(letter); //appends if its not a character
                }
            }
            Console.WriteLine(newword);






        }
    }
}
