using System;
using System.Collections.Generic;
using System.Linq;
using Race.Classes.Circuits;
using Race.Classes.Results;
using Race.Classes.Teams;
using Race.Classes.Vehicles;

namespace Race
{
    public class RaceManager
    {
        // ****************************************************************
        // Properties
        // ****************************************************************
        public Menu Menu { get; set; }
        public ListManager Lists { get; set; }


        // ****************************************************************
        // Constructor
        // ****************************************************************
        public RaceManager()
        {
            Lists = new ListManager();
            Initialise();
            UserInteractsWithMenu();
        }


        // ****************************************************************
        // Methods
        // ****************************************************************
        public void Initialise()
        {
            

            // Initialize some test vehicles
            Vehicle vehicle1 = new Car(1, "Ford", "Focus", "Black", "2013", "CAR", 4, 86, "speed category", false, Lists.AllVehicles, Lists.UnassignedVehicles, Lists.NumberOfVehicles);
            Vehicle vehicle2 = new Car(2, "Volvo", "V40", "White", "2024", "car", 4, 79, "speed category", false, Lists.AllVehicles, Lists.UnassignedVehicles, Lists.NumberOfVehicles);
            Vehicle vehicle3 = new Car(3, "Audi", "A5", "Grey", "2012", "car", 4, 110, "speed category", false, Lists.AllVehicles, Lists.UnassignedVehicles, Lists.NumberOfVehicles);
            Vehicle vehicle4 = new Car(4, "Toyota", "Corolla", "Black", "2023", "CAR", 4, 92, "speed category", false, Lists.AllVehicles, Lists.UnassignedVehicles, Lists.NumberOfVehicles);
            Vehicle vehicle5 = new Bike(5, "Canyon", "Strive", "Black", "2015", "BIKE", 2, 27, "speed category", false, Lists.AllVehicles, Lists.UnassignedVehicles, Lists.NumberOfVehicles);
            Vehicle vehicle6 = new Bike(6, "Marin", "Nail Trail", "Silver", "2003", "BIKE", 2, 18, "speed category", false, Lists.AllVehicles, Lists.UnassignedVehicles, Lists.NumberOfVehicles);
            Vehicle vehicle7 = new Truck(7, "Volvo", "FH", "White", "2018", "TRUCK", 10, 71, "speed category", false, Lists.AllVehicles, Lists.UnassignedVehicles, Lists.NumberOfVehicles);
            Vehicle vehicle8 = new Truck(8, "Scania", "R Series", "White", "2019", "TRUCK", 10, 68, "speed category", false, Lists.AllVehicles, Lists.UnassignedVehicles, Lists.NumberOfVehicles);


            // Initialize some test teams
            Team team1 = new Team(0, "Ferarri");
            Team team2 = new Team(0, "McLaren");
            Team team3 = new Team(0, "Mercedes");
            Team team4 = new Team(0, "Red Bull");
            Team team5 = new Team(0, "RB");
            Team team6 = new Team(0, "Aston Martin");
            Team team7 = new Team(0, "Alpine");
            Team team8 = new Team(0, "Williams");
            Team team9 = new Team(0, "Sauber");
            Team team10 = new Team(0, "Haas");


            // Add vehicles to teams
            team1.VehiclesInTeam.Add(vehicle1);
            Lists.UnassignedVehicles.Remove(vehicle1);
            team1.VehiclesInTeam.Add(vehicle2);
            Lists.UnassignedVehicles.Remove(vehicle2);
            team2.VehiclesInTeam.Add(vehicle3);
            Lists.UnassignedVehicles.Remove(vehicle3);
            team2.VehiclesInTeam.Add(vehicle5);
            Lists.UnassignedVehicles.Remove(vehicle5);
            team2.VehiclesInTeam.Add(vehicle8);
            Lists.UnassignedVehicles.Remove(vehicle8);


            // Initialize some circuits
            Circuit circuit1 = new Circuit(0, "Bahrain", 57, 5.4);
            Circuit circuit2 = new Circuit(0, "Saudi Arabian", 50, 6.2);
            Circuit circuit3 = new Circuit(0, "Australian", 58, 5.2);
            Circuit circuit4 = new Circuit(0, "Chinese", 56, 5.6);
            Circuit circuit5 = new Circuit(0, "Spanish", 66, 4.7);
            Circuit circuit6 = new Circuit(0, "Monaco", 77, 3.3);
            Circuit circuit7 = new Circuit(0, "Canadian", 70, 4.4);
            Circuit circuit8 = new Circuit(0, "Azerbaijan", 51, 6);
            Circuit circuit9 = new Circuit(0, "Austrian", 71, 4.3);
            Circuit circuit10 = new Circuit(0, "British", 52, 4.4);
            Circuit circuit11 = new Circuit(0, "Hungarian", 70, 4.4);
            Circuit circuit12 = new Circuit(0, "Belgian", 44, 7);
            Circuit circuit13 = new Circuit(0, "Italian", 63, 5.8);
            Circuit circuit14 = new Circuit(0, "Singapore", 61, 4.9);
            Circuit circuit15 = new Circuit(0, "Japanese", 53, 5.8);
            Circuit circuit16 = new Circuit(0, "United States", 56, 5.5);
            Circuit circuit17 = new Circuit(0, "Mexican", 71, 4.3);
            Circuit circuit18 = new Circuit(0, "Brazilian", 71, 4.3);
            Circuit circuit19 = new Circuit(0, "Abu Dahabi", 58, 5.6);
            Circuit circuit20 = new Circuit(0, "Netherlands", 72, 4.3);
            Circuit circuit21 = new Circuit(0, "Italian (Emilia-Romagna)", 63, 5);
            Circuit circuit22 = new Circuit(0, "Qatar", 57, 5.4);
            Circuit circuit23 = new Circuit(0, "Miami", 57, 5.4);
            Circuit circuit24 = new Circuit(0, "Las Vegas", 50, 6.1);
        }


