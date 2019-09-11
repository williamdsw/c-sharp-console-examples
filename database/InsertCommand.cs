using System;
using System.Text;
using MySql.Data.MySqlClient;

// Solution to “The given key was not present in the dictionary” = get the updated "MySql.Data.dll"

namespace c_sharp_console_examples
{
    public class InsertCommand
    {
        //-----------------------------------------------------------------------//
        // CONSTRUCTOR

        public InsertCommand ()
        {
            Util ();
        }

        //-----------------------------------------------------------------------//
        // HELPER FUNCTIONS

        // INSERT 
        private bool Insert (Team model)
        {
            bool hasExecuted = false; 

            try
            {
                using (MySqlConnection connection = new DatabaseConnection ().GetConnection ())
                {
                    connection.Open ();

                    // SQL Query
                    StringBuilder query = new StringBuilder ();
                    query.Append (" INSERT INTO team (name, city, country, year_foundation, stadium, last_changed) ");
                    query.Append (" VALUES (@name, @city, @country, @year_foundation, @stadium, @last_changed) ");

                    // Parameters
                    MySqlCommand command = new MySqlCommand (query.ToString (), connection);
                    command.Parameters.AddWithValue ("@name", model.Name);
                    command.Parameters.AddWithValue ("@city", model.City);
                    command.Parameters.AddWithValue ("@country", model.Country);
                    command.Parameters.AddWithValue ("@year_foundation", model.YearFoundation);
                    command.Parameters.AddWithValue ("@stadium", model.Stadium);
                    command.Parameters.AddWithValue ("@last_changed", model.LastChanged);

                    hasExecuted = (command.ExecuteNonQuery() == 1);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine (ex.Message);
            }

            return hasExecuted;
        }

        private void Util ()
        {
            try
            {
                // New Data
                Team first = new Team ();
                first.Name = "Liverpool";
                first.City = "Liverpool";
                first.Country = "England";
                first.YearFoundation = 1892;
                first.Stadium = "Anfield";
                first.LastChanged = DateTime.Now;

                Team second = new Team ();
                second.Name = "AC Milan";
                second.City = "Milan";
                second.Country = "Italy";
                second.YearFoundation = 1889;
                second.Stadium = "Giuseppe Meazza";
                second.LastChanged = DateTime.Now;

                Team third = new Team();
                third.Name = "Real Madrid";
                third.City = "Madrid";
                third.Country = "Spain";
                third.YearFoundation = 1902;
                third.Stadium = "Santiago Bernabeu";
                third.LastChanged = DateTime.Now;

                Team fourth = new Team();
                fourth.Name = "AFC Ajax";
                fourth.City = "Amsterdam";
                fourth.Country = "Netherlands";
                fourth.YearFoundation = 1892;
                fourth.Stadium = "Amsterdam ArenA";
                fourth.LastChanged = DateTime.Now;

                // Insert array of objects
                var teams = new[] { first, second, third, fourth };
                foreach (var team in teams)
                {
                    bool executed = Insert (team);
                    string status = (executed ? "was" : "wasn't");
                    Console.WriteLine ("{0} {1} added to database", team.Name, status);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine (ex.Message);
            }
        }
    }
}