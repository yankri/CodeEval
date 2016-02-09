using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace calculate_distance
{
    class Program
    {
        public static int Distance (string line)
        {
            string lineEDIT = line.Trim('(').Trim(')');

            string[] split = lineEDIT.Split(' ');//split[0] = 25 split has 4 indices when split by spaces

            int x = int.Parse(split[0].Trim(','));
            int y = int.Parse(split[1].Trim(' ').Trim(')'));

            int w = int.Parse(split[2].Trim('(').Trim(','));
            int z = int.Parse(split[3].Trim(' '));

            int a = (x - w);
            int b = (y - z);

            int c = Convert.ToInt32(Math.Sqrt((a * a) + (b * b)));
            return c;
        }

        static void Main(string[] args)
        {
            //The String.Remove method removes a specified number of characters
            //that begin at a specified position in an existing string. This method assumes a zero-based index.
            
            string line = "(47, 43) (-25, -11)";
            Console.WriteLine(Distance(line));
            
        }
    }
}
