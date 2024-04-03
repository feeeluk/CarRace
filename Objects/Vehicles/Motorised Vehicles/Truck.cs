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
        public Truck(int teamID, string make, string model, string colour, string year, int speed, List<Vehicle> allVehicles)
            : base(allVehicles, teamID, make, model, colour, year, speed)
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