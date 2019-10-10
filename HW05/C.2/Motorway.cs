using System;
namespace C
{
    public class Motorway
    {
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

        public string NameOfMotor { get; set; }
        public string Type { get; set; }
        public string Direction { get; set; }
        public string Surface { get; set; }
        public int Lanes { get; set; }
        public bool Toll { get; set; }
        public string MaintenanceParty { get; set; }
        public void GetMotorName()=>Console.WriteLine($"Full name of the motor : {NameOfMotor}");
        public void GetMotorNameAndToll()=> Console.WriteLine($"Full name of the motor : {NameOfMotor} \n" + $" Toll : {Toll}");
        public void GetMotorNameAndLanes()=> Console.WriteLine($"Full name of the motor : {NameOfMotor} \n" + $" Lanes : {Lanes}");
        public override string ToString()
        {
            return ($"Full name of the motor : {NameOfMotor} \n" + $"Type : {Type} \n" + $"Direction : {Direction} \n" + $"Surface : {Surface} \n" + $"Lanes : {Lanes} \n" +
                $"Toll : {Toll} \n" + $"MaintenanceParty : {MaintenanceParty} \n");
        }
    }
}
