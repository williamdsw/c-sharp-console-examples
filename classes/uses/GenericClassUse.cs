using System;

namespace c_sharp_console_examples
{
    public class GenericClassUse 
    {
        private const int MAX_NUMBER_OF_OCCURENCES = 10;

        //-----------------------------------------------------------------------//
        // CONSTRUCTOR

        public GenericClassUse ()
        {
            Random random = new Random ();

            // Example with integers
            GenericClass<int> intCollection = new GenericClass<int> ();
            for (int index = 0; index < MAX_NUMBER_OF_OCCURENCES; index++)
            {
                // Adds
                intCollection.Push (random.Next (1000));
                string output = "{0} was pushed to integer collection!";
                output = string.Format (output, intCollection.Get (index));
                Console.WriteLine (output);
            }

            for (int index = 0; index < MAX_NUMBER_OF_OCCURENCES; index++)
            {
                // Removes
                int item = intCollection.Pop ();
                string output = "{0} was popped from integer collection!";
                output = string.Format (output, item);
                Console.WriteLine (output);
            }

            // Example with doubles
            GenericClass<double> doubleCollection = new GenericClass<double> ();
            for (int index = 0; index < MAX_NUMBER_OF_OCCURENCES; index++)
            {
                // Adds
                doubleCollection.Push (random.NextDouble ());
                string output = "{0} was pushed to double collection!";
                output = string.Format (output, doubleCollection.Get (index).ToString ("0.00"));
                Console.WriteLine (output);
            }

            for (int index = 0; index < MAX_NUMBER_OF_OCCURENCES; index++)
            {
                // Removes
                double item = doubleCollection.Pop ();
                string output = "{0} was popped from double collection!";
                output = string.Format (output, item.ToString ("0.00"));
                Console.WriteLine (output);
            }

            // Example with strings
            GenericClass<string> stringCollection = new GenericClass<string> ();
            stringCollection.Push ("D");
            stringCollection.Push ("K");
            stringCollection.Push ("C");

            for (int index = 0; index < stringCollection.Length; index++)
            {
                // Iterates
                string item = stringCollection.Get (index);
                if (!string.IsNullOrEmpty (item) || !string.IsNullOrWhiteSpace (item))
                {
                    Console.WriteLine (item);
                }
            }
        }
    }
}