using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "-0.344 70.920 -38.797 14.354 99.323 90.374 7.581";

            string[] split = line.Split(' ');

            List<double> numNums = new List<double>();
            
            for (int i = 0; i < split.Length; i++)
            {
                numNums.Add(double.Parse(split[i]));
            }

            List<double> numNum =new List<double>(numNums.OrderBy(x => x));

            for (int j = 0; j < numNum.Count; j++)
            {
                Console.Write(numNum[j].ToString("00.000"));
                
                if (j < numNum.Count - 1)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
            


              



        }
    }
}
