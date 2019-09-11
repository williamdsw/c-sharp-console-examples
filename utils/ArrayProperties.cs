using System;
using System.Linq;

namespace c_sharp_console_examples
{
    public class ArrayProperties
    {
        private int[] numbers = { 2, 5, 8, 11, 14 };

        //-----------------------------------------------------------------------//
        // CONSTRUCTOR

        public ArrayProperties ()
        {
            // Iterates
            for (int index = 0; index < numbers.Length; index++)
            {
                int number = (int) numbers.GetValue (index);
                Console.WriteLine ($"Index: {index} - Value: {number} ");
            }

            // Some properties
            int length = numbers.Length;
            int rank = numbers.Rank;
            int min = numbers.Min ();
            int max = numbers.Max ();
            double average = numbers.Average ();
            int sum = numbers.Sum ();
            bool containsTwo = numbers.Contains (2);
            bool containsHundred = numbers.Contains (100);
            int firstNumber = numbers.First ();
            int lastNumber = numbers.Last ();

            // Reset values
            Random random = new Random ();
            for (int index = 0; index < numbers.Length; index++)
            {
                int number = random.Next (20);
                numbers.SetValue (number, index);
                Console.WriteLine ($"{number} was set to index {index}");
            }

            // Output
            Console.WriteLine ("Numbers length: {0}", length);
            Console.WriteLine ("Numbers rank: {0}", rank);
            Console.WriteLine ("Numbers min value: {0}", min);
            Console.WriteLine ("Numbers max value: {0}", max);
            Console.WriteLine ("Numbers average value: {0}", average);
            Console.WriteLine ("Numbers sum: {0}", sum);
            Console.WriteLine ("Numbers contains the number {0}?: {1}", 2, containsTwo);
            Console.WriteLine ("Numbers contains the number {0}?: {1}", 100, containsHundred);
            Console.WriteLine ("Numbers first value: {0}", firstNumber);
            Console.WriteLine ("Numbers last value: {0}", lastNumber);
        }
    }
}