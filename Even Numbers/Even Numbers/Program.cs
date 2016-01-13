using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "701";
            int lineAsInt = Convert.ToInt32(line);

            if ((lineAsInt % 2) == 0)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
