using System;
using System.Collections.Generic;

namespace Planner
{
    public class City
    {
        public string name { get; set; }

        public string mayor { get; set; }

        public int established { get; set; }

        // A dictionary is a collection of "keys" and "values" (a.k.a KeyValuePairs)
        //dictionary of buildings that are (with)in CityLimits
        private Dictionary<string, Building> CityLimits { get; set; }

        public City()
        {
            CityLimits = new Dictionary<string, Building>();
        }

        public void AddBuilding(Building aBuilding)
        {
            CityLimits.Add(aBuilding._address, aBuilding);
        }

        public void ListBuildings()
        {
            // Iterate over the keys and values that are stored in the Inventory dictionary
            foreach (KeyValuePair<string, Building> item in CityLimits)
            {
                // Each "KeyValuePair" has a "Key" property and a "Value" property
                // Here we use the Value property to access a Bike object
                Console.WriteLine($"{item.Value._address}: {item.Value.Volume} volumes BIIIIGGGGLLYY!!!");
            }
        }
    }
}