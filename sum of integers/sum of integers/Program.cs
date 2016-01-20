using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_of_integers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program to determine the largest sum of contiguous integers in a list.
            //-10,2,3,-2,0,5,-15
            //Print to stdout the largest sum. In other words, of all the possible contiguous subarrays 
            //for a given array, find the one with the largest sum, and print that sum.

            string line = "-10,2,3,-2,0,5,-15";

            string[] numNums = line.Split(',');

            List<int> numbers = new List<int>();

            for (int i = 0; i < numNums.Length - 1; i++)
            {
                numbers.Add(int.Parse(numNums[i]));
            }
            

            int sum = int.MinValue;
            int currentSum = 0;


            for (int i = 0; i < numbers.Count - 1; i++)
            {
                int firstIndex = numbers[i];

                for (int x = i +1; x < numbers.Count; x++)
                {
                    firstIndex = firstIndex + numbers[x];
                    if (firstIndex > sum)
                    {
                        if (firstIndex < 0)
                        {
                            sum = 0 - firstIndex;
                        }
                        sum = firstIndex;
                    }
                }
            }
            
            
                Console.WriteLine(sum);
            
        }
    }
}
