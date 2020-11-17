using System;

namespace Planner
{
    public class Building
    {
        string _designer = "Joseph";
        DateTime _dateConstructed = new DateTime();
        string _address = "";
        string _owner = "Joe";

        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Volume
        {
            get
            {
                return Width * Depth * (3 * Stories);
            }
        }
    }
}