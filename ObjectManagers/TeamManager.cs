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


        public void ShowVehiclesInEachTeam(List<Vehicle> allVehicles)
        {
            Console.WriteLine($"   Vehicles per team:");
            Console.WriteLine($"   =================");

            foreach (Team team in Teams)
            {
                Console.WriteLine($"   - {team.Name}");

                foreach (Vehicle vehicle in allVehicles)
                {
                    if (team.ID == vehicle.VehicleTeamID)
                    {
                        Console.WriteLine($"    * Vehicle #{vehicle.VehicleID} - {vehicle.VehicleType}, {vehicle.VehicleMake}, {vehicle.VehicleModel}, {vehicle.VehicleColour}, {vehicle.VehicleYear}, {vehicle.VehicleSpeedCategory.ToUpper()}");
                    }
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
