using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CSharpConsoleExamples
{
    class DatabaseConnection
    {
        /* Parameters */
        private String server = "localhost";
        private String database = "csharp_console_1";
        private String user = "root";
        private String password = "root";
        private int port = 3306;

        private MySqlConnection connection;

        public DatabaseConnection ()
        {
            connection = new MySqlConnection (getConnectionString());
        }

        private String getConnectionString ()
        {
            return " SERVER = " + server + "; DATABASE = " + database +
                   "; PORT = " + port + "; User ID = " + user + "; PASSWORD = " + password +
                   "; ALLOW USER VARIABLES=TRUE; CHARSET=utf8; ";
        }

        public MySqlConnection getConnection ()
        {
            return connection;
        }

        public void printConnectionProperties ()
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
