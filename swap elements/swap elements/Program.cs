using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swap_elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "1 2 3 4 5 6 7 8 9 : 0-8";

            string[] splits = line.Trim().Split(':');

            string[] range = splits[1].Trim().Split('-');
            
            List<int> swappers = new List<int>();

            string[] swappernums = splits[0].Trim().Split(' ');

           for (int i = 0; i < swappernums.Length; i++)
            {
                swappers.Add(int.Parse(swappernums[i]));
            }








        }
    }
}
