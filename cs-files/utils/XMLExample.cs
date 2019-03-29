using System;
using System.Xml;

namespace CSharpConsoleExamples
{
    class XMLExample
    {
        public XMLExample ()
        {
            createXML("movies.xml");
        }

        private void createXML (string path)
        {
            try
            {
                using (XmlWriter writer = XmlWriter.Create (path))
                {
                    /* <?xml version="1.0" encoding="utf-8"?> */
                    writer.WriteStartDocument ();
                    writer.WriteComment ("example of comment");

                    /* Root tag */
                    writer.WriteStartElement ("movies");

                    /* Sub tags / attributes # 1 */
                    writer.WriteStartElement ("movie");
                    writer.WriteAttributeString("id", "1");
                    writer.WriteElementString ("title", "Die Hard");
                    writer.WriteElementString ("genre", "Action Thriller");
                    writer.WriteElementString ("year", "1988");
                    writer.WriteEndElement ();

                    /* Sub tags / attributes # 2 */
                    writer.WriteStartElement("movie");
                    writer.WriteAttributeString("id", "2");
                    writer.WriteElementString("title", "The Exorcist");
                    writer.WriteElementString("genre", "Supernatural Horror");
                    writer.WriteElementString("year", "1971");
                    writer.WriteEndElement();

                    /* Sub tags / attributes # 3 */
                    writer.WriteStartElement("movie");
                    writer.WriteAttributeString("id", "3");
                    writer.WriteElementString("title", "Batman Begins");
                    writer.WriteElementString("genre", "Superhero");
                    writer.WriteElementString("year", "2005");
                    writer.WriteEndElement();

                    /* Closes root tag */
                    writer.WriteFullEndElement();
                }

                Console.WriteLine("XML file created...");
            }
            catch (Exception ex)
            {
                Console.WriteLine (ex.Message);
            }
        }
    }
}
