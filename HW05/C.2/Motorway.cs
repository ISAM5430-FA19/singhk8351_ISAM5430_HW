using System;
namespace C
{
    public class Motorway
    {
        private string _nameOfMotor;
        private string _type;
        private string _direction;
        private string _surface;
        private int _lanes;
        private bool _toll;
        private string _maintenanceParty;
        public Motorway(string motorName, int lanes, bool toll)
        {
            NameOfMotor = motorName;
            Lanes = lanes;
            Toll = toll;
        }

        public Motorway(string motorName,string type, string direction, string surface, int lanes, bool toll, string maintenanceParty)
        {
            NameOfMotor = motorName;
            Type = type;
            Direction = direction;
            Surface = surface;
            Lanes = lanes;
            Toll = toll;
            MaintenanceParty = maintenanceParty;
        }

        public string NameOfMotor
        {
            get
            {
                return _nameOfMotor;
            }
            set
            {
                _nameOfMotor = value;
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
        public string Direction
        {
            get
            {
                return _direction;
            }
            set
            {
                _direction = value;
            }
        }
        public string Surface
        {
            get
            {
                return _surface;
            }
            set
            {
                _surface = value;
            }
        }
        public int Lanes
        {
            get
            {
                return _lanes;
            }
            set
            {
                _lanes = value;
            }
        }
        public bool Toll
        {
            get
            {
                return _toll;
            }
            set
            {
                _toll = value;
            }
        }
        public string MaintenanceParty
        {
            get
            {
                return _maintenanceParty;
            }
            set
            {
                _maintenanceParty = value;
            }
        }
        public void GetMotorName()=>Console.WriteLine($"Full name of the motor : {NameOfMotor}");
        public void GetMotorNameAndToll()=> Console.WriteLine($"Full name of the motor : {NameOfMotor} \n" + $"Toll : {Toll}");
        public void GetMotorNameAndLanes()=> Console.WriteLine($"Full name of the motor : {NameOfMotor} \n" + $"Lanes : {Lanes}");
        public override string ToString()
        {
            return ($"Full name of the motor : {NameOfMotor} \n" + $"Type : {Type} \n" + $"Direction : {Direction} \n" + $"Surface : {Surface} \n" + $"Lanes : {Lanes} \n" +
                $"Toll : {Toll} \n" + $"MaintenanceParty : {MaintenanceParty} \n");
        }
    }
}
