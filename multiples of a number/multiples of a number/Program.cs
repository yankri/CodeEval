using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiples_of_a_number
{
    class Program
    {
        static void Main(string[] args)
        {
            //Given numbers x and n, where n is a power of 2, print out the smallest multiple of n which is greater than or equal to x. Do not use division or modulo operator.

            string line = "13,8";

            string[] splits = line.Split(',');

            int x = int.Parse(splits[0]);
            int n = int.Parse(splits[1]);

            for (int i = 0; i < int.MaxValue; i++)
            {
                int sum = n * i;

                if (sum > x)
                {
                    Console.WriteLine(sum);
                    break;
                }
                else
                {
                    continue;
                }
            }


        }
    }
}
