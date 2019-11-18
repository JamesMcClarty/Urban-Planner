using System;
using System.Collections.Generic;

namespace Planner
{
    public class City
    {
        public City(string cityName, int year)
        {
            _name = cityName;
            _year = year;
        }

        //Private
        private string _name;
        private string _mayor;
        private int _year;
        private List<Building> Buildings = new List<Building>();

        public void AddBuilding(Building _building)
        {
            Buildings.Add(_building);
        }
        public void Elect(string nextMayor)
        {
            _mayor = nextMayor;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"{_name}");
            Console.WriteLine($"The mayor is {_mayor}.");
            Console.WriteLine($"The established year is {_year}.");
            Console.WriteLine($"The buildings in the city are:");
            foreach (Building building in Buildings)
            {
                building.DisplayInfo();
            }

        }

    }
}