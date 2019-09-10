using MySql.Data.MySqlClient;
using System;
using System.Text;

// Solution to “The given key was not present in the dictionary” = get the updated "MySql.Data.dll"

namespace c_sharp_console_examples
{
    class UpdateCommand
    {
        //-----------------------------------------------------------------------//
        // CONSTRUCTOR

        public UpdateCommand ()
        {
            Util ();
        }

        //-----------------------------------------------------------------------//
        // HELPER FUNCTIONS

        // UPDATE 
        private bool Update (Team model)
        {
            bool executed = false;

            try
            {
                using (MySqlConnection connection = new DatabaseConnection ().GetConnection ())
                {
                    connection.Open ();

                    // SQL Query
                    StringBuilder builder = new StringBuilder ();
                    builder.Append (" UPDATE team ");
                    builder.Append (" SET name = @name, ");
                    builder.Append (" city = @city, ");
                    builder.Append (" country = @country, ");
                    builder.Append (" year_foundation = @year_foundation, ");
                    builder.Append (" stadium = @stadium, ");
                    builder.Append (" last_changed = @last_changed ");
                    builder.Append (" WHERE id = @id ");

                    // Parameters
                    MySqlCommand command = new MySqlCommand (builder.ToString (), connection);
                    command.Parameters.AddWithValue ("@name", model.Name);
                    command.Parameters.AddWithValue ("@city", model.City);
                    command.Parameters.AddWithValue ("@country", model.Country);
                    command.Parameters.AddWithValue ("@year_foundation", model.YearFoundation);
                    command.Parameters.AddWithValue ("@stadium", model.Stadium);
                    command.Parameters.AddWithValue ("@last_changed", model.LastChanged);
                    command.Parameters.AddWithValue ("@id", model.ID);

                    executed = (command.ExecuteNonQuery() == 1);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return executed;
        }

        private void Util ()
        {
            try
            {
                // Data
                Team team_a = new Team();
                team_a.ID = 1;                        // see 'select' command
                team_a.Name = "Manchester United";
                team_a.City = "Manchester";
                team_a.Country = "England";
                team_a.YearFoundation = 1878;
                team_a.Stadium = "Old Trafford";
                team_a.LastChanged = DateTime.Now;

                // Output
                bool executed = Update (team_a);
                string status = (executed ? "was" : "wasn't");
                Console.WriteLine ("Liverpool {0} changed to Manchester United", status);
            }
            catch (Exception ex)
            {
                Console.WriteLine (ex.Message);
            }
        }
    }
}