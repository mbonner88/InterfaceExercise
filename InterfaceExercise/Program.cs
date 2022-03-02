using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            var car = new Car()
            {
                LicensePlate = "6HV917",
                VehicleColor = "green",
                SafetyInspectionPassed = false,
                VehicleYear = 2003,
                CompanyName = "Wet Willy's Hydroponics",
                NumberOfEmployees = 1,
                TrunkSpaceSqFt = 12.5,
                IsLowRider = false,
            };

            var truck = new Truck()
            {
                LicensePlate = "4LI8JK",
                VehicleColor = "black",
                SafetyInspectionPassed = true,
                VehicleYear = 2019,
                CompanyName = "Frank the Tank's Construction",
                NumberOfEmployees = 4,
                HasCrewCab = true,
                HasBedLiner = false,
            };

            var suv = new SUV()
            {
                LicensePlate = "M0MK4R",
                VehicleColor = "blue",
                SafetyInspectionPassed = true,
                VehicleYear = 2014,
                CompanyName = "Kranky Karen's Kid Kamp",
                NumberOfEmployees = 3,
                CanRoll = true,
                HasTVScreens = true,
            };
            //Creatively display and organize their values
            var vehicles = new List<IVehicle>();
            vehicles.Add(car);
            vehicles.Add(truck);
            vehicles.Add(suv);
            foreach(var vehicle in vehicles)
            {
                Console.WriteLine($"License Plate:{vehicle.LicensePlate} Color:{vehicle.VehicleColor} Road-safe:{vehicle.SafetyInspectionPassed} Year:{vehicle.VehicleYear}");
            }
            Console.WriteLine($"");

            Console.WriteLine($"Vehicle 1 - Car");
            Console.WriteLine($"Company:{car.CompanyName} Employees:{car.NumberOfEmployees} Trunk Space(sqft):{car.TrunkSpaceSqFt} Has Low Rider Hydraulics:{car.IsLowRider}");
            Console.WriteLine($"");

            Console.WriteLine($"Vehicle 2 - Truck");
            Console.WriteLine($"Company:{truck.CompanyName} Employees:{truck.NumberOfEmployees} Crew Cab:{truck.HasCrewCab} Bed Liner:{truck.HasBedLiner}");
            Console.WriteLine($"");

            Console.WriteLine($"Vehicle 3 - SUV");
            Console.WriteLine($"Company:{suv.CompanyName} Employees:{suv.NumberOfEmployees} Rollability:{suv.CanRoll} TV Screens:{suv.HasTVScreens}");
        }
    }
}
