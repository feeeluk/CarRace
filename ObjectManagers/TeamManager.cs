using Race.Objects.Vehicles;
using Race.Objects.Teams;

namespace Race.ObjectsManagers
{
    public class TeamManager
    {
        // ****************************************************************
        // Properties
        // ****************************************************************
        public List<Team> Teams { get; set; }


        // ****************************************************************
        // Constructor
        // ****************************************************************
        public TeamManager()
        {
            Teams = new List<Team>();
        }


        // ****************************************************************
        // Methods
        // ****************************************************************
        public void HowManyTeamsAreThere()
        {
            Console.WriteLine($"  Teams = {Teams.Count}");
        }


        public void ShowAllTeams()
        {
            int number = 1;
            Console.WriteLine($"   All Teams:");
            Console.WriteLine($"   ==========");

            foreach (Team team in Teams)
            {
                Console.WriteLine($"   - Team #{team.ID}, {team.Name}");
                number++;
            }

            Console.WriteLine();
        }


        public void ShowVehiclesInEachTeam(List<Vehicle> allVehicles, List<MotorisedVehicle> motorisedVehicles)
        {
            Console.WriteLine($"   Vehicles per team:");
            Console.WriteLine($"   =================");

            foreach (Team team in Teams)
            {
                Console.WriteLine($"   - {team.Name}");

                foreach (Vehicle v in allVehicles)
                {
                    if (team == v.VehicleTeam)
                    {
                        Console.Write($"    - Vehicle #{v.VehicleID} - {v.VehicleType}," +
                                $"{v.VehicleMake}, {v.VehicleModel}, {v.VehicleColour}, {v.VehicleYear}, " +
                                $"{v.VehicleSpeedCategory}");

                        if (v.IsMotorisedVehicle == true)
                        {
                            MotorisedVehicle mv = motorisedVehicles.Find(x => x.VehicleID == v.VehicleID);
                            Console.Write($", Engine(ID:{mv.MotorisedVehicleEngine.EngineID}, {mv.MotorisedVehicleEngine.EngineName}, {mv.MotorisedVehicleEngine.EngineFuelType}), " +
                                $"Fuel Tank(ID:{mv.MotorisedVehicleFuelTank.FuelTankID}, {mv.MotorisedVehicleFuelTank.FuelTankName}, {mv.MotorisedVehicleFuelTank.FuelTankSize} ltrs)");
                        }

                        Console.WriteLine();

                    }
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
