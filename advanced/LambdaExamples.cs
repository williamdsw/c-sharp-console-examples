using System;
using System.Collections.Generic;
using System.Linq;

namespace c_sharp_console_examples
{
    class LambdaExample
    {
        private struct Film
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Genre { get; set; }
            public int RunningTime { get; set; }
            public string Country { get; set; }
            public string Language { get; set; }
        }

        //-----------------------------------------------------------------------//
        // CONSTRUCTOR

        public LambdaExample ()
        {
            var films = CreateFilmList ();
            ShowFilmsData (films);

            // Find by ID
            Film filmByID = films.Find ((Film film) => film.ID == 5);
            Console.WriteLine ("Film by ID : 5 = {0} ", filmByID.Name);

            // Find maximum value
            int maxRunningTime = films.Max (film => { return film.RunningTime; });
            Console.WriteLine ("Maximum running time: {0} minutes", maxRunningTime);

            // Find minimum value
            int minRunningTime = films.Min (film => { return film.RunningTime; });
            Console.WriteLine ("Minimum running time: {0} minutes", minRunningTime);

            // Find average value
            double averageRunningTime = films.Average (film => film.RunningTime);
            Console.WriteLine ("Average running time: {0} minutes", averageRunningTime);

            // Count based on condition
            int numberOfAmericanMovies = films.Count (film => film.Country == "United States");
            Console.WriteLine ("Number of american movies: {0}", numberOfAmericanMovies);

            // Order by name
            Console.WriteLine ("\nMovies ordered by name:");
            films = films.OrderBy (film => film.Name).ToList ();
            films.ForEach (film => Console.WriteLine (film.Name));
        }

        //-----------------------------------------------------------------------//
        // HELPER FUNCTIONS

        // Creates a new list of films
        private List<Film> CreateFilmList ()
        {
            List<Film> films = new List<Film>()
            {
                new Film () { ID = 1, Name = "The Godfather", Genre = "Crime", RunningTime = 177, Country = "United States", Language = "English" },
                new Film () { ID = 2, Name = "The Exorcist", Genre = "Horror", RunningTime = 132, Country = "United States", Language = "English" },
                new Film () { ID = 3, Name = "Tropa de Elite", Genre = "Crime", RunningTime = 115, Country = "Brazil", Language = "Portuguese" },
                new Film () { ID = 4, Name = "Akira", Genre = "Post-Apocalyptic Cyberpunk", RunningTime = 124, Country = "Japan", Language = "Japanese" },
                new Film () { ID = 5, Name = "Viridiana", Genre = "Drama", RunningTime = 90, Country = "Spain", Language = "Spanish" }
            };

            return films;
        }

        // Iterates the list of films and shows data
        private void ShowFilmsData (List<Film> films)
        {
            Console.WriteLine ("List of Films:");
            films.ForEach ((Film film) =>
            {
                string description = "\nID: {0} \nName: {1} \nGenre: {2} \nRunning Time: {3} minutes \nCountry: {4} \nLanguage: {5}";
                Console.WriteLine (description, film.ID, film.Name, film.Genre, film.RunningTime, film.Country, film.Language);
            });
        }
    }
}