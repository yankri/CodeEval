using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "-10 -10 -10 -10";
            string[] split = line.Split(' ');

            int O = int.Parse(split[0]);
            int P = int.Parse(split[1]);
            int Q = int.Parse(split[2]);
            int R = int.Parse(split[3]);

            bool A = P > R;
            bool B = P < R;
            bool C = O > Q;
            bool D = O < Q;
            bool E = O == Q;
            bool F = P == R;

            if (B == true && E == true)
            {
                Console.WriteLine("N");
            }
            else if (A == true && E == true)
            {
                Console.WriteLine("S");
            }
            else if (F == true && D == true)
            {
                Console.WriteLine("E");
            }
            else if (F == true && C == true)
            {
                Console.WriteLine("W");
            }
            else if (B == true && D == true)
            {
                Console.WriteLine("NE");
            }
            else if (B == true && C == true)
            {
                Console.WriteLine("NW");
            }
            else if (A == true && D == true)
            {
                Console.WriteLine("SE");
            }
            else if (A == true && C == true)
            {
                Console.WriteLine("SW");
            }
            else
            {
                Console.WriteLine("here");
            }
            

                      
        }
    }
}
