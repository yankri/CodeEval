using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_Fake
{
    class Program
    {
        public static int CCCheck(string ccNumber)
        {
            ccNumber = ccNumber.Replace(" ", string.Empty);
            int doublesSum = 0;
            int i;
            int otherNums = 0;

            for (i = 0; i < 16; i += 2)
            {
                int p = int.Parse(ccNumber[i].ToString());
                doublesSum += p * 2;
            }
        for (int j = 1; j< 16; j += 2)
           {
                if (j == i)
                {
                    continue;
                }
                else
                {
                    int q = int.Parse(ccNumber[j].ToString());
                    otherNums += q;
                }
            }
            int total = doublesSum + otherNums;
            return total;
        }
    
        public static string RealorFake(int total)
        {
            if (total % 10 == 0)
            {
                return "Real";
            }
            else
            {
                return "Fake";
            }
        }

        static void Main(string[] args)
        {
            string line = "9999 9999 9999 9993";
            Console.WriteLine(RealorFake(CCCheck(line)));

        }   
    }
}
