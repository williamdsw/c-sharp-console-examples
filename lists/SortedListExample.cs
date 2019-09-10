using System;
using System.Collections.Generic;

namespace c_sharp_console_examples
{
    class SortedListExample
    {
        //-----------------------------------------------------------------------//
        // CONSTRUCTOR

        public SortedListExample ()
        {
            SortedList<string, int> teamAges = new SortedList<string, int> ();

            // Adding
            teamAges.Add ("AC Milan", 1899);
            teamAges.Add ("Juventus", 1897);
            teamAges.Add ("Internazionale", 1908);
            teamAges.Add ("AS Roma", 1927);
            teamAges.Add ("Napoli", 1926);
            teamAges.Add ("Lazio", 1990);

            // Iterates
            foreach (KeyValuePair<string, int> pair in teamAges)
            {
                string name = pair.Key;
                int yearFoundation = pair.Value;
                int currentYear = DateTime.Now.Year;
                Console.WriteLine ("{0} have {1} years", name, (currentYear - yearFoundation));
            }
        }
    }
}