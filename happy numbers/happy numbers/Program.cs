using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace happy_numbers
{
    class Program
    {
        public static int[] DigitArray (string digitString)
        {
            char[] numbers = digitString.ToCharArray();
            int[] integers = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                integers[i] = int.Parse(numbers[i].ToString());
            }
            return integers;
        }
        static void Main(string[] args)
        {
            string line = "882";
            int[] integers = DigitArray(line);

            List<int> collection = new List<int> ();
            collection.Add(int.Parse(line));
            int n = 0;

            while (true)
            {
                for (int j = 0; j < integers.Length; j++)
                {
                    n += integers[j] * integers[j];
                }

                if (n == 1)
                {
                    Console.WriteLine("1");
                    break;
                }

                collection.Add(n);

                if (collection.Where(x => x.Equals(n)).Count() == 2)
                {
                    Console.WriteLine("0");
                    break;
                }
                
                integers = DigitArray(n.ToString());
                n = 0;
            }


            
           
        }
    }
}
