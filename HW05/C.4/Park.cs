using System;
namespace C
{
    public class Park
    {
        public Park()
        {
        }
        public string ParkName { get; set; }
        public string Location { get; set; }
        public string Type { get; set; }
        public string Facilities { get; set; }
        public double Fees { get; set; }
        public int NumberOfEmployees { get; set; }
        public int NumberOfVistors { get; set; }
        public double AnnualBudget { get; set; }

        public string GetParkNameLocationType()
        {
            return $"Name of the Park : {ParkName} \n" + $"Location : {Location} \n" + $"Type : {Type} \n";
         }
        public string GetParkNameLocationFacilities()
        {
            return $"Name of the Park : {ParkName} \n" + $"Location : {Location} \n" + $"Facilities Available : {Facilities} \n";
        }
        public double GetCostPerVisitor()
        {
            return AnnualBudget / NumberOfVistors;
        }
        public double GetRevenue()
        {
            return NumberOfVistors * Fees;
        }
        public override string ToString()
        {
            return ($"Name of the Park : {ParkName} \n" + $"Location : {Location} \n" + $"Type : {Type} \n" + $"Facilities Available : {Facilities} \n" +
                $"Fees : {Fees} \n" + $"Number of Employees : {NumberOfEmployees} \n" + $"Number of Visitors : {NumberOfVistors} \n" + $"Annual Budget : {AnnualBudget} \n");
        }
    }
}
