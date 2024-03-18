using Race.Classes.Circuits;
using Race.Classes.Results;
using Race.Classes.Teams;
using Race.Classes.Vehicles;

namespace Race.Classes.Managers
{
    public class ResultManager
    {
        List<Team> Teams { get; set; }
        Circuit Circuits { get; set; }

        public void RaceResults(List<Team> teams, Circuit circuitChoice)
        {
            Teams = teams;
            Circuits = circuitChoice;
            
            List<Vehicle> raceVehicles = new List<Vehicle>();
            List<RaceResult> raceResult = new List<RaceResult>();

            //RaceManagerObj.CalculateResults()
            //RaceManagerObj.ShowRaceResults()
            //RaceManagerObj.StoreRaceResults()

            Console.WriteLine($"  Results / timings:");

            foreach (Team team in Teams)
            {
                foreach (Vehicle vehicle in team.VehiclesInTeam)
                {
                    raceVehicles.Add(vehicle);
                }
            }

            
            int id = 0;

            foreach (Vehicle raceVehicle in raceVehicles)
            {
                int resultID = id;
                id++;
                int resultCircuitID = Circuits.ID;
                int resultTeamID = raceVehicle.TeamID;
                int resultVehicleID = raceVehicle.ID;
                String resultVehicleType = raceVehicle.Type;
                String resultVehicleMake = raceVehicle.Make;
                String resultVehicleModel = raceVehicle.Model;
                    
                double resultTime = Math.Round((circuitChoice.NumberOfLaps * circuitChoice.LapLengthKm) / raceVehicle.Speed, 2);
                int resultPosition = 0;
                int resultPoints = 0;

                RaceResult resultRecord = new RaceResult(resultID, resultVehicleID, resultVehicleType, resultVehicleMake, resultVehicleModel, resultCircuitID, resultTeamID, resultTime, resultPosition, resultPoints);
                raceResult.Add(resultRecord);
            }
            

            var resultsOrderedBy = raceResult.OrderBy(x => x.Time).ToList();

            for (int i = 0, x = 1; i < resultsOrderedBy.Count; i++, x++)
            {
                String podium = "            ";
                int p = resultsOrderedBy.ElementAt(i).Points;

                switch (x)
                {
                    case 1:
                        podium = "** WINNER **";
                        p = 25;
                        break;

                    case 2:
                        podium = "** PODIUM **";
                        p = 18;
                        break;

                    case 3:
                        podium = "** PODIUM **";
                        p = 15;
                        break;

                    case 4:
                        p = 12;
                        break;

                    case 5:
                        p = 10;
                        break;

                    case 6:
                        p = 8;
                        break;

                    case 7:
                        p = 6;
                        break;

                    case 8:
                        p = 4;
                        break;

                    case 9:
                        p = 2;
                        break;

                    case 10:
                        p = 1;
                        break;

                    default:
                        break;
                }

                Console.WriteLine($"   {podium} - #{x} {p}pts, {resultsOrderedBy.ElementAt(i).CircuitID} (result ID{resultsOrderedBy.ElementAt(i).ID}) {resultsOrderedBy.ElementAt(i).Time}hrs/mins - Team {resultsOrderedBy.ElementAt(i).TeamID} Vehicle #{resultsOrderedBy.ElementAt(i).VehicleID}, ({resultsOrderedBy.ElementAt(i).VehicleType}), {resultsOrderedBy.ElementAt(i).VehicleMake} {resultsOrderedBy.ElementAt(i).VehicleModel}");
            }

            Console.WriteLine();
        }
    }
}
