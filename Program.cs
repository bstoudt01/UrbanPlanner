using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Building aBuilding = new Building("1808 waka wAka STREET");
            aBuilding.Stories = 12;

            Console.WriteLine(aBuilding.Stories);
        }
    }
}