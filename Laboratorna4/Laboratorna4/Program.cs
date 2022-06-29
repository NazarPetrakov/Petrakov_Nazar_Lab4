using System;


namespace Laboratorna4
{
    class Program
    {
        static void Main(string[] args)
        {
            double dist = 520;
            Garage garage = new Garage();

            Console.WriteLine("Вiдстань:{0:F1} км\n", dist);
            
            Car BMW = new Car(150, 7,"Car BMW X5 2018", "diesel", 1000); 
            
            Console.WriteLine("Час:{0:F2} год",BMW.TravelTime(dist, BMW.Speed));
            Console.WriteLine("Цiна:{0:F3} грн",BMW.CalcPrice(BMW.FuelType, BMW.ConsPer100,dist));
            Console.WriteLine("Цiна за багаж:{0:F3} грн\n", BMW.baggadgePrice());
            garage.AddVehicle(BMW);


            Bike bike = new Bike(30,"Bike Hammer s200", 30);

            Console.WriteLine("Час:{0:F2} год", bike.TravelTime(dist, bike.Speed));
            Console.WriteLine("Цiна:{0:F3} грн", bike.CalcPrice(bike.FuelType, bike.ConsPer100, dist));
            Console.WriteLine("Цiна за багаж:{0:F3} грн\n", bike.baggadgePrice());
            garage.AddVehicle(bike);

            garage.ShowVehicle();
            Console.ReadLine();
        }
    }
}
