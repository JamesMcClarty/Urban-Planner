using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            //BUILDINGS 
            Building building1 = new Building("408 Andover Dr.");
            building1.Stories = 1;
            building1.Width= 5243.3;
            building1.Depth= 243.3;
            building1.Construct();
            building1.Purchase("Libbie Bullock");

            Building building2 = new Building("4809 Ark Ln.");
            building2.Stories = 2;
            building2.Width= 123.3;
            building2.Depth= 678.9;
            building2.Construct();
            building2.Purchase("Jim McClarty");

            //CITY

            City newCity = new City("Sim City", 1989);
            newCity.Elect("Will Wright");
            newCity.AddBuilding(building1);
            newCity.AddBuilding(building2);
            newCity.DisplayInfo();
        }


    }
}
