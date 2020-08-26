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
        public Building()
        {
            Building aBuilding = new Building();
            aBuilding._address = "1808 west west SW Circle";
        }

    }
}