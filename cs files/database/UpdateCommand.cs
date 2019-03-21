using System;
using MySql.Data.MySqlClient;

/* Solution to “The given key was not present in the dictionary” = 
 * get the updated "MySql.Data.dll" */

namespace CSharpConsoleExamples
{
    class UpdateCommand
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

        public UpdateCommand () {}

        // UPDATE 
        private bool Update (Team model)
        {
            bool executed = false;

            try
            {
                using (MySqlConnection connection = new DatabaseConnection().getConnection())
                {
                    connection.Open();

                    /* SQL query */
                    String query = " UPDATE team " +
                                   " SET name = @name, " +
                                   "     city = @city, " +
                                   "     country = @country, " +
                                   "     year_foundation = @year_foundation, " +
                                   "     stadium = @stadium, " +
                                   "     last_changed = @last_changed " +
                                   " WHERE id = @id ";

                    /* Command and parameters */
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue ("@name", model.Name);
                    command.Parameters.AddWithValue ("@city", model.City);
                    command.Parameters.AddWithValue ("@country", model.Country);
                    command.Parameters.AddWithValue ("@year_foundation", model.YearFoundation);
                    command.Parameters.AddWithValue ("@stadium", model.Stadium);
                    command.Parameters.AddWithValue ("@last_changed", model.LastChanged);
                    command.Parameters.AddWithValue ("@ID", model.ID);

                    executed = (command.ExecuteNonQuery() == 1);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return executed;
        }

        public void Util ()
        {
            try
            {
                /* Previous = "Liverpool", now "Manchester United" */
                Team team_a = new Team();
                team_a.ID = 1;                        // see 'select' command
                team_a.Name = "Manchester United";
                team_a.City = "Manchester";
                team_a.Country = "England";
                team_a.YearFoundation = 1878;
                team_a.Stadium = "Old Trafford";
                team_a.LastChanged = DateTime.Now;

                bool executed = Update(team_a);

                Console.WriteLine("Liverpool {0} changed to Manchester United", (executed ? "was" : "wasn't"));
            }
            catch (Exception ex)
            {
                Console.WriteLine (ex.Message);
            }
        }
    }
}
