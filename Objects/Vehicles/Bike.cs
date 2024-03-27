namespace Race.Classes.Vehicles
{
    public class Bike : Vehicle
    {
        // ****************************************************************
        // Properties
        // ****************************************************************
        public sealed override int VehicleNumberOfWheels => 2;
        public sealed override VehicleType VehicleType => VehicleType.Bike;


        // ****************************************************************
        // Constructor
        // ****************************************************************
        public Bike(int teamID, string make, string model, string colour, string year, int speed, List<Vehicle> allVehicles)
            : base(teamID, make, model, colour, year, speed, allVehicles)
        {
        }
    }
}