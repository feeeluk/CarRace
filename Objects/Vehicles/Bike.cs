using Race.Objects.Teams;

namespace Race.Objects.Vehicles
{
    public class Bike : Vehicle
    {
        // ****************************************************************
        // Properties
        // ****************************************************************
        public sealed override int VehicleNumberOfWheels => 2;
        public sealed override VehicleType VehicleType => VehicleType.Bike;
        public override int ServiceInterval => 8;


        // ****************************************************************
        // Constructor
        // ****************************************************************
        public Bike(Team team, string make, string model, string colour, string year, int speed, List<Vehicle> allVehicles)
            : base(allVehicles, team, make, model, colour, year, speed)
        {
        }


        // *******************************************************
        // PUBLIC METHODS
        // *******************************************************
        public override void ServiceVehicle()
        {
            OilChain();
            PumpUpTyres();
        }


        // *******************************************************
        // PRIVATE METHODS
        // *******************************************************
        private void OilChain()
        {
            Console.WriteLine("OilChain");
        }


        private void PumpUpTyres()
        {
            Console.WriteLine("Pump up tyres");
        }
    }
}