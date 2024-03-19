using Race.Classes.Circuits;
using Race.Classes.Results;
using Race.Classes.Teams;
using Race.Classes.Vehicles;

namespace Race.Classes.Managers
{
    public class ResultManager
    {

        // ****************************************************************
        // Properties
        // ****************************************************************


        // ****************************************************************
        // Constructor
        // ****************************************************************
        public ResultManager()
        {
        }

        ////////////////////////////////////////////////////////
        // Methods
        ////////////////////////////////////////////////////////
        public void RaceResults(List<Team> teams, Circuit circuitChoice, List<RaceResult> seasonResults)
        {
            List<Vehicle> vehiclesInRace = new List<Vehicle>();
            List<RaceResult> raceResult = new List<RaceResult>();
            RaceResult originalVehicleRaceResultRecord;
            RaceResult newVehicleRaceResultRecord;

            CreateRaceResultsList();
            UpdateRaceResultsList();
            ShowRaceResultsList();

            void CreateRaceResultsList()
            {
                foreach (Team team in teams)
                {
                    foreach (Vehicle vehicle in team.VehiclesInTeam)
                    {
                        vehiclesInRace.Add(vehicle);
                    }
                }

                for (int i = 0; i < vehiclesInRace.Count(); i++)
                {
                    int resultID = i;
                    int resultCircuitID = circuitChoice.ID;
                    int resultTeamID = vehiclesInRace.ElementAt(i).VehicleTeamID;
                    int resultVehicleID = vehiclesInRace.ElementAt(i).VehicleID;
                    String resultVehicleType = vehiclesInRace.ElementAt(i).VehicleType;
                    String resultVehicleMake = vehiclesInRace.ElementAt(i).VehicleMake;
                    String resultVehicleModel = vehiclesInRace.ElementAt(i).VehicleModel;
                    double resultTime = Math.Round((circuitChoice.NumberOfLaps * circuitChoice.LapLengthKm) / vehiclesInRace.ElementAt(i).VehicleSpeed, 2);
                    int resultPosition = 0;
                    int resultPoints = 0;
                    bool resultWinner = false;
                    bool resultPodium = false;

                    originalVehicleRaceResultRecord = new RaceResult(resultID,
                                                    resultVehicleID,
                                                    resultVehicleType,
                                                    resultVehicleMake,
                                                    resultVehicleModel,
                                                    resultCircuitID,
                                                    resultTeamID,
                                                    resultTime,
                                                    resultPosition,
                                                    resultPoints,
                                                    resultWinner,
                                                    resultPodium);
                    raceResult.Add(originalVehicleRaceResultRecord);
                }
            }


            void UpdateRaceResultsList()
            {
                bool podium = false;
                bool winner = false;
                int points = 0;

                raceResult = raceResult.OrderBy(x => x.Time).ToList();

                for (int i = 0, x = 1; i < raceResult.Count(); i++, x++)
                {
                    switch (x)
                    {
                        case 1:
                            podium = true;
                            winner = true;
                            points = 25;
                            break;

                        case 2:
                            podium = true;
                            points = 18;
                            break;

                        case 3:
                            podium = true;
                            points = 15;
                            break;

                        case 4:
                            points = 12;
                            break;

                        case 5:
                            points = 10;
                            break;

                        case 6:
                            points = 8;
                            break;

                        case 7:
                            points = 6;
                            break;

                        case 8:
                            points = 4;
                            break;

                        case 9:
                            points = 2;
                            break;

                        case 10:
                            points = 1;
                            break;

                        default:
                            points = 0;
                            break;
                    }

                    int resultID = raceResult.ElementAt(i).ResultID;
                    int resultCircuitID = raceResult.ElementAt(i).CircuitID;
                    int resultTeamID = raceResult.ElementAt(i).TeamID;
                    int resultVehicleID = raceResult.ElementAt(i).VehicleID;
                    String resultVehicleType = raceResult.ElementAt(i).VehicleType;
                    String resultVehicleMake = raceResult.ElementAt(i).VehicleMake;
                    String resultVehicleModel = raceResult.ElementAt(i).VehicleModel;
                    double resultTime = raceResult.ElementAt(i).Time;
                    int resultPosition = x;
                    int resultPoints = points;
                    bool resultWinner = raceResult.ElementAt(i).Winner;
                    bool resultPodium = raceResult.ElementAt(i).Podium;

                    newVehicleRaceResultRecord = new RaceResult(resultID,
                                                    resultVehicleID,
                                                    resultVehicleType,
                                                    resultVehicleMake,
                                                    resultVehicleModel,
                                                    resultCircuitID,
                                                    resultTeamID,
                                                    resultTime,
                                                    resultPosition,
                                                    resultPoints,
                                                    resultWinner,
                                                    resultPodium);
                    raceResult[i] = newVehicleRaceResultRecord;
                    seasonResults.Add(newVehicleRaceResultRecord);
                }
            }


            void ShowRaceResultsList()
            {
                String stringPodium;
                String stringWinner;

                Console.WriteLine($"  Results / timings:");

                for (int i = 0, x = 1; i < vehiclesInRace.Count(); i++, x++)
                {
                    switch (x)
                    {
                        case 1:
                            stringWinner = "** WINNER **";
                            stringPodium = "";
                            break;

                        case 2:
                            stringWinner = "";
                            stringPodium = "** PODIUM **";
                            break;

                        case 3:
                            stringWinner = "";
                            stringPodium = "** PODIUM **";
                            break;

                        default:
                            stringPodium = "      ";
                            stringWinner = "      ";
                            break;
                    }

                    Console.WriteLine($"   {stringWinner}{stringPodium} - #{raceResult.ElementAt(i).Position} {raceResult.ElementAt(i).Points}pts, (result ID{raceResult.ElementAt(i).ResultID}) {raceResult.ElementAt(i).Time}hrs/mins - Team {raceResult.ElementAt(i).TeamID} Vehicle #{raceResult.ElementAt(i).VehicleID}, ({raceResult.ElementAt(i).VehicleType}), {raceResult.ElementAt(i).VehicleMake} {raceResult.ElementAt(i).VehicleModel}");
                }

                Console.WriteLine();
            }
        }


        public void ShowSeasonResults()
        {
            //var grouped = SeasonResults.GroupBy(SeasonResults => new { SeasonResults.CircuitID });

            //foreach (var group in grouped)
            //{
            //    foreach (var result in group)
            //    {
            //        Console.WriteLine($"Circuit:{result.CircuitID}, Team:{result.TeamID}, Vehicle:{result.VehicleID}, Position:{result.Position}, Points:{result.Points}");
            //    }
            //}

            //Console.WriteLine();
        }


    }
}
