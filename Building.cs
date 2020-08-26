using System;

namespace Planner
{
    public class Building
    {
        // Private Fields
        private string _owner { get; set; }
        private string _designer = "Brett Stoudt";
        private DateTime _dateConstructed { get; set; }
        private string _address { get; set; }

        //Public Properties
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        //each story is 3 meters high
        public double Volume
        {
            get
            {
                return Width * Depth * (3 * Stories);
            }
        }
        //Date Constructor to set date upon creating new Building instance
        //invoked in Building method
        public void Construct() => _dateConstructed = DateTime.Now;

        //Owner Constructor to set date upon creating new Building instance
        //invoked in Building method with string
        public void Purchase(string nameOfPurchaser) => _owner = nameOfPurchaser;

        //public variable to allow us to set the private variable via paramaters passed through on new Building
        public string address { get; set; }

        public Building(string address)
        {
            _address = address;
            Construct();
        }

        public void ShowBuilding()
        {
            Console.WriteLine(_address);
            Console.WriteLine("------------");
            Console.WriteLine($"Designed by: {_designer}");

            Console.WriteLine($"Constructed on: {_dateConstructed.ToString("F")}");
            Console.WriteLine($"Owned by: {_owner}");
            Console.WriteLine($"{Volume} cubic meters of space");
            Console.WriteLine();
        }
    }
}