using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiply_lists
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "13 4 15 1 15 5 | 1 4 15 14 8 2";

            string[] splits = line.Split('|');

            string[] split1 = splits[0].Trim().Split(' ');
            string[] split2 = splits[1].Trim().Split(' ');

            List<int> first = new List<int>();
            List<int> second = new List<int>();

            foreach (string num in split1)
            {
                first.Add(int.Parse(num));
            }

            foreach (string numNum in split2)
            {
                second.Add(int.Parse(numNum));
            }

            for (int i = 0; i < first.Count; i++)
            {
                int sum = first[i] * second[i];
                Console.Write(sum);

                if (i < first.Count -1)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();

        }
    }
}
