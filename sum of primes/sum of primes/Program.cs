using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_of_primes
{
    class Program
    {
        public static bool is_Prime (int n)
        {
            if (n <= 1)
            {
                return false;
            }
            else if (n <= 3)
            {
                return true;
            }
            else if (n % 2 == 0 || n % 3 == 0)
            {
                return false;
            }
            int i = 5;
            while (i * i <= n)
            {
                if (n % i == 0 || n % (i + 2) == 0)
                {
                    return false;
                }
                i += 6;
            }
            return true;
        }


        static void Main(string[] args)
        {
            //Write a program which determines the sum of the first 1000 prime numbers. No input

            int sum = 0;
            int sumSum = 0;
            int numNum = 0;

            while (sumSum < 1000)
            {
                numNum++;
                if (is_Prime(numNum) == true)
                {
                    Console.WriteLine(numNum);
                    sum += numNum;
                    sumSum++;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
