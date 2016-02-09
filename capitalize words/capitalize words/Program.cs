using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capitalize_words
{
    class Program
    {

        public static string CapitalizeWords(string line)
        {
            StringBuilder word = new StringBuilder();

            for (int i = 0; i < line.Length; i++)
            {
                char ch = line[i];
                if (i == 0)
                {
                    ch = Char.ToUpper(line[0]);
                    word.Append(ch);
                }
                else
                {
                    word.Append(ch);
                }
            }
            return word.ToString();
        }

        static void Main(string[] args)
        {
            string line = "4t UZjU qhZd W 0xuy llM MGWNf wsflhq WwI uF r0K USs hxBSvHWDbXCIrC";

            string[] splits = line.Split(' ');

           for (int i = 0; i < splits.Length; i++)
            {
                Console.Write(CapitalizeWords(splits[i]));

                if (i < splits.Length - 1)
                {
                    Console.Write(" ");
                }
            }

            Console.WriteLine();
            
        }
    }
}
