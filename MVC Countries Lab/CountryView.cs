using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_Countries_Lab
{
    class CountryView
    {
        //this is a view
        public Country DisplayCountry { get; set; }
        public CountryView(Country DisplayCountry)
        {
            this.DisplayCountry = DisplayCountry;
        }

        public void Display()
        {
            //takes the first color and makes it the text color
            string col = DisplayCountry.Colors[0];
            Console.ForegroundColor = Enum.Parse<ConsoleColor>(col);
            
            Console.WriteLine($"Country: {DisplayCountry.Name}");

            //takes 2nd color and makes it the text color
            string col2 = DisplayCountry.Colors[1];
            Console.ForegroundColor = Enum.Parse<ConsoleColor>(col2);

            //This if statement is just for making South America and North America appear correctly as enums don't allow spaces. 
            if(DisplayCountry.Continent == Continent.NorthAmerica)
            {
                Console.WriteLine("Continent: North America");
            }
            else if(DisplayCountry.Continent == Continent.SouthAmerica)
            {
                Console.WriteLine("Continent: South America");
            }
            else
            {
                Console.WriteLine($"Continent: {DisplayCountry.Continent}");
            }

            //tries to take third color for text color but if the index of 2 does not exist then it changes back to the first color
            try
            {
                string col3 = DisplayCountry.Colors[2];
                Console.ForegroundColor = Enum.Parse<ConsoleColor>(col3);
            }
            catch(Exception)
            {
                Console.ForegroundColor = Enum.Parse<ConsoleColor>(col);
            }

            Console.WriteLine("Colors: ");

            int index = 1;
            foreach (string color in DisplayCountry.Colors)
            {
                Console.WriteLine($"{index} : {color}");
                index++;
            }
        }
    }
}
