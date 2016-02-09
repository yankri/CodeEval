using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace word_to_digit_take_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "zero;two;five;seven;eight;four";

            string[] splits = line.Split(';'); //splits the input into an array

            Dictionary<string, int> numbers = new Dictionary<string, int>(); //creates the dictionary
            numbers.Add("zero", 0);
            numbers.Add("one", 1);
            numbers.Add("two", 2);
            numbers.Add("three", 3);
            numbers.Add("four", 4);
            numbers.Add("five", 5);
            numbers.Add("six", 6);
            numbers.Add("seven", 7);
            numbers.Add("eight", 8);
            numbers.Add("nine", 9);

            for (int i = 0; i < splits.Length; i++)
            {
                if (numbers.ContainsKey(splits[i])) //contains method for dictionaries
                {
                    Console.Write(numbers[splits[i]]); //returns the value for the key, value pair
                }
            }
            Console.WriteLine();
        }
    }
}
