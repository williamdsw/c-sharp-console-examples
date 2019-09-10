using System;

namespace c_sharp_console_examples
{
    class RandomExamples
    {
        private const int MAX_NUMBER_OF_OCCURRENCES = 10;

        //-----------------------------------------------------------------------//
        // CONSTRUCTOR

        public RandomExamples()
        {
            Random random = new Random ();

            // Integers
            Console.WriteLine ("\n##### 10 random integers between 0 and 100 #####");
            for (int i = 0; i < MAX_NUMBER_OF_OCCURRENCES; i++)
            {
                Console.WriteLine (random.Next (100));
            }

            // Doubles
            Console.WriteLine ("\n##### 10 random doubles between 0.0 and 1.0 #####");
            for (int i = 0; i < MAX_NUMBER_OF_OCCURRENCES; i++)
            {
                Console.WriteLine (random.NextDouble ());
            }

            // Bytes
            Console.WriteLine ("\n##### 10 random bytes between 0 and 255 #####");
            byte[] buffer = new byte[10];

            for (int i = 0; i < MAX_NUMBER_OF_OCCURRENCES; i++)
            {
                random.NextBytes (buffer);
                Console.WriteLine (buffer[i]);
            }
        }
    }
}
