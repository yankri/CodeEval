using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mixed_content
{
    class Program
    {
        static void Main(string[] args)
        {
            //You have a string of words and digits divided by comma. Write a program which separates words with digits. You shouldn't change the order elements.
            //As you cas see you need to output the same input string if it has words only or digits only.


            string line = "8,33,21,0,16,50,37,0,melon,7,apricot,peach,pineapple,17,21";

            string[] splits = line.Split(',');

            List<int> numbers = new List<int>();
            List<string> words = new List<string>();
            bool result = false;
            int num;

            for (int i = 0; i < splits.Length; i++)
            {
                result = int.TryParse(splits[i], out num);

                if (result == true)
                {
                    numbers.Add(num);
                }
                else
                {
                    words.Add(splits[i]);
                }
            }

            if (numbers.Count == 0)
            {
                for (int i = 0; i < words.Count; i++)
                {
                    Console.Write(words[i]);

                    if (i < words.Count - 1)
                    {
                        Console.Write(',');
                    }
                }
                Console.WriteLine();
            }
            else if (words.Count == 0)
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    Console.Write(numbers[i]);

                    if (i < numbers.Count - 1)
                    {
                        Console.Write(',');
                    }
                }
                Console.WriteLine();
            }
            else
            {
                for (int i = 0; i < words.Count; i++)
                {
                    Console.Write(words[i]);

                    if (i < words.Count - 1)
                    {
                        Console.Write(',');
                    }
                }

                Console.Write('|');

                for (int i = 0; i < numbers.Count; i++)
                {
                    Console.Write(numbers[i]);

                    if (i < numbers.Count - 1)
                    {
                        Console.Write(',');
                    }
                }
                Console.WriteLine();
            }


        }
    }
}
