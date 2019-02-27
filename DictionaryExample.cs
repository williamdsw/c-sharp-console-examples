using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsoleExamples
{
    class DictionaryExample
    {
        public DictionaryExample ()
        {
            Dictionary<String, int> eventYears = new Dictionary<string, int> ();

            /* Adding */
            eventYears.Add ("World War I", 1914);
            eventYears.Add ("World War II", 1939);
            eventYears.Add ("The American Revolution", 1775);
            eventYears.Add ("The Reformation", 1517);
            eventYears.Add ("Tearing Down of the Berlin Wall", 1989);

            /* Iterates */
            foreach (KeyValuePair<string, int> pair in eventYears)
            {
                Console.WriteLine ("{0} has been started in {1}", pair.Key, pair.Value);
            }
        }
    }
}