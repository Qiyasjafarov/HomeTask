using System;
using System.Collections.Generic;
using System.Text;

namespace Motored_vehicles_class.Classes
{
    class Car : MotoredVehicle
    {
        public int IsOn=0;
        

        public Car(string model, string make, string year) : base(model,make,year)
        {
            Model = model;
            Make = make;
            ProductionYear = year;
        }

        public Car()
        {
        }

        public void TurnOn(int on)
        {



            if (on==1)
            {
                IsOn = 1;
                Console.WriteLine("masin islekdir");
            } 
            

        }
        public void TurnOff(int off)
        {
            if (off == 0)
            {
                IsOn = 0;
                Console.WriteLine("masin islek deyil");
            }


        }
        public void Go()
        {
            Console.WriteLine("masin islek deyil eger ise salmaq isteyirsinizse 1 yazin, eks halda 0 yazin");
            int IsOn = Convert.ToInt32(Console.ReadLine());

            while (IsOn!=1 && IsOn!=0)
            {
                Console.WriteLine("ancaq 1 ve ya 0 daxil ede bilersiniz!!!");
                IsOn = Convert.ToInt32(Console.ReadLine());
            }
            if (IsOn == 0)
            {
                TurnOff(0);
                
            }
            else if(IsOn==1)
            {
                TurnOn(1);
                Console.WriteLine("getmek istediyiniz mesafeni qeyd edin");
                double distance = Convert.ToDouble(Console.ReadLine());
                while (distance < 0) 
                {
                    Console.WriteLine("Mesafe menfi ola bilmez!!!!");
                    distance = Convert.ToDouble(Console.ReadLine());
                }
                if (FuelAmount >= distance*FuelUsedPerKm)
                {
                    Console.WriteLine($"{distance} km mesafe qet edildi");
                    FuelAmount -= distance * FuelUsedPerKm;
                }
                else Console.WriteLine($"Kifayet qeder yanacaq yoxdur bu yanacaqla max {FuelAmount/FuelUsedPerKm}km yol gede bilersiz");

            }
            else Console.WriteLine("sehv yazdiz masin xarab oldu :)");

        }
        public override void GetDetailedInfo()
        {
            GetInfo();
            Console.WriteLine($"MotorSize={MotorSize}\nFuelTankSize={FuelTankSize}\n" +
                $"FuelAmount={FuelAmount}\nFuelUsedPerKm={FuelUsedPerKm}\nColor={Color}\nPassangerCount={PassangerCount}\nHorsePower={HorsePower}\n" +
                $"Transmission={Transmission}");
        }
        
        
    }
}
