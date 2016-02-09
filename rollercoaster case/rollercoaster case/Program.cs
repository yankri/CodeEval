using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace rollercoaster_case
{
    class Program
    {

        static bool IsEven (int num)
        {
            if (num % 2 == 0)
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
            //first letter should be uppercase, next lower, then upper, etc, ignore other characters

            string line = "Donec eget dictum quam.";

            StringBuilder newWord = new StringBuilder();

            bool upper = false;

            string puncPattern = @"[!.,':;? ]";

            for (int i = 0; i < line.Length; i++)
            {
                
                Match result2 = Regex.Match(line[i].ToString(), puncPattern);

                if (result2.Success)
                {
                    newWord.Append(line[i]);
                    continue;
                }
                else
                {
                    if (i == 0)
                    {
                        newWord.Append(Char.ToUpper(line[i]));
                        upper = true;
                    }

                    else if (upper == false)
                    {
                        newWord.Append(Char.ToUpper(line[i]));
                        upper = true;
                    }
                    else
                    {
                        newWord.Append(Char.ToLower(line[i]));
                        upper = false; 
                    }
                }
            }

            Console.WriteLine(newWord);








        }
    }
}
