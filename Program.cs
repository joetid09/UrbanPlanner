using System;

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
        }



    }

}
