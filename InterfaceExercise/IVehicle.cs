using System;
namespace InterfaceExercise
{
    public interface IVehicle
    {
        public string LicensePlate { get; set; }
        public string VehicleColor { get; set; }
        public bool SafetyInspectionPassed { get; set; }
        public int VehicleYear { get; set; }
    }
}
