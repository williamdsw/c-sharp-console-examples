using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsoleExamples
{
    class EventExample
    {
        delegate void myDelegate ();
        private event myDelegate MyEvent;

        public EventExample()
        {
            /* New event and call*/
            MyEvent += new myDelegate (iteratePhrease);
            MyEvent ();
        }

        private void iteratePhrease ()
        {
            string phrase = "The world is a lonely place, you're on your own";
            int numberOfLowercases = 0;
            int numberOfUppercases = 0;
            int numberOfWhitespaces = 0;
            int numberOfLetters = 0;
            int numberOfPunctuations = 0;
            int numberOfDigits = 0;

            Console.WriteLine (phrase);

            /* Iterates */
            Console.WriteLine ("Iterating char by char:");
            foreach (char character in phrase)
            {
                Console.Write ("{0} ", character);

                if (Char.IsLower (character))
                    numberOfLowercases++;

                if (Char.IsUpper (character))
                    numberOfUppercases++;

                if (Char.IsWhiteSpace (character))
                    numberOfWhitespaces++;

                if (Char.IsLetter(character))
                    numberOfLetters++;

                if (Char.IsPunctuation (character))
                    numberOfPunctuations++;

                if (Char.IsDigit (character))
                    numberOfDigits++;
            }

            /* Results */
            Console.WriteLine ("\nNumber of Lowercases: {0}", numberOfLowercases);
            Console.WriteLine ("Number of Uppercases: {0}", numberOfUppercases);
            Console.WriteLine ("Number of Whitespaces: {0}", numberOfWhitespaces);
            Console.WriteLine ("Number of Letters: {0}", numberOfLetters);
            Console.WriteLine ("Number of Punctuations: {0}", numberOfPunctuations);
            Console.WriteLine ("Number of Digits: {0}", numberOfDigits);
        }
    }
}
