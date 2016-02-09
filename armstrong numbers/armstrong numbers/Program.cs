using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace armstrong_numbers
{
    class Program
    {
        public static List<double> GetNums (string line)
        {
            char[] newArray = line.ToCharArray();

            List<double> numbers = new List<double>();

            foreach (char n in newArray)
            {
                numbers.Add(Convert.ToDouble(Char.GetNumericValue(n)));
            }

            return numbers;
        }
        static void Main(string[] args)
        {
            //An Armstrong number is a number such that the sum
            //of its digits raised to the third power is equal to the number
            //itself.For example, 371 is an Armstrong number, since
            //3 * *3 + 7 * *3 + 1 * *3 = 371.
            //An Armstrong number is an n-digit number that is equal to the sum of the n'th powers of its digits. 
            //Determine if the input numbers are Armstrong numbers.

            string line = "1634";
            double lineAsNum = double.Parse(line);

            List<double> numbers = new List<double>();

            numbers = GetNums(line);

            int length = numbers.Count;
            double sum = 0;

            for (int i = 0; i < length; i++)
            {
                sum += Math.Pow(numbers[i], length);
            }

            if (sum == lineAsNum)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }





        }
    }
}
