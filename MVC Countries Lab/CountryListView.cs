using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_Countries_Lab
{
    class CountryListView
    {
        //this is a view
        public List<Country> Countries { get; set; }
        public CountryListView(List<Country> Countries)
        {
            this.Countries = Countries;
        }
        public void Display()
        {
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < Countries.Count; i++)
            {
                Country c = Countries[i];
                Console.WriteLine($"{i} : {c.Name}");
            }
        }
    }
}
