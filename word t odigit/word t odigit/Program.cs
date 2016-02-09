using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace word_t_odigit
{
    class Program
    {
        static void Main(string[] args)
        {
            //All numbers are separated by semicolon. There are up to 20 numbers in one line. The numbers are "zero" to "nine"
            //

            string line = "zero;two;five;seven;eight;four";

            string[] split = line.Split(';');

            foreach (string num in split)
            {
                switch (num)
                {
                    case "zero":
                        Console.Write(0);
                        break;
                    case "one":
                        Console.Write(1);
                        break;
                    case "two":
                        Console.Write(2);
                        break;
                    case "three":
                        Console.Write(3);
                        break;
                    case "four":
                        Console.Write(4);
                        break;
                    case "five":
                        Console.Write(5);
                        break;
                    case "six":
                        Console.Write(6);
                        break;
                    case "seven":
                        Console.Write(7);
                        break;
                    case "eight":
                        Console.Write(8);
                        break;
                    case "nine":
                        Console.Write(9);
                        break;
                    default:
                        Console.Write("error");
                        break;
                }   
            }
            Console.WriteLine();

        }
    }
}
