using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_Integers_from_file
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print out the sum of integers read from a file.
            //The first argument to the program will be a path to a filename containing a positive integer, one per line. E.g.

            //string line = "12345";

            string[] nums = line.Split('\n');

            int sumSum = 0;
            foreach (string c in nums)
            {
                int p = int.Parse(c);
                sumSum += p;
            }
            Console.WriteLine(sumSum);
        }
    }
}
