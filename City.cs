using System;
using System.Collections.Generic;


namespace Planner
{

    public class City
    {
        public City(string name)
        {
            _name = name;
        }
        private string _name { get; set; }
        private int _established = 2016;
        private string _mayor = "Joseph Tidwell";

        public List<Building> Buildings { get; set; } = new List<Building>();

        public void addBuilding(Building building)
        {
            Buildings.Add(building);
        }

    }
}