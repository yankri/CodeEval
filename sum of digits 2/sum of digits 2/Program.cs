using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_of_digits_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given a positive integer, find the sum of its constituent digits.
            string line = Console.ReadLine();
            int num = int.Parse(line);

            int total = 0;

            for (int i = 1; i < line.Length; i++)
            {
                total += num[i];
            }

            Console.WriteLine(total);
        }
    }
}
