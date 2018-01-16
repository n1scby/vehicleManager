using System;
using System.Collections.Generic;
using VehicleLibrary;

namespace vehicleManager
{
    class VehicleManagerConsole
    {
        static void Main(string[] args)
        {
            List<Car> Cars = new List<Car>();

            for (int i = 0; i < 10;  i++)
            {
                Car newCar = new Car(2005 + i, "Honda", "civic", 15.2M);

                Cars.Add(newCar);
            }

            OutputVehicle(Cars);

            Console.WriteLine("Hello World!");
        }

        static public void OutputVehicle(List<Car> CarList)
        {
            foreach (Car car in CarList)
            {
                Console.WriteLine(car.getVehicle() + " Trunk Size:" + car.TrunkSize);
                Console.ReadLine();
            }
        }
    }
}