        public void UserInteractsWithMenu()
        {
            Menu menu = new Menu();
            int userInput;

            do
            {
                menu.ShowMenu();
                userInput = menu.ChooseMenuOption();

                switch (userInput)
                {
                    case 1:
                        StartGrandPrix();
                        break;

                    case 2:
                        HowManyTeamsAreThere();
                        HowManyVehiclesAreThere();
                        HowManyCircuitsAreThere();
                        Console.WriteLine();
                        break;

                    case 3:
                        ShowAllVehicles();                                          
                        break;

                    case 4:
                        ShowVehiclesInEachTeam();
                        break;

                    case 5:
                        ShowVehiclesNotAssignedToAnyTeam();
                        break;

                    case 6:
                        ShowAllTeams();
                        break;

                    case 7:
                        ShowAllCircuits();
                        break;
                }
            }

            while (userInput != 8);
        }


        ////////////////////////////////////////////////////////
        // Methods relating to Vehicles
        ////////////////////////////////////////////////////////
        public void HowManyVehiclesAreThere()
        {
            Console.WriteLine($"vehicles = {Lists.NumberOfVehicles-1}");
        }

        
        public void ShowAllVehicles()
        {
            int number = 1;

            Console.WriteLine($"Every vehicle:");
            Console.WriteLine($"==============");

            foreach (Vehicle vehicle in Lists.AllVehicles)
            {
                Console.WriteLine($"    - Vehicle #{vehicle.ID} - {vehicle.Type.ToUpper()}, {vehicle.Make}, {vehicle.Model}, {vehicle.Colour}, {vehicle.Year}, {vehicle.SpeedCategory.ToUpper()}");
                number++;
            }

            Console.WriteLine();
        }


        public void ShowVehiclesNotAssignedToAnyTeam()
        {
            Console.WriteLine("Vehicles not assigned to any team:");
            Console.WriteLine($"=================================");

            foreach (Vehicle vehicle in Lists.UnassignedVehicles)
            {
                Console.WriteLine($"    - Vehicle #{vehicle.ID} - {vehicle.Type.ToUpper()}, {vehicle.Make}, {vehicle.Model}, {vehicle.Colour}, {vehicle.Year}, {vehicle.SpeedCategory.ToUpper()}");
            }

            Console.WriteLine();
        }


