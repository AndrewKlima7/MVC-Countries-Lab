using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_Countries_Lab
{
    public enum Continent
    {
        //Antarctia is is not here simply becuase there are no countries in it, some countries do have territory inside but there is no country 
        //in antarctia alone it is a scientific reserve for the world
        Africa, 
        Asia,
        Europe,
        NorthAmerica,
        SouthAmerica,
        Oceania
    }
    public class Country
    {
        //this is the model
        public string Name { get; set; }
        public Continent Continent { get; set; }
        public List<string> Colors { get; set; }
    }
}
