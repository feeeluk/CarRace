using Race.Classes.Teams;
using Race.Classes.Vehicles;

namespace Race.Classes.Managers
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


        public void ShowVehiclesInEachTeam()
        {
            Console.WriteLine($"   Vehicles per team:");
            Console.WriteLine($"   =================");

            foreach (Team team in Teams)
            {
                Console.WriteLine($"   - {team.Name}");

                foreach (Vehicle vehicle in team.VehiclesInTeam)
                {
                    Console.WriteLine($"    * Vehicle #{vehicle.VehicleID} - {vehicle.VehicleType.ToUpper()}, {vehicle.VehicleMake}, {vehicle.VehicleModel}, {vehicle.VehicleColour}, {vehicle.VehicleYear}, {vehicle.VehicleSpeedCategory.ToUpper()}");

                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
