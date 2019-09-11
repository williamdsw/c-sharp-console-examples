using System;
using System.Collections.Generic;

namespace c_sharp_console_examples
{
    public class QueueExample
    {
        //-----------------------------------------------------------------------//
        // CONSTRUCTOR

        public QueueExample ()
        {
            string[] teamsArray = { "Arsenal", "Chelsea", "Liverpool", "Manchester City", "Manchester United", "Tottenham" };
            Queue<string> teams = new Queue<string> ();

            // Add values
            foreach (string team in teamsArray)
            {
                teams.Enqueue (team);
                Console.WriteLine("{0} has joined the Premier League", team);
            }

            // Remove values
            Console.WriteLine ("");
            while (teams.Count > 0)
            {
                string team = teams.Dequeue ();
                Console.WriteLine("{0} has left the Premier League", team);
            }
        }
    }
}