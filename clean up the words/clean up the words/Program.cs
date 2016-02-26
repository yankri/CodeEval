using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clean_up_the_words
{
    class Program
    {
        public static bool IsUpper(char chars) //determines if a char is an uppercase letter using char integral values
        {
            if (Convert.ToInt32(chars) > 64 && Convert.ToInt32(chars) < 91)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsLower(char chars) //determines if a char is a lowercase letter using char integral values 
        {
            if (Convert.ToInt32(chars) > 96 && Convert.ToInt32(chars) < 123)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            string line = "ozTZAj//]65w[GF6Y_Xt89,niRErcXal4pGS=)R8)ef&${G/f";

            char[] splits = line.ToCharArray(); //splits the string input into a char array

            List<char> chars = splits.ToList(); //probably not necessary to also convert to a list, but the first iterations of this a list made it easier so I went with ti

                StringBuilder phrase = new StringBuilder();

                for (int i = 0; i < chars.Count; i++)
                {
                    if (IsLower(chars[i]) == false && IsUpper(chars[i]) == false)  //skips the char if its not a letter
                    {
                        continue;
                    }

                    if (IsLower(chars[i]) == true || IsUpper(chars[i]) == true) //uses char integral value to determine if the char is a letter or not and if it is, appends it 
                    {
                        phrase.Append(Char.ToLower(chars[i])); //lowers the char to fit the challenge rules
                    }

                    if (i < chars.Count - 1) //adds the spaces except for the end based on if the char after chars[i] isn't a letter
                    {
                        if ((IsLower(chars[i]) == true || IsUpper(chars[i]) == true) && (IsLower(chars[i + 1]) == false && IsUpper(chars[i + 1]) == false))
                        {
                            phrase.Append("-"); //added dashes instead of spaces to make sure there were no trailing spaces
                        }
                    }
                }

                phrase.ToString();
                if (phrase[phrase.Length -1] == ' ')  //only trims the last character if its a space. Seems redundant to the above if statement, but I was getting results with trailing spaces so I added this too
                {
                    phrase.Length--;
                }

                Console.WriteLine(phrase);
        }
    }
}
