using System;
using System.Collections.Generic;
using System.Threading;
using MySql.Data.MySqlClient;

/* Solution to “The given key was not present in the dictionary” = 
 * get the updated "MySql.Data.dll"*/

namespace CSharpConsoleExamples
{
    class SelectCommand
    {
        private class Team
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string City { get; set; }
            public string Country { get; set; }
            public int YearFoundation { get; set; }
            public string Stadium { get; set; }
            public DateTime LastChanged { get; set; }
        }

        public SelectCommand() {}

        // SELECT ALL 
        private List<Team> Select ()
        {
            List<Team> teams = new List<Team> ();

            try
            {
                using (MySqlConnection connection = new DatabaseConnection().getConnection())
                {
                    connection.Open();

                    /* SQL query */
                    String query = " SELECT * FROM team ";

                    /* Command / Reader */
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    /* Read data */
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
                using (MySqlConnection connection = new DatabaseConnection().getConnection())
                {
                    connection.Open();

                    /* SQL query */
                    String query = " SELECT count(*) as count FROM team ";

                    /* Command / Reader */
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    /* Read data */
                    if (reader.Read())
                    {
                        count = reader.GetInt16 ("count");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return count;
        }

        // SELECT BY ID 
        private Team SelectById (int id)
        {
            Team team = new Team ();

            try
            {
                using (MySqlConnection connection = new DatabaseConnection ().getConnection ())
                {
                    connection.Open();

                    /* SQL query */
                    String query = " SELECT * FROM team " +
                                   " WHERE id = @id ";

                    /* Command, parameters */
                    MySqlCommand command = new MySqlCommand (query, connection);
                    command.Parameters.AddWithValue ("@id", id);

                    MySqlDataReader reader = command.ExecuteReader();

                    /* Read data */
                    if (reader.Read())
                    {
                        team.ID = reader.GetInt16 ("id");
                        team.Name = reader.GetString ("name");
                        team.City = reader.GetString("city");
                        team.Country = reader.GetString("country");
                        team.YearFoundation = reader.GetInt16 ("year_foundation");
                        team.Stadium = reader.GetString ("stadium");
                        team.LastChanged = reader.GetDateTime ("last_changed");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return team;
        }


        public void Util ()
        {
            /* ALL TEAMS */
            Console.WriteLine ("\n\n##### TEAMS #####");

            List<Team> teams = Select ();

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

            Thread.Sleep (2000);

            /* COUNT */
            Console.WriteLine("\n\n##### COUNT #####");

            int count = SelectCount ();

            Console.WriteLine("Rows count: {0}", count);

            Thread.Sleep(2000);

            /* TEAM BY ID */
            Console.WriteLine("\n\n##### TEAM BY ID #####");

            Team thirdTeam = SelectById (3);

            Console.WriteLine("ID: {0}", thirdTeam.ID);
            Console.WriteLine("Name: {0}", thirdTeam.Name);
            Console.WriteLine("City: {0}", thirdTeam.City);
            Console.WriteLine("Country: {0}", thirdTeam.Country);
            Console.WriteLine("Year Foundation: {0}", thirdTeam.YearFoundation);
            Console.WriteLine("Stadium: {0}", thirdTeam.Stadium);
            Console.WriteLine("Last Changed: {0}\n", thirdTeam.LastChanged);
        }
    }
}
