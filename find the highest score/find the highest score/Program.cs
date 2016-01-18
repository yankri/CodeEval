using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace find_the_highest_score
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "72 64 150 156 | 100 18 33 300 | 13 250 -6 400";

            string[] split = line.Split('|');
            List<List <int>> bigList = new List<List <int>>();

            //string[] a = split[0].Trim().Split(' '); deletes leading and ending spaces
            for (int i = 0; i < split.Length; i++)
            {
                List<int> row = new List<int>(); //makes a list to store the row
                string[] splitRow = split[i].Trim().Split(' '); //makes an array of the string values from the first category
                for (int j = 0; j < splitRow.Length; j++)
                {
                    row.Add(int.Parse(splitRow[j])); //saves the values from the category into the row List and parses them
                }
                bigList.Add(row); //adds row into the big list of lists of ints
            }
            
            for (int i = 0; i < bigList[0].Count; i++) //counts the number of columns by determing the length of one row
            {
                int bigNum = int.MinValue;

                for (int j = 0; j < bigList.Count; j++) //determines how many rows there are
                {
                    
                    if (bigList[j][i] > bigNum)
                    {
                        bigNum = bigList[j][i];
                    }
                }
                Console.Write(bigNum);

                if (i < bigList[0].Count - 1)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}
