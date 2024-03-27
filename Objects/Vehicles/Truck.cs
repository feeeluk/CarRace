namespace Race.Classes.Vehicles
{
    public class Truck : Vehicle
    {
        // ****************************************************************
        // Properties
        // ****************************************************************
        public sealed override int VehicleNumberOfWheels => 12;
        public sealed override VehicleType VehicleType => VehicleType.Truck;


        // ****************************************************************
        // Constructor
        // ****************************************************************
        public Truck(int teamID, string make, string model, string colour, string year, int speed, List<Vehicle> allVehicles)
            : base(teamID, make, model, colour, year, speed, allVehicles)
        {
        }
    }
}