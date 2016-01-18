using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplication_table
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 12; i++)
            {
                for (int n = 1; n <= 12; n++)
                {
                    Console.Write("{0,-4}",(n * i));
                }
                Console.WriteLine();
            }
        }
    }
}
