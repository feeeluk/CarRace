using Race.Objects.Teams;

namespace Race.Objects.Vehicles
{
    public class Truck : MotorisedVehicle
    {
        // ****************************************************************
        // Properties
        // ****************************************************************
        public sealed override int VehicleNumberOfWheels => 12;
        public sealed override VehicleType VehicleType => VehicleType.Truck;
        public override int ServiceInterval => 5;


        // ****************************************************************
        // Constructor
        // ****************************************************************
        public Truck(Team team, string make, string model, string colour, string year, int speed, List<Vehicle> allVehicles, List<MotorisedVehicle> motorisedVehicles, Engine engine, FuelTank fuelTank)
            : base(allVehicles, team, make, model, colour, year, speed, motorisedVehicles, engine, fuelTank)
        {
        }


        // *******************************************************
        // PUBLIC METHODS
        // *******************************************************
        public override void ServiceVehicle()
        {
            ChangeTacograph();
        }


        // *******************************************************
        // PRIVATE METHODS
        // *******************************************************
        private void ChangeTacograph()
        {
            Console.WriteLine("Change tacograph");
        }
    }
}