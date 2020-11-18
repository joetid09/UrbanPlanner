using System;
using System.Collections.Generic;

namespace Planner
{
    public class Program
    {
        static void Main(string[] args)
        {

            Building FiveOneTwoEigth = new Building("512 8th Avenue")
            {
                Stories = 5,
                Width = 2.0,
                Depth = 3.6,
            };
            FiveOneTwoEigth.Construct();
            FiveOneTwoEigth.Purchase("Carlos Lyons");
            FiveOneTwoEigth.PurchaseHistory();

            Building SixHundo = new Building("600 n 5th")
            {
                Stories = 3,
                Width = 125.0,
                Depth = 42.6,
            };
            SixHundo.Construct();
            SixHundo.Purchase("Waybe Roberts");
            SixHundo.PurchaseHistory();

            Building EastParkAve = new Building("203 Eastland Park Ave")
            {
                Stories = 5,
                Width = 2.0,
                Depth = 3.6,
            };
            EastParkAve.Construct();
            EastParkAve.Purchase("Jeremy Tuchin");
            EastParkAve.PurchaseHistory();

            City margaritaville = new City("margaritaville");
            margaritaville.addBuilding(EastParkAve);
            margaritaville.addBuilding(SixHundo);
            margaritaville.addBuilding(FiveOneTwoEigth);



            foreach (Building building in margaritaville.Buildings)
            {
                Console.WriteLine($"{ building.Stories}");
            }
        }

    }

}
