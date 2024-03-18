using Race.Classes.Circuits;
using Race.Classes.Results;
using Race.Classes.Teams;
using Race.Classes.Vehicles;

namespace Race.Classes.Managers
{
    public class ResultManager
    {
        public RaceResult resultRecord;
        
        public void RaceResults(List<Team> teams, Circuit circuitChoice, List<RaceResult> seasonResults)
        {
            List<Vehicle> raceVehicles = new List<Vehicle>();
            List<RaceResult> raceResult = new List<RaceResult>();

            

            CalculateRaceResults();
            ShowRaceResults();


            void CalculateRaceResults()
            {
                foreach (Team team in teams)
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
                    int resultCircuitID = circuitChoice.ID;
                    int resultTeamID = raceVehicle.TeamID;
                    int resultVehicleID = raceVehicle.ID;
                    String resultVehicleType = raceVehicle.Type;
                    String resultVehicleMake = raceVehicle.Make;
                    String resultVehicleModel = raceVehicle.Model;

                    double resultTime = Math.Round((circuitChoice.NumberOfLaps * circuitChoice.LapLengthKm) / raceVehicle.Speed, 2);
                    int resultPosition = 0;
                    int resultPoints = 0;

                    resultRecord = new RaceResult(resultID, resultVehicleID, resultVehicleType, resultVehicleMake, resultVehicleModel, resultCircuitID, resultTeamID, resultTime, resultPosition, resultPoints);
                    raceResult.Add(resultRecord);
                    seasonResults.Add(resultRecord);
                }
            }


            void ShowRaceResults()
            {
                Console.WriteLine($"  Results / timings:");

                raceResult = raceResult.OrderBy(x => x.Time).ToList();

                for (int i = 0, x = 1; i < raceResult.Count; i++, x++)
                {
                    String podium = "            ";
                    int p = raceResult.ElementAt(i).Points;

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

                    Console.WriteLine($"   {podium} - #{x} {p}pts, {raceResult.ElementAt(i).CircuitID} (result ID{raceResult.ElementAt(i).ID}) {raceResult.ElementAt(i).Time}hrs/mins - Team {raceResult.ElementAt(i).TeamID} Vehicle #{raceResult.ElementAt(i).VehicleID}, ({raceResult.ElementAt(i).VehicleType}), {raceResult.ElementAt(i).VehicleMake} {raceResult.ElementAt(i).VehicleModel}");
                }
            }
        }
    }
}
