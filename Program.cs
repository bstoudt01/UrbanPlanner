using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            City SpringHill = new City();
            SpringHill.name = "SpringHill";
            SpringHill.mayor = "Jimmy Dean";
            SpringHill.established = 1992;

            Building aBuilding = new Building("1808 waka wAka STREET");
            aBuilding.Width = 500;
            aBuilding.Depth = 1000;
            aBuilding.Stories = 12;
            aBuilding.Purchase("Tim The Toolman");

            Building Walmart = new Building("1303 Real Road");
            Walmart.Width = 1400;
            Walmart.Depth = 20000;
            Walmart.Stories = 10;
            Walmart.Purchase("Bob Veilla");

            // Kmart.ShowBuilding();
            // Walmart.ShowBuilding();

            SpringHill.AddBuilding(aBuilding);
            Console.WriteLine($"Added ABuiding {aBuilding.address}");
            SpringHill.AddBuilding(Walmart);
            Console.WriteLine($"Added Walart {Walmart.address}");
            SpringHill.ListBuildings();
        }
    }
}