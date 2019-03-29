using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

/* Solution to “The given key was not present in the dictionary” = 
 * get the updated "MySql.Data.dll"*/

namespace CSharpConsoleExamples
{
    class DeleteCommand
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

        public DeleteCommand() {}

        // DELETE 
        private bool Delete (List<int> IDs)
        {
            bool executed = false;

            try
            {
                String query = " DELETE FROM team " +
                               " WHERE id = @id ";

                using (MySqlConnection connection = new DatabaseConnection().getConnection())
                {
                    connection.Open();

                    foreach (int id in IDs)
                    {
                        if (id > 0)
                        {
                            /* Parameters */
                            MySqlCommand command = new MySqlCommand (query, connection);
                            command.Parameters.AddWithValue ("@id", id);

                            executed = (command.ExecuteNonQuery () == 1);
                        }
                    }
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
                List<int> IDs = new List<int>();
                IDs.Add(1);
                IDs.Add(3);

                bool executed = Delete (IDs);

                Console.WriteLine ("{0} teams {1} deleted successfully.", IDs.Count, (executed ? "was" : "wasn't"));
            }
            catch (Exception ex)
            {
                Console.WriteLine (ex.Message);
            }
        }
    }
}
