using System;
using System.Collections.Generic;
using System.Text;

namespace Motored_vehicles_class.Classes
{
    class MotoredVehicle
    {
        public string Model;
        public string Make;
        public string ProductionYear;
        public string MotorSize;
        public string FuelTankSize;
        public double FuelAmount;
        public double FuelUsedPerKm;
        public string Color;
        public string Transmission;
        public string HorsePower;
        public string PassangerCount;

        public MotoredVehicle()
        {

        }
        public MotoredVehicle(string model,string make,string year)
        {
            Model = model;
            Make = make;
            ProductionYear = year;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Model={Model}\nMake={Make}\nProductionYear={ProductionYear}");
        }
        public virtual void GetDetailedInfo() 
        {
            GetInfo();
            Console.WriteLine($"MotorSize={MotorSize}\nFuelTankSize={FuelTankSize}\n" +
                $"FuelAmount={FuelAmount}\nFuelUsedPerKm={FuelUsedPerKm}\nColor={Color}\nPassangerCount={PassangerCount}\nHorsePower={HorsePower}\n" +
                $"Transmission={Transmission}");
        }
    }
}
