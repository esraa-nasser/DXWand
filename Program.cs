using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DXWandTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Word to Reverse:");

            // Create a string variable and get user input from the keyboard and store it in the variable
            string input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                //the time complexity is O(N)
                //the space complexity is O(N)
                Console.WriteLine( "Reversed string is:"+ ReverseString(input));
            }

        }
        static string ReverseString(string input)
        {
            try
            {
                // splitting input string by space and store the value in array
                var words = input.Split(" ");
                //string builder is recommended regading memory and performance
                StringBuilder stringBuilder = new StringBuilder();
                //loop over this array starting from lase item
                for (int i = words.Length - 1; i >= 0; i--)
                {
                    stringBuilder.Append(words[i] + " ");
                }
                char[] charsToTrim = { ' ' };
                //remove white space from start and end of string
                return stringBuilder.ToString().Trim(charsToTrim);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }
    }
}
