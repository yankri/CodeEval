using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;

namespace chardonnary_or_cabernet
{
    class Program
    {
        static void Main(string[] args)
        {
            //var count = mystring.Count(x => x == '$')
            string line = "x xaxx xaxax | xxxaa";

            string[] splits = line.Split('|');

            string first = splits[0].Trim(' ');
            string[] words = first.Split(' ');

            string second = splits[1].Trim(' ');
            char[] characters = second.ToCharArray();

            List<string> newList = new List<string>();

            for (int i = 0; i < words.Length; i ++)
            {
                int counter = 0;
                //var count = mystring.Count(x => x == '$')
                for (int j = 0; j < characters.Length; j++)
                {
                    if (characters.Count(y => y == characters[j]) > words[i].Count(x => x == characters[j]))
                    {
                        continue;
                    }
                    else
                    {
                        counter++;
                    }
                }

                if (counter == characters.Length)
                {
                    newList.Add(words[i]);
                }
            }

            if (newList.Count == 0)
            {
                Console.WriteLine("False");
            }
            else
            {
                for (int i = 0; i < newList.Count; i++)
                {
                    Console.Write(newList[i]);
                    if (i < newList.Count -1)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
