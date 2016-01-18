using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_mod_M
{
    class Program
    {
        public static int Modulus(string line)
        {
            string[] split = line.Split(',');

            int n = int.Parse(split[0]);
            int m = int.Parse(split[1]);

            int poopMod = n - ((n / m)* m) ;

            return poopMod;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Modulus(line));
        }
    }
}
