using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace longest_word_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "kitty kitty mckitty cat pumpkinsssss";

            string[] split = line.Split(' ');
            string longest = "";

            for (int i = 0; i < split.Length; i++)
            {
                if (split[i].Length > longest.Length)
                {
                    longest = split[i];
                }
            }
            Console.WriteLine(longest);
            
        }
    }
}