        ////////////////////////////////////////////////////////
        // Methods relating to Team class
        ////////////////////////////////////////////////////////
        public void HowManyTeamsAreThere()
        {
            Console.WriteLine($"Teams = {Team.NumberOfTeams-1}");
        }


        public void ShowAllTeams()
        {
            int number = 1;
            Console.WriteLine($"The teams are:");
            foreach (Team team in Team.Teams)
            {
                Console.WriteLine($"- Team #{team.ID}, {team.Name}");
                number++;
            }

            Console.WriteLine();
        }


        public void ShowVehiclesInEachTeam()
        {
            Console.WriteLine("Vehicles per team:");
            Console.WriteLine($"=================");

            foreach (Team team in Team.Teams)
            {
                Console.WriteLine($"     - {team.Name}");

                foreach (Vehicle vehicle in team.VehiclesInTeam)
                {
                    Console.WriteLine($"\tVehicle #{vehicle.ID} - {vehicle.Type.ToUpper()}, {vehicle.Make}, {vehicle.Model}, {vehicle.Colour}, {vehicle.Year}, {vehicle.SpeedCategory.ToUpper()}");
                }
            }

            Console.WriteLine();
        }


        ////////////////////////////////////////////////////////
        // Methods relating to Circuits
        ////////////////////////////////////////////////////////
        public void HowManyCircuitsAreThere()
        {
            Console.WriteLine($"Circuits = {Circuit.NumberOfCircuits-1}");
        }


        public void ShowAllCircuits()
        {
            foreach(Circuit circuit in Circuit.Circuits)
            {
                double totalCircuitLengthKm = circuit.LapLengthKm * circuit.NumberOfLaps;
                Console.WriteLine($"- Circuit #{circuit.ID}, {circuit.Name}, {circuit.NumberOfLaps} laps, 1xlap ={circuit.LapLengthKm}km, TOTAL LENGTH = {Math.Round(totalCircuitLengthKm, 1)}km");
            }

            Console.WriteLine();
        }


        ////////////////////////////////////////////////////////
        // Methods relating to Race Control
        ////////////////////////////////////////////////////////
        public void StartGrandPrix()
        {
            int x = 0;

            while (x == 0)
            {
                Circuit circuit = AskUserToChooseCircuit();
                String answer = ConfirmChoiceOfCircuit();

                switch (answer)
                {
                    case "y":
                    case "Y":
                        Console.WriteLine("");
                        x = 1;                           
                        break;

                    case "n":
                    case "N":
                        Console.WriteLine("");
                        continue;

                    case "x":
                    case "X":
                        Console.WriteLine("");
                        return;
                        
                    default:
                        Console.WriteLine("invalid response, please press 'y', 'n' or 'x'");
                        Console.WriteLine();
                        continue;
                }

                StartRace(circuit);
                //ShowStatistics ask user if they want to proceed (y/n) (need to add the chosen circuit) y will start the race, n will exit completely
                StopRace(circuit);
            }          
        }


        Circuit AskUserToChooseCircuit()
        {
            int userChoice = GetChoiceOfCircuit();
            return DisplayChoiceOfCircuit(userChoice);
        }


                int GetChoiceOfCircuit()
                {
                    Console.WriteLine($"Which circuit do you want to choose?");
                    return Convert.ToInt32(Console.ReadLine()) - 1;
                }


                Circuit DisplayChoiceOfCircuit(int userChoice)
                {
                    Console.WriteLine();
                    Circuit choice = Circuit.Circuits.ElementAt(userChoice);
                    Console.WriteLine($"You have selected: #{choice.ID} - {choice.Name} Grand Prix");
                    Console.WriteLine();
                    return choice;
                }


