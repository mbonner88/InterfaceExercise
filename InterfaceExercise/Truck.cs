using System;
namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public Truck()
        {
        }
        public bool HasCrewCab { get; set; }
        public bool HasBedLiner { get; set; }
        public string LicensePlate { get; set; }
        public string VehicleColor { get; set; }
        public bool SafetyInspectionPassed { get; set; }
        public int VehicleYear { get; set; }
        public string CompanyName { get; set; }
        public int NumberOfEmployees { get; set; }
    }
}
