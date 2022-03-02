using System;
namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public Car()
        {
        }
        public double TrunkSpaceSqFt { get; set; }
        public bool IsLowRider { get; set; }
        public string LicensePlate { get; set; }
        public string VehicleColor { get; set; }
        public bool SafetyInspectionPassed { get; set; }
        public int VehicleYear { get; set; }
        public string CompanyName { get; set; }
        public int NumberOfEmployees { get; set; }        
    }
}
