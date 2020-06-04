using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _7shifts_Bonus
{

    /// <summary>
    /// 7shifts Technical Interview - String Calculator - Bonus
    /// </summary>
    class Program
    {

        /// <summary>
        /// Main entry point of the executable.
        /// </summary>
        /// <param name="args">Command line arguments.</param>
        static void Main(string[] args)
        {

            // Output hello world and various Add() method tests to console
            Console.WriteLine("Hello World! 7shifts Technical Interview - String Calculator - Bonus:");

            // "//@\n2@1001" test
            Console.WriteLine("\nAdding \"//@\\n2@1001\"...");
            Console.WriteLine(Add("//@\\n2@1001"));

            // "//***\n1***2***3" test
            Console.WriteLine("\nAdding \"//***\\n1***2***3\"...");
            Console.WriteLine(Add("//***\\n1***2***3"));

            // "//$,@\n1$2@3" test
            Console.WriteLine("\nAdding \"//$,@\\n1$2@3\"...");
            Console.WriteLine(Add("//$,@\\n1$2@3"));

        }

        /// <summary>
        /// Adds a delimited number array string together and returns the total.
        /// </summary>
        /// <param name="numbers">The delimited number array string to be added together.</param>
        /// <returns>Returns the total of the numbers in the string.</returns>
        static int Add(string numbers)
        {

            // Initialize total to be returned
            int total = 0;

            // If a valid input string was entered...
            if (numbers != "")
            {

                // Initialize regular expression
                Regex regex = new Regex(@"^\/\/(.*)\\n(.*)$");

                // Get regex matches
                MatchCollection matches = regex.Matches(numbers);

                // If any regex matches were found...
                if (matches.Count > 0)
                {

                    // Get delimeters
                    string[] delimeters = matches[0].Groups[1].Value.Split(',');

                    // Get actual numbers string
                    string numbersArray = matches[0].Groups[2].Value;

                    // Split numbers string into array and convert to integers
                    int[] intsArray = numbersArray.Split(delimeters, StringSplitOptions.None).Select(int.Parse).ToArray();

                    // If any integers are negative...
                    if (intsArray.Min() < 0)
                    {
                        // Throw exception
                        throw new Exception("Negatives not allowed");
                    }
                    else
                    {
                        // Calculate sum of numbers less than 1000 in integer array
                        total = (from i in intsArray where i < 1000 select i).Sum();
                    }

                }

            }

            // Return the total
            return total;

        }

    }

}
