using System;
namespace C
{
    public class Park
    {
        public Park()
        {
        }
        private string _parkName;
        private string _location;
        private string _type;
        private string _facilities;
        private double _fees;
        private int _numberOfEmployees;
        private int _numberOfVistors;
        private double _annualBudget;
        public string ParkName
        {
            get
            {
                return _parkName;
            }
            set
            {
                _parkName = value;
            }
        }
        public string Location
        {
            get
            {
                return _location;
            }
            set
            {
                _location = value;
            }
        }
        public string Type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }
        public string Facilities
        {
            get
            {
                return _facilities;
            }
            set
            {
                _facilities = value;
            }
        }
        public double Fees
        {
            get
            {
                return _fees;
            }
            set
            {
                _fees = value;
            }
        }
        public int NumberOfEmployees
        {
            get
            {
                return _numberOfEmployees;
            }
            set
            {
                _numberOfEmployees = value;
            }
        }
        public int NumberOfVisitors
        {
            get
            {
                return _numberOfVistors;
            }
            set
            {
                _numberOfVistors = value;
            }
        }
        public double AnnualBudget
        {
            get
            {
                return _annualBudget;
            }
            set
            {
                _annualBudget = value;
            }
        }
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
            return AnnualBudget / NumberOfVisitors;
        }
        public double GetRevenue()
        {
            return NumberOfVisitors * Fees;
        }
        public override string ToString()
        {
            return ($"Name of the Park : {ParkName} \n" + $"Location : {Location} \n" + $"Type : {Type} \n" + $"Facilities Available : {Facilities} \n" +
                $"Fees : {Fees} \n" + $"Number of Employees : {NumberOfEmployees} \n" + $"Number of Visitors : {NumberOfVisitors} \n" + $"Annual Budget : {AnnualBudget} \n");
        }
    }
}
