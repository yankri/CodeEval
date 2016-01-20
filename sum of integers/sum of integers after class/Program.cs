using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_of_integers_after_class
{
    class Program
    {
        public static List<int> intList (string line)
        {
            string[] numNums = line.Split(',');

            List<int> numbers = new List<int>();

            for (int i = 0; i < numNums.Length; i++)
            {
                numbers.Add(int.Parse(numNums[i]));
            }

            return numbers;
        }

        public static int MakeSums(int x, int y, List<int> numbers)
        {
            int sum = 0;
           Console.Write("Summing: " + x + " to " + y + " : ");
            for (int index = x; index <= y; index++)
            {
                sum += numbers[index];
                Console.Write(numbers[index] + ", ");
            }

            Console.Write(" = " + sum + "\n");
            return sum;
        }

        static void Main(string[] args)
        {
            string line = "-15,3";

            List<int> numbers = intList(line);

            int end = numbers.Count() - 1;

            //# of combos for each index is (end - index)

            //int totalCombos = 0;
            //int sum1 = 0;
            int largest = int.MinValue;

            /*for (int index = 0; index < end; index++)
            {
                totalCombos += (end - index);
            }*/

            if (numbers.Count == 1)
            {
                Console.WriteLine(numbers[0]);
            }

            for (int j = 0; j <= end; j++)
            {
                for (int i = j; i <= end; i++)
                {
                    int current = MakeSums(j, i, numbers);
                    
                    if (current > largest)
                    {
                        largest = current;
                    }
                    
                }
            }
            Console.WriteLine(largest);
            /*
            //numbers[1]
            int sum2 = 0;
            for (int i = 1; i <= end; i++)
            {
                sum2 += numbers[i];
                Console.WriteLine(sum2);
            }

            //numbers[2]
            int sum3 = 0;
            for (int i = 2; i <= end; i++)
            {
                sum3 += numbers[i];
                Console.WriteLine(sum3);
            }
                */
            



            /*
                for (int i = 0; i <= end; i++)
                {
                    sum1 += numbers[i];
                
                    if (sum1 > largest)
                    {
                        largest = sum1;
                    }
                }
            Console.WriteLine(largest); */
        }
    }
}
