namespace Race.Classes.Vehicles
{
    public class Car : Vehicle
    {
        // ****************************************************************
        // Properties
        // ****************************************************************
        public sealed override int VehicleNumberOfWheels => 4;
        public sealed override VehicleType VehicleType => VehicleType.Car;


        // ****************************************************************
        // Constructor
        // ****************************************************************
        public Car(int teamID, string make, string model, string colour, string year, int speed, List<Vehicle> allVehicles)
            : base(teamID, make, model, colour, year, speed, allVehicles)
        {
        }
    }
}