using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "4 3 96";

            string[] split = line.Split(' ');

            int x = int.Parse(split[0]);
            int y = int.Parse(split[1]);
            int n = int.Parse(split[2]);

            for (int i = 0; i <= n; i++)
            {
                if (i % x == 0 && i % y == 0)
                {
                    Console.Write("FB");
                }
                else if (i % y == 0)
                {
                    Console.Write("B");
                }
                else if (i % x == 0)
                {
                    Console.Write("F");
                }
                else
                {
                    Console.Write(i);
                }
                
                if (i < n)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();

        }
    }
}
