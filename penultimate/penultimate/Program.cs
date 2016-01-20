using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace penultimate
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program which finds the next-to-last word in a string.

            string line = "kitty cat mckitty pumpkins";

            string[] split = line.Split(' ');

            Console.WriteLine(split[split.Length - 2]);

        }
    }
}
