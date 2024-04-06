using Race.Objects.Vehicles;
using Race.Objects;
using Race.Objects.Teams;
using Race.Objects.Results;
using Race.Objects.Circuits;

namespace Race.ObjectsManagers
{
    public class ResultManager
    {
        // ****************************************************************
        // Properties
        // ****************************************************************
        public List<RaceResult> SeasonResults { get; private set; }

        // ****************************************************************
        // Constructor
        // ****************************************************************
        public ResultManager()
        {
            SeasonResults = new List<RaceResult>();
        }

        ////////////////////////////////////////////////////////
        // Methods
        ////////////////////////////////////////////////////////
        public void RaceResults(List<Team> teams, Circuit circuit, List<RaceResult> seasonResults, List<Vehicle> vehicles )
        {
            List<Vehicle> vehiclesInRace = new List<Vehicle>();
            List<RaceResult> raceResult = new List<RaceResult>();
            RaceResult originalVehicleRaceResultRecord;
            RaceResult newVehicleRaceResultRecord;

            CalculateRaceResults();
            UpdateRaceResultsList();
            ShowRaceResultsList();

            void CalculateRaceResults()
            {
                foreach (Vehicle vehicle in vehicles)
                {
                        vehiclesInRace.Add(vehicle);
                }


                for (int i = 0; i < vehiclesInRace.Count(); i++)
                {
                    int resultID = i;
                    DateTime resultDate = DateTime.Now;
                    int resultCircuitID = circuit.ID;
                    Team resultTeam = vehiclesInRace.ElementAt(i).VehicleTeam;
                    int resultVehicleID = vehiclesInRace.ElementAt(i).VehicleID;
                    VehicleType resultVehicleType = vehiclesInRace.ElementAt(i).VehicleType;
                    String resultVehicleMake = vehiclesInRace.ElementAt(i).VehicleMake;
                    String resultVehicleModel = vehiclesInRace.ElementAt(i).VehicleModel;
                    double result = 0;

                    for (int ii = 0; ii < circuit.NumberOfLaps; ii++)
                    {
                        Random random = new Random();
                        double randomLapModifier = random.NextDouble();
                        double modifiedSpeed = vehiclesInRace.ElementAt(i).VehicleSpeed * randomLapModifier;
                        result = circuit.LapLengthKm / modifiedSpeed;
                        result += result;
                    }
                    double resultTime = Math.Round(result, 2);
                    int resultPosition = 0;
                    int resultPoints = 0;
                    bool resultWinner = false;
                    bool resultPodium = false;

                    originalVehicleRaceResultRecord = new RaceResult(resultID,
                                                    resultDate, 
                                                    resultVehicleID,
                                                    resultVehicleType,
                                                    resultVehicleMake,
                                                    resultVehicleModel,
                                                    resultCircuitID,
                                                    resultTeam,
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
                bool podium;
                bool winner;
                int points;

                raceResult = raceResult.OrderBy(x => x.Time).ToList();

                for (int i = 0, x = 1; i < raceResult.Count(); i++, x++)
                {
                    switch (x)
                    {
                        case 1:
                            winner = true;
                            podium = true;
                            points = 25;
                            break;

                        case 2:
                            winner = false; 
                            podium = true;
                            points = 18;
                            break;

                        case 3:
                            winner = false;
                            podium = true;
                            points = 15;
                            break;

                        case 4:
                            winner = false;
                            podium = false;
                            points = 12;
                            break;

                        case 5:
                            winner = false;
                            podium = false;
                            points = 10;
                            break;

                        case 6:
                            winner = false;
                            podium = false;
                            points = 8;
                            break;

                        case 7:
                            winner = false;
                            podium = false;
                            points = 6;
                            break;

                        case 8:
                            winner = false;
                            podium = false;
                            points = 4;
                            break;

                        case 9:
                            winner = false;
                            podium = false;
                            points = 2;
                            break;

                        case 10:
                            winner = false;
                            podium = false;
                            points = 1;
                            break;

                        default:
                            winner = false;
                            podium = false; 
                            points = 0;
                            break;
                    }

                    int resultID = raceResult.ElementAt(i).ResultID;
                    DateTime resultDate = raceResult.ElementAt(i).ResultDate;
                    int resultCircuitID = raceResult.ElementAt(i).CircuitID;
                    Team resultTeam = raceResult.ElementAt(i).Team;
                    int resultVehicleID = raceResult.ElementAt(i).VehicleID;
                    VehicleType resultVehicleType = raceResult.ElementAt(i).VehicleType;
                    String resultVehicleMake = raceResult.ElementAt(i).VehicleMake;
                    String resultVehicleModel = raceResult.ElementAt(i).VehicleModel;
                    double resultTime = raceResult.ElementAt(i).Time;
                    int resultPosition = x;
                    int resultPoints = points;
                    bool resultWinner = winner;
                    bool resultPodium = podium;

                    newVehicleRaceResultRecord = new RaceResult(resultID,
                                                    resultDate,             
                                                    resultVehicleID,
                                                    resultVehicleType,
                                                    resultVehicleMake,
                                                    resultVehicleModel,
                                                    resultCircuitID,
                                                    resultTeam,
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

                    Console.WriteLine($"   {stringWinner}{stringPodium}" +
                        $" - #{raceResult.ElementAt(i).Position} {raceResult.ElementAt(i).Points}pts, " +
                        $"Time:{raceResult.ElementAt(i).Time}hrs/mins, " +
                        $"Team: {raceResult.ElementAt(i).Team.Name}, " +
                        $"Vehicle #{raceResult.ElementAt(i).VehicleID} ({raceResult.ElementAt(i).VehicleType}, {raceResult.ElementAt(i).VehicleMake} {raceResult.ElementAt(i).VehicleModel})");
                }

                Console.WriteLine();
            }
        }


        public void ShowSeasonResults()
        {
            var grouped = SeasonResults.GroupBy(SeasonResults => new { SeasonResults.CircuitID });

            Console.WriteLine($"  Show all season's race results");
            Console.WriteLine($"  ==============================");

            foreach (var group in grouped)
            {
                foreach (var result in group)
                {
                    Console.WriteLine($"  Day: {result.ResultDate.ToString("yyyy/MM/dd")}, " +
                        $"Circuit:{result.CircuitID}, " +
                        $"Team:{result.Team}, " +
                        $"Vehicle:{result.VehicleID}, " +
                        $"Position:{result.Position}, " +
                        $"Points:{result.Points}, " +
                        $"Winner:{result.Winner}");
                }
            }

            Console.WriteLine();
        }


        public void ShowVehicleLeaderboard()
        {
            Console.WriteLine($"  Vehicle Leaderboard");
            Console.WriteLine($"  ===================");

            var query = (from s in SeasonResults
                         group s by new { s.VehicleID, s.VehicleType, s.VehicleMake, s.VehicleModel, s.Team.Name }
                        into grp
                         select new
                         {
                             grp.Key.VehicleID,
                             grp.Key.VehicleType,
                             grp.Key.VehicleMake,
                             grp.Key.VehicleModel,
                             grp.Key.Name,
                             TotalPoints = grp.Sum(s => s.Points)
                         }).ToList();

            foreach (var result in query)
            {
                Console.WriteLine($"  - Points: {result.TotalPoints} = Vehicle #{result.VehicleID}, {result.VehicleType}, {result.VehicleMake}, {result.VehicleModel}, {result.Name}"); 
            }

            Console.WriteLine();
        }


        public void ShowConstructorLeaderboard()
        {
            Console.WriteLine($"  Constructor Leaderboard");
            Console.WriteLine($"  =======================");

            var query = (from s in SeasonResults
                         group s by new { s.Team}
                        into grp
                         select new
                         {
                             grp.Key.Team,
                             TotalPoints = grp.Sum(s => s.Points)
                         }).ToList();

            foreach (var raceResult in query)
            {
                Console.WriteLine($"  - Points: {raceResult.TotalPoints} = {raceResult.Team.Name}");
            }

            Console.WriteLine();
        }


        public void HowManyRacesHaveThereBeen()
        {            
            List<String> distinctRaces = SeasonResults.Select(x => x.ResultDate.ToString("dd:HH:mm:ss")).Distinct().ToList();
            int countDistinctRaces = distinctRaces.Count();
            
            Console.WriteLine($"  Races run = {countDistinctRaces}");

        }
    }
}
