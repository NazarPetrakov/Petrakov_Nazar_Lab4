using System;
using System.Collections.Generic;

namespace Laboratorna4
{
    abstract class Vehicle
    {
        public int Speed { get; set; }
        public double ConsPer100 { get; set; }
        public string Name { get; set; }
        public string FuelType { get; set; }
        public double Baggage { get; set; }

        public Vehicle(int Speed,string Name)
         {
            this.Speed = Speed;
            this.Name = Name;
            Console.WriteLine(Name);
         }
       
        public double TravelTime(double dist, int Speed)
        {
             return dist / Speed; 
        }
       
        public double CalcPrice(string fuel, double ConsPer100, double dist)
         {
            if (fuel.Equals("None"))
            {
                return 0;
            }
            if (fuel.Equals("diesel"))
            {
                return (ConsPer100 * dist * 55) / 100;
            }
            if (fuel.Equals("petrol"))
            {
                return (ConsPer100 * dist * 50) / 100;
            }
            return 0;
         }

        public double baggadgePrice()
        {
            return Baggage * 2;
        }

    }

    class Garage
    {
        List<Vehicle> vehicles = new List<Vehicle>();
        public void AddVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }
        public void ShowVehicle()
        {
            Console.WriteLine("В вашому гаражi:");
            foreach (Vehicle vi in vehicles)
            {
                Console.WriteLine(vi.Name);
            }
        }

    }

    class Car:Vehicle
    {
        
        public Car(int Speed, double ConsPer100, string Name, string FuelType, double Baggage) : base(Speed, Name)
        {
            this.Baggage = Baggage;
            this.FuelType = FuelType;
            this.ConsPer100 = ConsPer100;
        }      
        
    }
    class Bike : Vehicle
    {
        public Bike(int Speed, string Name, double Baggage) : base(Speed, Name)
        {
            this.Baggage = Baggage;
            FuelType = "None";
            ConsPer100 = 0;
        }
       
    }
    class Wagon : Vehicle
    {
        public Wagon(int Speed, string Name, double Baggage) : base(Speed, Name)
        {
            this.Baggage = Baggage;
            FuelType = "None";
            ConsPer100 = 0;
        }
    }
    class Unicycle : Vehicle
    {
        public Unicycle(int Speed, string Name) : base(Speed, Name)
        {
            FuelType = "None";
            ConsPer100 = 0;
            Baggage = 0;
        }
        
    }

}
