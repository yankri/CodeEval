using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_a_write
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "osSE5Gu0Vi8WRq93UvkYZCjaOKeNJfTyH6tzDQbxFm4M1ndXIPh27wBA rLclpg| 3 35 27 62 51 27 46 57 26 10 46 63 57 45 15 43 53";

            string[] split = line.Split('|');

            string characters = split[0];
            string numbers = split[1];
            
            string[] keys = numbers.Trim().Split(' ');

            foreach (string n in keys)
            {
                Console.Write(characters[int.Parse(n)-1]);
            }
            Console.WriteLine();

        }
    }
}
