using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_of_digits_again
{
    class Program
    {
        static void Main(string[] args)
        {
            //Given a positive integer, find the sum of its constituent digits.

            //The first argument will be a path to a filename containing positive integers, one per line. E.g.

            string line = "12345";

            int i;
            int stdout = 0;

            for (i = 0; i < line.Length; i++)
            {
                stdout += Convert.ToInt32(Char.GetNumericValue(line[i]));
            }

            Console.WriteLine(stdout);




        }
    }
}
