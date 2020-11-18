using System;

namespace Planner
{
    public class Building
    {
        //private fiels (can only be used inside Building class)
        string _designer = "Joseph Tidwell";
        DateTime _dateConstructed { get; set; }
        string _address { get; set; } = "";
        string _owner = "";

        //Public properites (can be used throughout page)
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

        public Building(string address)
        {
            this._address = address;
        }

        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }

        public void Purchase(string name)
        {
            _owner = name;
        }

        public void PurchaseHistory()
        {
            Console.WriteLine("");
            Console.WriteLine(_address);
            Console.WriteLine("-------------");
            Console.WriteLine($"Constructed on: {_dateConstructed}");
            Console.WriteLine($"Owned by: {_owner}");
            Console.WriteLine($"{Volume} cubic meters of space");
            Console.WriteLine("");
        }
    }
}