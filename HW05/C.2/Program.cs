using System;

namespace C
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Motorway subMotorway = new Motorway("I45",4,true);
            Motorway motorway = new Motorway("Jones Road","Road","W","concrete",2,false,"Jersey Village");
            subMotorway.GetMotorName();
            subMotorway.GetMotorNameAndLanes();
            subMotorway.GetMotorNameAndToll();
            Console.WriteLine(motorway);
        }
    }
}
