using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleLibrary
{
    public class Car: Vehicle
    {
        public Car(int year, string make, string model, decimal trunkSize):base(year, make, model)
        {
            TrunkSize = trunkSize;
        }

        public decimal TrunkSize { get; set; }

    }
}
