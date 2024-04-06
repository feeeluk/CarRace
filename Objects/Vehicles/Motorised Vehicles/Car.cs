using Race.Objects.Teams;

namespace Race.Objects.Vehicles
{
    public class Car : MotorisedVehicle
    {
        // ****************************************************************
        // Properties
        // ****************************************************************
        public sealed override int VehicleNumberOfWheels => 4;
        public sealed override VehicleType VehicleType => VehicleType.Car;
        public override int ServiceInterval => 10;


        // ****************************************************************
        // Constructor
        // ****************************************************************
        public Car(Team team, string make, string model, string colour, string year, int speed, List<Vehicle> allVehicles, List<MotorisedVehicle> motorisedVehicles, Engine engine, FuelTank fuelTank)
            : base(allVehicles, team, make, model, colour, year, speed, motorisedVehicles, engine, fuelTank)
        {
        }


        // *******************************************************
        // PUBLIC METHODS
        // *******************************************************
        public override void DNF()
        {
            Console.WriteLine($"Mechanical issue");
        }


        public override void ServiceVehicle()
        {
            Valet();
        }


        // *******************************************************
        // PRIVATE METHODS
        // *******************************************************
        private void Valet()
        {
            Console.WriteLine("Valet interior");
        }
    }
}