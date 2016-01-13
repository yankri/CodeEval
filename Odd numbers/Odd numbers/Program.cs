using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print the odd numbers from 1 to 99, one number per line. 
           
            for (int i = 1; i < 100; i+=2)
            {
                int x = 0;
                Console.WriteLine(x + i);
            }
        }
    }
}
