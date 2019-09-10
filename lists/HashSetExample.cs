using System;
using System.Collections.Generic;

namespace c_sharp_console_examples
{
    class HashSetExample
    {
        //-----------------------------------------------------------------------//
        // CONSTRUCTOR

        public HashSetExample ()
        {
            string[] franceArr = { "Lloris", "Pavard", "Varane", "Umtiti", "Lucas", "Mbappe", "Pogba", "Kante", "Matuidi", "Griezmann", "Giroud" };
            string[] croatiaArr = { "Subasic", "Vrsaljko", "Lovren", "Vida", "Strinic", "Rebic", "Rakitic", "Brozovic", "Perisic", "Modric", "Mandzukic" };

            HashSet<string> france = new HashSet<string> (franceArr);
            HashSet<string> croatia = new HashSet<string>(croatiaArr);

            Console.WriteLine ("##### France ######");
            foreach (string player in france)
            {
                Console.WriteLine (player);
            }

            Console.WriteLine("\n##### Croatia ######");
            foreach (string player in croatia)
            {
                Console.WriteLine (player);
            }

            // Merge hash sets
            HashSet<string> allPlayers = france;
            allPlayers.UnionWith (croatia);

            Console.WriteLine("\n##### All players ######");
            foreach (string player in allPlayers)
            {
                Console.WriteLine(player);
            }
        }
    }
}