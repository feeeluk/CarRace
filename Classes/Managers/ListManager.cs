using Race.Classes.Circuits;
using Race.Classes.Results;
using Race.Classes.Teams;
using Race.Classes.Vehicles;

namespace Race.Classes.Managers
{
    public class ListManager
    {
        // ****************************************************************
        // Properties
        // ****************************************************************
        public List<Vehicle> AllVehicles { get; set; }
        public List<Vehicle> UnassignedVehicles { get; set; }
        public List<Team> Teams { get; set; }
        public List<Circuit> Circuits { get; set; }
        public List<RaceResult> RaceResults { get; set; }
        public List<RaceResult> SeasonResults { get; set; }

        
        // ****************************************************************
        // Constructor
        // ****************************************************************
        public ListManager()
        {
            AllVehicles = new List<Vehicle>();
            UnassignedVehicles = new List<Vehicle>();
            Teams = new List<Team>();
            Circuits = new List<Circuit>();
            RaceResults = new List<RaceResult>();
            SeasonResults = new List<RaceResult>();
        }


        ////////////////////////////////////////////////////////
        // Methods relating to Vehicles
        ////////////////////////////////////////////////////////
        public void HowManyVehiclesAreThere()
        {
            Console.WriteLine($"vehicles = {AllVehicles.Count}");
        }


        public void ShowAllVehicles()
        {
            int number = 1;

            Console.WriteLine($"   All Vehicles:");
            Console.WriteLine($"   ==============");

            foreach (Vehicle vehicle in AllVehicles)
            {
                Console.WriteLine($"    - Vehicle #{vehicle.ID} - {vehicle.Type.ToUpper()}, {vehicle.Make}, {vehicle.Model}, {vehicle.Colour}, {vehicle.Year}, {vehicle.SpeedCategory.ToUpper()}");
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
                Console.WriteLine($"    - Vehicle #{vehicle.ID} - {vehicle.Type.ToUpper()}, {vehicle.Make}, {vehicle.Model}, {vehicle.Colour}, {vehicle.Year}, {vehicle.SpeedCategory.ToUpper()}");
            }

            Console.WriteLine();
        }


        ////////////////////////////////////////////////////////
        // Methods relating to Team
        ////////////////////////////////////////////////////////
        public void HowManyTeamsAreThere()
        {
            Console.WriteLine($"Teams = {Teams.Count}");
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
                    Console.WriteLine($"    * Vehicle #{vehicle.ID} - {vehicle.Type.ToUpper()}, {vehicle.Make}, {vehicle.Model}, {vehicle.Colour}, {vehicle.Year}, {vehicle.SpeedCategory.ToUpper()}");

                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }


        ////////////////////////////////////////////////////////
        // Methods relating to Circuits
        ////////////////////////////////////////////////////////
        public void HowManyCircuitsAreThere()
        {
            Console.WriteLine($"Circuits = {Circuits.Count}");
        }

        public int HowManyCircuits()
        {
            return Circuits.Count;
        }

        public void ShowAllCircuits()
        {
            Console.WriteLine($"   List all Circuits");
            Console.WriteLine($"   =================");

            foreach (Circuit circuit in Circuits)
            {
                double totalCircuitLengthKm = circuit.LapLengthKm * circuit.NumberOfLaps;
                Console.WriteLine($"   - Circuit #{circuit.ID}, {circuit.Name}, {circuit.NumberOfLaps} laps, 1xlap ={circuit.LapLengthKm}km, TOTAL LENGTH = {Math.Round(totalCircuitLengthKm, 1)}km");
            }

            Console.WriteLine();
        }


        ////////////////////////////////////////////////////////
        // Methods relating to Team
        ////////////////////////////////////////////////////////
        public void ShowSeasonResults()
        {

        }

    }
}
