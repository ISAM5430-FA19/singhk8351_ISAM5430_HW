using System;

namespace C
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Park park = new Park();
            park.ParkName = "Rocky Mountain National Park";
            park.Location = "Colorado";
            park.Type = "national";
            park.Facilities = "buses/food/shopping";
            park.Fees = 10.50;
            park.NumberOfEmployees = 700;
            park.NumberOfVistors = 2000;
            park.AnnualBudget = 30000;
            Console.WriteLine(park.GetParkNameLocationType());
            Console.WriteLine(park.GetParkNameLocationFacilities());
            Console.WriteLine("Cost per visitor is {0}",park.GetCostPerVisitor());
            Console.WriteLine("Revenue is {0}",park.GetRevenue());
            Console.WriteLine(park);
        }
    }
}
