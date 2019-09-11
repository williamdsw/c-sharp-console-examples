using System;
using System.Collections.Generic;
using System.Linq;

namespace c_sharp_console_examples
{
    public class ListExample
    {
        //-----------------------------------------------------------------------//
        // CONSTRUCTOR

        public ListExample ()
        {
            String output = "";
            List<int> numbers = new List<int>();

            // Filling
            for (int i = 0; i < 10; i++)
            {
                numbers.Add (i * i);
            }

            // Iterates
            Console.WriteLine ("Numbers in the list: ");
            for (int i = 0; i < numbers.Count; i++)
            {
                output += " " + numbers[i] + " ";
            }

            Console.WriteLine (output);
            
            // Insert value at specified index
            numbers.Insert (numbers.Count - 1, 150);

            // Remove first ocorrence of value
            numbers.Remove (4);

            // Remove value at specified index
            numbers.RemoveAt (6);

            // Iterates
            output = "";
            Console.WriteLine("List modified: ");
            foreach (int n in numbers)
            {
                output += " " + n + " ";
            }

            Console.WriteLine (output);

            // Other functions
            double average = numbers.Average ((n) => n);
            bool contains36 = numbers.Contains (36);
            int maximum = numbers.Max ();
            int minimum = numbers.Min ();
            int sum = numbers.Sum ();
            bool allAbove50 = numbers.TrueForAll ((n) => n > 50);

            Console.WriteLine ("Average = " + average);
            Console.WriteLine ("Contains the number 36 ? = " + (contains36 ? "Yes" : "No"));
            Console.WriteLine ("Maximum = " + maximum);
            Console.WriteLine ("Minimum = " + minimum);
            Console.WriteLine ("Sum = " + sum);
            Console.WriteLine ("All numbers are above 50 ? = " + (allAbove50 ? "Yes" : "No"));
        }
    }
}