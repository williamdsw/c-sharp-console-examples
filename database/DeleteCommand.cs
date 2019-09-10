using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

// Solution to “The given key was not present in the dictionary” = get the updated "MySql.Data.dll"

namespace c_sharp_console_examples
{
    class DeleteCommand
    {
        //-----------------------------------------------------------------------//
        // CONSTRUCTOR

        public DeleteCommand ()
        {
            Util ();
        }

        //-----------------------------------------------------------------------//
        // HELPER FUNCTIONS

        // DELETE 
        private bool Delete (int id)
        {
            bool executed = false;

            try
            {
                // SQL Query
                StringBuilder builder = new StringBuilder ();
                builder.Append (" DELETE FROM team WHERE id = @id ");

                using (MySqlConnection connection = new DatabaseConnection ().GetConnection ())
                {
                    connection.Open ();
                    MySqlCommand command = new MySqlCommand (builder.ToString (), connection);
                    command.Parameters.AddWithValue ("@id", id);
                    executed = (command.ExecuteNonQuery () == 1);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine (ex.Message);
            }

            return executed;
        }

        private void Util ()
        {
            try
            {
                // Data
                List<int> IDs = new List<int>();
                IDs.Add (1);
                IDs.Add (2);
                IDs.Add (3);
                IDs.Add (4);

                // Output
                int index = 0;
                foreach (int id in IDs)
                {
                    bool executed = Delete (id);
                    Console.WriteLine ("{0}º team {1} deleted successfully.", (index + 1), (executed ? "was" : "wasn't"));
                    index++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine (ex.Message);
            }
        }
    }
}
