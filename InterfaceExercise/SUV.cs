using System;
namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public SUV()
        {
        }
        public bool CanRoll { get; set; }
        public bool HasTVScreens { get; set; }
        public string LicensePlate { get; set; }
        public string VehicleColor { get; set; }
        public bool SafetyInspectionPassed { get; set; }
        public int VehicleYear { get; set; }
        public string CompanyName { get; set; }
        public int NumberOfEmployees { get; set; }
    }
}
