using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building Kmart = new Building("1808 waka wAka STREET");
            Kmart.Width = 500;
            Kmart.Depth = 1000;
            Kmart.Stories = 12;
            Kmart.Purchase("Tim The Toolman");

            Building Walmart = new Building("1303 Real Road");
            Walmart.Width = 1400;
            Walmart.Depth = 20000;
            Walmart.Stories = 10;
            Walmart.Purchase("Bob Veilla");

            Kmart.ShowBuilding();
            Walmart.ShowBuilding();
        }
    }
}