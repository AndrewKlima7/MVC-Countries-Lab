using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_Countries_Lab
{
    public class CountryController
    {
        //this it controller/ brains
        public List<Country> CountryDb { get; set; } = new List<Country>();

        public CountryController()
        {
            List<string> cZim = new List<string>() { "Green", "Red", "White" };
            CountryDb.Add(new Country() { Name = "Algeria", Continent = Continent.Africa, Colors = cZim });
            List<string> cUgan = new List<string>() { "Yellow", "Red", "Green" };
            CountryDb.Add(new Country() { Name = "Benin", Continent = Continent.Africa, Colors = cUgan });

            List<string> cJapan = new List<string>() { "White", "Red" };
            CountryDb.Add(new Country() { Name = "Japan", Continent = Continent.Asia, Colors = cJapan });
            List<string> cRus = new List<string>() { "Red", "White" };
            CountryDb.Add(new Country() { Name = "Russia", Continent = Continent.Asia, Colors = cRus });

            List<string> cGre = new List<string>() { "Blue", "White" };
            CountryDb.Add(new Country() { Name = "Greece", Continent = Continent.Europe, Colors = cGre });
            List<string> cIta = new List<string>() { "Red", "White", "Green" };
            CountryDb.Add(new Country() { Name = "Italy", Continent = Continent.Europe, Colors = cIta });

            List<string> cMex = new List<string>() { "Red", "White", "Green" };
            CountryDb.Add(new Country() { Name = "Mexico", Continent = Continent.NorthAmerica, Colors = cMex });
            List<string> cUSA = new List<string>() { "Red", "White", "Blue" };
            CountryDb.Add(new Country() { Name = "United States of America", Continent = Continent.NorthAmerica, Colors = cUSA });

            List<string> cChile = new List<string>() { "Red", "White", "Blue" };
            CountryDb.Add(new Country() { Name = "Chile", Continent = Continent.SouthAmerica, Colors = cChile });
            List<string> cPeru = new List<string>() { "Red", "White" };
            CountryDb.Add(new Country() { Name = "Peru", Continent = Continent.SouthAmerica, Colors = cPeru});

            List<string> cAus = new List<string>() { "Red", "White", "Blue" };
            CountryDb.Add(new Country() { Name = "Australia", Continent = Continent.Oceania, Colors = cAus });
            List<string> cZea = new List<string>() { "Red", "White", "Blue" };
            CountryDb.Add(new Country() { Name = "New Zealand", Continent = Continent.Oceania, Colors = cZea });
        }

        public void WelcomeAction()
        {
            Console.ForegroundColor = ConsoleColor.White;
            CountryListView clv = new CountryListView(CountryDb);
            Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list:");
            clv.Display();
            CountryListAction();
        }

        public void CountryListAction()
        {
            //if i ptu string here its fine but once it reacges country action it removes writelines and keep color idk what is going on here
            Console.WriteLine("Please select a country by index: ");
            int input;

            //for if they put anything other than a number
            while (Int32.TryParse(Console.ReadLine(), out input) != true)
            {
                Console.WriteLine("Please input a number shown from the list");

            }

            //for if they put a number that is not in the index like 12 or -1

            try 
            { 
                Country c1 = CountryDb[input];
                Console.Clear();
                CountryAction(c1);
            }
            catch(ArgumentOutOfRangeException)
            {
                Console.WriteLine("Must be an index listed. Please press any key to continue and try again");
                Console.ReadKey();
                Console.Clear();
                WelcomeAction(); 
            }
        }

        public void CountryAction(Country c)
        {
            CountryView cv = new CountryView(c);
            cv.Display();
        }
    }
}
