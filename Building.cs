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
        // public string Volume
        // {
        //     get
        //     {
        //         return $"{Width} * {Depth} * (3 * {Int32.Parse(Stories)})";
        //     }
        // }
        //Address Constructor
        // public void SetAddress(string _address)
        // {
        //     address = _address;
        // }
        public string address { get; set; }

        public Building(string address)
        {
            _address = address;
            Console.WriteLine(_designer);
            Console.WriteLine(_address);
        }
    }
}