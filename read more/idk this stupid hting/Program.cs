using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idk_this_stupid_hting
{
    class Program
    {
        static string TrimSentence(string line)
        {
               string part = line.Substring(0,40);
               
                if (part.Contains(" "))
                {
                    int index = part.LastIndexOf(" ");
                    part = part.Substring(0, index);
                    
                }

            return part.Trim();
        }

        static void Main(string[] args)
        {
                string line = "Let your sass I'll show you can hang the delivery of the rest of all owing to recite their tedious work.";

                if (line.Length <= 55)
                {
                    Console.WriteLine(line);
                }
                if (line.Length > 55)
                {
                    string sentence = TrimSentence(line);
                    Console.WriteLine(sentence + "... <Read More>");
                }
            }
        }
    }

