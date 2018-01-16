using System;

namespace VehicleLibrary
{
    public class Vehicle
    {
        public Vehicle()
        {
            Year = 0;
            Make = "";
            Model = "";
        }


        public Vehicle(int year, string make, string model)
        {
            Year = year;
            Make = make;
            Model = model;
        }


        public int Year { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }   


        public string getVehicle()
        {
            return ($"Vehicle: {this.Year} {this.Make} {this.Model}");

        }


    }






}
