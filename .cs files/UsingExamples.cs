using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsoleExamples
{
    class UsingExamples
    {
        public UsingExamples ()
        {
            createFile ();
            readFile ();
        }

        private void createFile ()
        {
            /* Content */
            StringBuilder builder = new StringBuilder();
            builder.AppendLine ("London Bridge is falling down,");
            builder.AppendLine ("Falling down, falling down.");
            builder.AppendLine ("London Bridge is falling down,");
            builder.AppendLine ("My fair lady");

            using (StreamWriter writer = new StreamWriter ("myFile.txt"))
            {
                writer.WriteLine (builder);
            }

            Console.WriteLine ("File created");
        }

        private void readFile ()
        {
            String content = "";

            using (TextReader reader = new StreamReader("myFile.txt"))
            {
                content = reader.ReadToEnd ();
            }

            Console.WriteLine (content);

            File.Delete ("myFile.txt");
        }
    }
}
