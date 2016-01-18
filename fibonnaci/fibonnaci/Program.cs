using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonnaci
{
    class Program
    {
        public static int Fibonacci (int number)
        {
            if (number == 1 || number == 0)
            {
                return number;
            }
            return Fibonacci(number - 1) + Fibonacci(number - 2);
            
        }
        static void Main(string[] args)
        {
            //F(0) = 0; F(1) = 1; F(n) = F(n–1) + F(n–2) when n>1
            string line = "12";

            int number = int.Parse(line);
            Console.WriteLine(Fibonacci(number));
            

        }
    }
}
