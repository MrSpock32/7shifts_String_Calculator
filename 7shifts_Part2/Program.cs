using System;
using System.Linq;

namespace _7shifts_Part2
{

    /// <summary>
    /// 7shifts Technical Interview - String Calculator - Part 2
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
            Console.WriteLine("Hello World! 7shifts Technical Interview - String Calculator - Part 2");

            // "1\n,2,3" test
            Console.WriteLine("\nAdding \"1\\n,2,3\"...");
            Console.WriteLine(Add("1\n,2,3"));

            // "1,\n2,4" test
            Console.WriteLine("\nAdding \"1,\\n2,4\"...");
            Console.WriteLine(Add("1,\n2,4"));

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

                // Split input string into array, convert to integers, and calculate sum
                total = numbers.Split(',').Select(int.Parse).ToArray().Sum();

            }

            // Return the total
            return total;

        }

    }

}
