using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace email_validation
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "foobar@poop.com";

            string patter2n = @"^[\w._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            string pattern = "(^(\"(.*)\"|[\\w._%+-]+)@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$)";
            

            Match result = Regex.Match(line, pattern);

            if (result.Success)
            {
                Console.WriteLine("true");
                Console.WriteLine(line);
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
