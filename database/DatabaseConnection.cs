using MySql.Data.MySqlClient;
using System;

namespace c_sharp_console_examples
{
    class DatabaseConnection
    {
        //-----------------------------------------------------------------------//
        // FIELDS

        // Config
        private const string SERVER = "localhost";
        private const string DATABASE = "csharp_console_1";
        private const string USER_ID = "root";
        private const string PASSWORD = "root";
        private const int PORT = 3306;

        // Cached
        private MySqlConnection connection;

        //-----------------------------------------------------------------------//
        // CONSTRUCTOR

        public DatabaseConnection ()
        {
            connection = new MySqlConnection (GetConnectionString());
        }

        //-----------------------------------------------------------------------//
        // HELPER FUNCTIONS

        private string GetConnectionString ()
        {
            return $" SERVER = {SERVER}; DATABASE = {DATABASE}; PORT = {PORT}; " + 
                   $" USER ID = {USER_ID}; PASSWORD = {PASSWORD}; " + 
                   $" ALLOW USER VARIABLES = TRUE; CHARSET = utf8; ";
        }

        public MySqlConnection GetConnection ()
        {
            return connection;
        }

        public void ShowConnectionProperties ()
        {
            try
            {
                Console.WriteLine ("##### CONNECTION PROPERTIES #####\n");
                Console.WriteLine ("Connection String: '{0}'", connection.ConnectionString);
                Console.WriteLine ("Connection Timeout: '{0}'", connection.ConnectionTimeout);
                Console.WriteLine ("Container: '{0}'", connection.Container);
                Console.WriteLine ("Database: '{0}'", connection.Database);
                Console.WriteLine ("Datasource: '{0}'", connection.DataSource);
                Console.WriteLine ("Ping: '{0}'", connection.Ping());
                Console.WriteLine ("Site: '{0}'", connection.Site);
                Console.WriteLine ("Use Compression: '{0}'", connection.UseCompression);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}