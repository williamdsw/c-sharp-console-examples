using System;
using System.Collections.Generic;

namespace c_sharp_console_examples
{
    public class DictionaryExample
    {
        //-----------------------------------------------------------------------//
        // CONSTRUCTOR

        public DictionaryExample ()
        {
            Dictionary<String, int> eventYears = new Dictionary<string, int> ();

            // Sets data
            eventYears.Add ("World War I", 1914);
            eventYears.Add ("World War II", 1939);
            eventYears.Add ("The American Revolution", 1775);
            eventYears.Add ("The Reformation", 1517);
            eventYears.Add ("Tearing Down of the Berlin Wall", 1989);

            // Iterates
            foreach (KeyValuePair<string, int> pair in eventYears)
            {
                Console.WriteLine ("{0} has been started in {1}", pair.Key, pair.Value);
            }
        }
    }
}