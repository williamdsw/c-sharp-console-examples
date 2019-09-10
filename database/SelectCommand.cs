using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

// Solution to “The given key was not present in the dictionary” = get the updated "MySql.Data.dll"

namespace c_sharp_console_examples
{
    class SelectCommand
    {
        private const int TIME_TO_WAIT = 2000;

        //-----------------------------------------------------------------------//
        // CONSTRUCTOR

        public SelectCommand ()
        {
            Util ();
        }

        //-----------------------------------------------------------------------//
        // HELPER FUNCTIONS

        // SELECT ALL 
        private List<Team> Select ()
        {
            List<Team> teams = new List<Team> ();

            try
            {
                using (MySqlConnection connection = new DatabaseConnection ().GetConnection ())
                {
                    connection.Open ();

                    // SQL Query
                    StringBuilder builder = new StringBuilder ();
                    builder.Append (" SELECT * FROM team ");

                    MySqlCommand command = new MySqlCommand (builder.ToString (), connection);
                    MySqlDataReader reader = command.ExecuteReader ();

                    // Read data
                    while (reader.Read ())
                    {
                        Team team = new Team();
                        team.ID = reader.GetInt16 ("id");
                        team.Name = reader.GetString ("name");
                        team.City = reader.GetString ("city");
                        team.Country = reader.GetString ("country");
                        team.YearFoundation = reader.GetInt16 ("year_foundation");
                        team.Stadium = reader.GetString ("stadium");
                        team.LastChanged = reader.GetDateTime ("last_changed");
                        teams.Add (team);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine (ex.Message);
            }

            return teams;
        }

        // SELECT COUNT 
        private int SelectCount ()
        {
            int count = 0;

            try
            {
                using (MySqlConnection connection = new DatabaseConnection ().GetConnection ())
                {
                    connection.Open ();

                    // SQL Query
                    StringBuilder builder = new StringBuilder ();
                    builder.Append (" SELECT count(*) as total FROM team ");

                    MySqlCommand command = new MySqlCommand (builder.ToString (), connection);
                    MySqlDataReader reader = command.ExecuteReader ();

                    if (reader.Read ())
                    {
                        count = reader.GetInt16 ("total");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine (ex.Message);
            }

            return count;
        }

        // SELECT BY ID 
        private Team SelectById (int id)
        {
            // Check and cancels
            if (id <= 0) { return null; }

            Team team = new Team ();

            try
            {
                using (MySqlConnection connection = new DatabaseConnection ().GetConnection ())
                {
                    connection.Open ();

                    // SQL Query
                    StringBuilder builder = new StringBuilder ();
                    builder.Append (" SELECT * FROM team ");
                    builder.Append (" WHERE id = @id ");

                    MySqlCommand command = new MySqlCommand (builder.ToString (), connection);
                    command.Parameters.AddWithValue ("@id", id);

                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.Read ())
                    {
                        team.ID = reader.GetInt16 ("id");
                        team.Name = reader.GetString ("name");
                        team.City = reader.GetString ("city");
                        team.Country = reader.GetString ("country");
                        team.YearFoundation = reader.GetInt16 ("year_foundation");
                        team.Stadium = reader.GetString ("stadium");
                        team.LastChanged = reader.GetDateTime ("last_changed");
                    }
                    else 
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine (ex.Message);
            }

            return team;
        }

        private void Util ()
        {
            // Select all
            Console.WriteLine ("\n\n##### TEAMS #####");

            List<Team> teams = Select ();

            if (teams.Count != 0)
            {
                foreach (var team in teams)
                {
                    Console.WriteLine ("ID: {0}", team.ID);
                    Console.WriteLine ("Name: {0}", team.Name);
                    Console.WriteLine ("City: {0}", team.City);
                    Console.WriteLine ("Country: {0}", team.Country);
                    Console.WriteLine ("Year Foundation: {0}", team.YearFoundation);
                    Console.WriteLine ("Stadium: {0}", team.Stadium);
                    Console.WriteLine ("Last Changed: {0}\n", team.LastChanged);
                }
            }
            else 
            {
                Console.WriteLine ("No team wasn't found");
            }

            Thread.Sleep (TIME_TO_WAIT);

            // Select count 
            Console.WriteLine ("\n\n##### COUNT #####");
            int count = SelectCount ();
            Console.WriteLine ("Rows count: {0}", count);
            Thread.Sleep (TIME_TO_WAIT);

            // Select by ID
            Console.WriteLine ("\n\n##### TEAM BY ID #####");
            Team thirdTeam = SelectById (3);
            if (thirdTeam != null)
            {
                Console.WriteLine ("ID: {0}", thirdTeam.ID);
                Console.WriteLine ("Name: {0}", thirdTeam.Name);
                Console.WriteLine ("City: {0}", thirdTeam.City);
                Console.WriteLine ("Country: {0}", thirdTeam.Country);
                Console.WriteLine ("Year Foundation: {0}", thirdTeam.YearFoundation);
                Console.WriteLine ("Stadium: {0}", thirdTeam.Stadium);
                Console.WriteLine ("Last Changed: {0}\n", thirdTeam.LastChanged);
            }
            else 
            {
                Console.WriteLine ("Team's data wasn't found");
            }
        }
    }
}