        String ConfirmChoiceOfCircuit()
        {
            Console.WriteLine($"Is this correct?");
            Console.WriteLine($"y(yes) n(no) x(exit)");
            return Console.ReadLine();
        }


        public void StartRace(Circuit circuit)
        {
            Console.WriteLine($"  The {circuit.Name} Grand Prix has started!");
            Console.WriteLine($"  =========================================");
            Console.WriteLine();
            Thread.Sleep(1000);

            Console.WriteLine($"  Circuit details: Number of laps:{circuit.NumberOfLaps}, Distance per lap: {circuit.LapLengthKm}km, total distance {circuit.NumberOfLaps * circuit.LapLengthKm}km");
            Console.WriteLine();
            Thread.Sleep(1000);

            StartAllVehicles();
            Thread.Sleep(1000);

            ShowEachLap(circuit);
            Thread.Sleep(1000);
        }


                public void StartAllVehicles()
                {
                    Console.WriteLine($"  Starting Vehicles:");

                    foreach (Team team in Team.Teams)
                    {

                        foreach (Vehicle vehicle in team.VehiclesInTeam)
                        {
                            vehicle.Start();
                        }
                    }

                    Console.WriteLine();
                }

                public void ShowEachLap(Circuit circuit)
                {
                    Console.WriteLine($"   Race progress");

                    for (int i = 1; i <= circuit.NumberOfLaps; i++ )
                    {
                        Console.WriteLine($"   Lap number {i}");
                        Thread.Sleep(25);
                    }

                    Console.WriteLine();
                }


        public void StopRace(Circuit circuit)
        {
            Console.WriteLine($"  The race is ending...");
            Console.WriteLine();
            Thread.Sleep(1000);

            StopAllVehicles();
            Thread.Sleep(1000);

            Results(circuit);
            Thread.Sleep(1000);

            Console.WriteLine($"  The Grand Prix has ended!");
            Console.WriteLine($"  =========================");
            Console.WriteLine();
        }


                public void StopAllVehicles()
                {
                    Console.WriteLine($"  Stopping Vehicles:");

                    foreach (Team team in Team.Teams)
                    {

                        foreach (Vehicle vehicle in team.VehiclesInTeam)
                        {
                            vehicle.Stop();
                        }  
                    }
                    Console.WriteLine();
                }

        public void Results(Circuit circuit)
        {
            Console.WriteLine($"  Results / timings:");

            List<Vehicle> allVehicles = new List<Vehicle>();
            List<RaceResult> raceResult = new List<RaceResult>();

            foreach (Team team in Team.Teams)
            {
                foreach (Vehicle vehicle in team.VehiclesInTeam)
                {
                    allVehicles.Add(vehicle);
                }
            }

            foreach (Vehicle raceVehicle in allVehicles)
            {
                int resultVehicleID = raceVehicle.ID;
                String resultVehicleType = raceVehicle.Type;
                String resultVehicleMake = raceVehicle.Make;
                String resultVehicleModel = raceVehicle.Model;
                String resultCircuitName = circuit.Name;
                String resultTeamName = "?";
                double resultTime = Math.Round((circuit.NumberOfLaps * circuit.LapLengthKm) / raceVehicle.Speed, 2);
                int resultPosition = 0;
                int resultPoints = 0;

                RaceResult resultRecord = new RaceResult(resultVehicleID, resultVehicleType, resultVehicleMake, resultVehicleModel, resultCircuitName, resultTeamName, resultTime, resultPosition, resultPoints);
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

                Console.WriteLine($"   {podium} - #{x} {p}pts, {resultsOrderedBy.ElementAt(i).Time}hrs/mins - Team{resultsOrderedBy.ElementAt(i).TeamName} Vehicle #{resultsOrderedBy.ElementAt(i).VehicleID}, ({resultsOrderedBy.ElementAt(i).VehicleType}), {resultsOrderedBy.ElementAt(i).VehicleMake} {resultsOrderedBy.ElementAt(i).VehicleModel}");
            }

            Console.WriteLine();
        }
    }
}
