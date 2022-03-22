using Motored_vehicles_class.Classes;
using System;

namespace MotoredVehicles_class
{
    class Program
    {
        static void Main(string[] args)
        {
            MotoredVehicle mv1 = new MotoredVehicle();
            //mv1.Model = "GT-R";
            //mv1.Make = "NISSAN";
            //mv1.ProductionYear = "2021";
            //mv1.MotorSize = "3600";
            //mv1.FuelTankSize = "88";
            //mv1.FuelAmount = 1000;
            //mv1.FuelUsedPerKm = 13;
            //mv1.Color = "black";
            //mv1.Transmission = "6";
            //mv1.HorsePower = "565hp";
            //mv1.PassangerCount = "2";
            //mv1.GetDetailedInfo();
            //mv1.GetInfo();
            


                Car c1 = new Car();
                c1.Model = "2107";
                c1.Make = "VAZ";
                c1.ProductionYear = "2000";
                c1.MotorSize = "1100";
                c1.FuelTankSize = "40";
                c1.FuelAmount = 35;
                c1.FuelUsedPerKm = 0.08;
                c1.Color = "black";
                c1.Transmission = "5";
                c1.HorsePower = "200hp";
                c1.PassangerCount = "4";
                c1.Go();
                //c1.GetDetailedInfo();
            
        }
    }
}
