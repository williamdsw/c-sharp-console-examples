using System;
using System.Text;

namespace c_sharp_console_examples
{
    public class StructExample 
    {
        private struct Game
        {
            public string title;
            public string developer;
            public string genre;
            public float price;
            public int releaseYear;
        }

        //-----------------------------------------------------------------------//
        // CONSTRUCTOR

        public StructExample ()
        {
            // Data
            Game game;
            game.title = "Vaporbreaker";
            game.developer = "Retrogemn";
            game.genre = "Arcade";
            game.price = 1.99f;
            game.releaseYear = 2019;

            // Output
            StringBuilder information = new StringBuilder ();
            information.Append ("===== GAME'S INFORMATION =====");
            information.AppendFormat ("\nTitle: {0}", game.title);
            information.AppendFormat ("\nDeveloper: {0}", game.developer);
            information.AppendFormat ("\nGenre: {0}", game.genre);
            information.AppendFormat ("\nPrice: {0}", game.price);
            information.AppendFormat ("\nRelease Year: {0}", game.releaseYear);

            Console.WriteLine (information);
        }
    }
}