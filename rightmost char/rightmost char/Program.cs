using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rightmost_char
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "r6JAXaQ4hPuboOMarsUfr8J9zWs98uR 9N9Tqg30iyXTFnfs vnH77q97AXpQHx619XR20nh0ixw,P";

            string[] split = line.Split(',');

            string phrase = split[0];
            string search = split[1];
            
            Console.WriteLine(search);

            Console.WriteLine(phrase.LastIndexOf(search));

        }
    }
}
