using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace read_more
{
    class Program
    {
        static string BuildSentence (List<string> lineList)
        { 
            StringBuilder sentence = new StringBuilder();

            for (int i = 0; i < lineList.Count; i++)
            {
                string part = lineList[i];
                if (lineList[0].Length > 40)
                {
                    sentence.Append(lineList[0].Remove(40));
                    break;
                }
                else if (lineList[0].Length == 40)
                {
                    sentence.Append(lineList[0]);
                    break;
                }

                if (sentence.Length + part.Trim().Length > 40)
                {
                    break;
                }

                if (sentence.Length + part.Trim().Length <= 40)
                { 
                    sentence.Append(part);
                }
            }

            return sentence.ToString().Trim();
        }

        static void Main(string[] args)
        {
            using (StreamReader reader = File.OpenText("Input.txt"))
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (null == line)
                    continue;

                var result = ProcessString(line);

                if (!ValidateResults(line, result))
                {
                }
            }

            Console.ReadLine();
        }

        static bool ValidateResults(string input, string output)
        {
            if (input.Length <= 55)
            {
                Debug.Assert(input == output);
            }
            else
            {
                var myCut = DoThing(input);
                Debug.Assert(myCut == output);

                Debug.Assert(output.Length <= 55);
                Debug.Assert(output.Contains("... <Read More>"));
            }


            return false;
        }

        static string DoThing(string input)
        {
            var cutOne = input.Substring(0, 40);
            if (cutOne.Contains(" "))
            {
                var index = cutOne.LastIndexOf(" ");
                cutOne = cutOne.Substring(0, index);
            }
            cutOne += "... <Read More>";

            return cutOne;
        }

        static string ProcessString(string line)
        {
            //Console.WriteLine(line.Length);
            List<string> lineList = new List<string>();

            if (line.Length <= 55)
            {
                //Console.WriteLine(line);
                return line;
            }
            else
            {
                string[] splits = line.Split(' ');

                for (int i = 0; i < splits.Length; i++)
                {
                    if (i < splits.Length - 2)
                    {
                        lineList.Add(splits[i] + " ");
                    }
                    else
                    {
                        lineList.Add(splits[i]);
                    }
                }

                string sentence = BuildSentence(lineList);
                //Console.WriteLine(sentence.Length);
                //Console.WriteLine(sentence + "... <Read More>");
                return sentence + "... <Read More>";
            }
        }
    }
}

