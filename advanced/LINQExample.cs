using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsoleExamples
{
    class LINQExample
    {
        public LINQExample ()
        {
            /* Data */
            var countries = new[]
            {
                new { ID = 1, CountryName = "Argentina", Language = "Spanish", Area = 2780.400, Population = 43847.430 },
                new { ID = 2, CountryName = "Brasil", Language = "Portuguese", Area = 8515.767, Population = 210147.125 },
                new { ID = 3, CountryName = "China", Language = "Chinese", Area = 9596.961, Population = 1403500.365 },
                new { ID = 4, CountryName = "Chile", Language = "Spanish", Area = 756.096, Population = 17574.003 },
                new { ID = 5, CountryName = "England", Language = "English", Area = 130.279 , Population = 55619.400 },
                new { ID = 6, CountryName = "Japan", Language = "Japanese", Area = 377.973, Population = 126440.000 },
                new { ID = 7, CountryName = "Portugal", Language = "Portuguese", Area = 92.212, Population = 10291.027 },
                new { ID = 8, CountryName = "Russia", Language = "Russian", Area = 17125.191 , Population = 146793.744 },
                new { ID = 9, CountryName = "Spain", Language = "Spanish", Area = 505.990, Population = 46733.038  },
                new { ID = 10, CountryName = "United States", Language = "English", Area = 3796.742 , Population = 327167.434 }
            };


            /* List all */
            Console.WriteLine ("##### ALL COUNTRIES ON THE LIST #####");

            var countryNames = from country in countries
                               select country.CountryName;

            foreach (string name in countryNames)
            {
                Console.WriteLine (name);
            }


            /* Get max area */
            var maxArea = (from country in countries
                           where country.Area == countries.Max(x => x.Area)
                           select country.CountryName + " - " + country.Area).ToArray();

            Console.WriteLine ("\n##### Country with greatest area: {0} km #####", maxArea[0]);


            /* Get max population */
            var maxPopulation = (from country in countries
                                 where country.Population == countries.Max (x => x.Population)
                                 select country.CountryName + " - " + country.Population).ToArray();

            Console.WriteLine ("\n##### Country with greatest area: {0} habitants #####", maxPopulation[0]);


            /* Filter by Language */
            Console.WriteLine ("\n##### PORTUGUESE SPEAKING COUNTRIES #####");

            var portugueseCountries = from country in countries
                                      where country.Language == "Portuguese"
                                      select country.CountryName;

            foreach (string country in portugueseCountries)
            {
                Console.WriteLine (country);
            }


            /* Filter by Language (Length) */
            var numberOfSpanishSpeakers = (from country in countries
                                           where country.Language == "Spanish"
                                           select country.CountryName).ToArray().Length;

            Console.WriteLine ("\n##### Number of spanish speaking countries: {0} #####", numberOfSpanishSpeakers);
        }
    }
}