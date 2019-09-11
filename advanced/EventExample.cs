using System;

namespace c_sharp_console_examples
{
    public class EventExample
    {
        private delegate void MyDelegate ();
        private event MyDelegate myEvent;

        //-----------------------------------------------------------------------//
        // CONSTRUCTOR

        public EventExample ()
        {
            // Set the event
            myEvent += new MyDelegate (IteratePhrase);
            myEvent ();
        }

        //-----------------------------------------------------------------------//
        // HELPER FUNCTIONS

        private void IteratePhrase ()
        {
            // State configs            
            int numberOfLowercases = 0;
            int numberOfUppercases = 0;
            int numberOfWhitespaces = 0;
            int numberOfLetters = 0;
            int numberOfPunctuations = 0;
            int numberOfDigits = 0;

            string phrase = "The world is a lonely place, you're on your own";
            Console.WriteLine (phrase);

            // Iterates the phrase and getting data
            Console.WriteLine ("Iterating the phrase char by char:");
            foreach (char character in phrase)
            {
                Console.Write ("{0} ", character);

                // Checks
                if (Char.IsLower (character)) { numberOfLowercases++; }
                if (Char.IsUpper (character)) { numberOfUppercases++; }
                if (Char.IsWhiteSpace (character)) { numberOfWhitespaces++; }
                if (Char.IsLetter (character)) { numberOfLetters++; }
                if (Char.IsPunctuation (character)) { numberOfPunctuations++; }
                if (Char.IsDigit (character)) { numberOfDigits++; }
            }

            // Prints results
            Console.WriteLine ("\nNumber of Lowercases: {0}", numberOfLowercases);
            Console.WriteLine ("Number of Uppercases: {0}", numberOfUppercases);
            Console.WriteLine ("Number of Whitespaces: {0}", numberOfWhitespaces);
            Console.WriteLine ("Number of Letters: {0}", numberOfLetters);
            Console.WriteLine ("Number of Punctuations: {0}", numberOfPunctuations);
            Console.WriteLine ("Number of Digits: {0}", numberOfDigits);
        }
    }
}