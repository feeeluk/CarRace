using Race.Classes.Circuits;
using Race.Classes.Results;
using Race.Classes.Teams;
using Race.Classes.Vehicles;

namespace Race.Classes.Managers
{
    public class VehicleManager
    {
        // ****************************************************************
        // Properties
        // ****************************************************************
        public List<Vehicle> AllVehicles { get; set; }
        public List<Vehicle> UnassignedVehicles { get; set; }


        // ****************************************************************
        // Constructor
        // ****************************************************************
        public VehicleManager()
        {
            AllVehicles = new List<Vehicle>();
            UnassignedVehicles = new List<Vehicle>();
        }


        // ****************************************************************
        // Methods relating to Vehicles
        // ****************************************************************
        public void HowManyVehiclesAreThere()
        {
            Console.WriteLine($"  vehicles = {AllVehicles.Count}");
        }


        public void ShowAllVehicles()
        {
            int number = 1;

            Console.WriteLine($"   All Vehicles:");
            Console.WriteLine($"   ==============");

            foreach (Vehicle vehicle in AllVehicles)
            {
                Console.WriteLine($"    - Vehicle #{vehicle.VehicleID} - {vehicle.VehicleType.ToUpper()}, {vehicle.VehicleMake}, {vehicle.VehicleModel}, {vehicle.VehicleColour}, {vehicle.VehicleYear}, {vehicle.VehicleSpeedCategory.ToUpper()}");
                number++;
            }

            Console.WriteLine();
        }


        public void ShowVehiclesNotAssignedToAnyTeam()
        {
            Console.WriteLine($"   Vehicles not assigned to any team:");
            Console.WriteLine($"   =================================");

            foreach (Vehicle vehicle in UnassignedVehicles)
            {
                Console.WriteLine($"    - Vehicle #{vehicle.VehicleID} - {vehicle.VehicleType.ToUpper()}, {vehicle.VehicleMake}, {vehicle.VehicleModel}, {vehicle.VehicleColour}, {vehicle.VehicleYear}, {vehicle.VehicleSpeedCategory.ToUpper()}");
            }

            Console.WriteLine();
        }
    }
}
