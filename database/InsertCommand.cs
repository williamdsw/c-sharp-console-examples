using System;
using MySql.Data.MySqlClient;

/* Solution to “The given key was not present in the dictionary” = 
 * get the updated "MySql.Data.dll"*/

namespace CSharpConsoleExamples
{
    class InsertCommand
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

        public InsertCommand() {}

        // INSERT 
        private bool Insert (Team model)
        {
            bool executed = false; 

            try
            {
                using (MySqlConnection connection = new DatabaseConnection().getConnection())
                {
                    connection.Open ();

                    /* SQL query */
                    String query = " INSERT INTO team (name, city, country, year_foundation, stadium, last_changed) " +
                                   " VALUES (@name, @city, @country, @year_foundation, @stadium, @last_changed) ";

                    /* Command and parameters */
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@name", model.Name);
                    command.Parameters.AddWithValue("@city", model.City);
                    command.Parameters.AddWithValue("@country", model.Country);
                    command.Parameters.AddWithValue("@year_foundation", model.YearFoundation);
                    command.Parameters.AddWithValue("@stadium", model.Stadium);
                    command.Parameters.AddWithValue("@last_changed", model.LastChanged);

                    executed = (command.ExecuteNonQuery() == 1);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine (ex.Message);
            }

            return executed;
        }

        public void Util ()
        {
            try
            {
                /* Data */
                Team team_a = new Team();
                team_a.Name = "Liverpool";
                team_a.City = "Liverpool";
                team_a.Country = "England";
                team_a.YearFoundation = 1892;
                team_a.Stadium = "Anfield";
                team_a.LastChanged = DateTime.Now;

                Team team_b = new Team();
                team_b.Name = "AC Milan";
                team_b.City = "Milan";
                team_b.Country = "Italy";
                team_b.YearFoundation = 1889;
                team_b.Stadium = "Giuseppe Meazza";
                team_b.LastChanged = DateTime.Now;

                Team team_c = new Team();
                team_c.Name = "Real Madrid";
                team_c.City = "Madrid";
                team_c.Country = "Spain";
                team_c.YearFoundation = 1902;
                team_c.Stadium = "Santiago Bernabeu";
                team_c.LastChanged = DateTime.Now;

                Team team_d = new Team();
                team_d.Name = "AFC Ajax";
                team_d.City = "Amsterdam";
                team_d.Country = "Netherlands";
                team_d.YearFoundation = 1892;
                team_d.Stadium = "Amsterdam ArenA";
                team_d.LastChanged = DateTime.Now;

                var teams = new[] { team_a, team_b, team_c, team_d };

                /* inserts */
                foreach (var team in teams)
                {
                    bool executed = Insert(team);

                    Console.WriteLine("{0} {1} added to database", team.Name, (executed ? "was" : "wasn't"));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine (ex.Message);
            }
        }
    }
}
