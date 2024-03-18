using System;
using System.Collections.Generic;
using Race.Classes.Circuits;
using Race.Classes.Managers;
using Race.Classes.Results;
using Race.Classes.Teams;
using Race.Classes.Vehicles;

namespace Race
{
    public class RaceController
    {
        // ****************************************************************
        // Properties
        // ****************************************************************
        public Menu Menu { get; set; }
        public ListManager ListManagerObj { get; set; }
        public TeamManager TeamManagerObj { get; set; }
        public CircuitManager CircuitManagerObj { get; set; }
        public RaceManager RaceManagerObj { get; set; }
        public ResultManager ResultsManagerObj { get; set; }


        // ****************************************************************
        // Constructor
        // ****************************************************************
        public RaceController()
        {
            Initialise();
            UserInteractsWithMenu();
        }


        // ****************************************************************
        // Methods
        // ****************************************************************
        public void Initialise()
        {
            // Initialize objects of various manager classes 
            ListManagerObj = new ListManager();
            TeamManagerObj = new TeamManager();
            CircuitManagerObj = new CircuitManager();
            RaceManagerObj = new RaceManager();
            ResultsManagerObj = new ResultManager();


            // Initialize some test vehicles
            Vehicle vehicle1 = new Car(1, 1, "Ford", "Focus", "Black", "2013", "CAR", 4, 86, "speed category", false, ListManagerObj.AllVehicles, ListManagerObj.UnassignedVehicles);
            Vehicle vehicle2 = new Car(2, 1, "Volvo", "V40", "White", "2024", "car", 4, 79, "speed category", false, ListManagerObj.AllVehicles, ListManagerObj.UnassignedVehicles);
            Vehicle vehicle3 = new Car(3, 2, "Audi", "A5", "Grey", "2012", "car", 4, 110, "speed category", false, ListManagerObj.AllVehicles, ListManagerObj.UnassignedVehicles);
            Vehicle vehicle4 = new Car(4, 2, "Toyota", "Corolla", "Black", "2023", "CAR", 4, 92, "speed category", false, ListManagerObj.AllVehicles, ListManagerObj.UnassignedVehicles);
            Vehicle vehicle5 = new Bike(5, 2, "Canyon", "Strive", "Black", "2015", "BIKE", 2, 27, "speed category", false, ListManagerObj.AllVehicles, ListManagerObj.UnassignedVehicles);
            Vehicle vehicle6 = new Bike(6, 3,"Marin", "Nail Trail", "Silver", "2003", "BIKE", 2, 18, "speed category", false, ListManagerObj.AllVehicles, ListManagerObj.UnassignedVehicles);
            Vehicle vehicle7 = new Truck(7, 3, "Volvo", "FH", "White", "2018", "TRUCK", 10, 71, "speed category", false, ListManagerObj.AllVehicles, ListManagerObj.UnassignedVehicles);
            Vehicle vehicle8 = new Truck(8, 3, "Scania", "R Series", "White", "2019", "TRUCK", 10, 68, "speed category", false, ListManagerObj.AllVehicles, ListManagerObj.UnassignedVehicles);


            // Initialize some test teams
            Team team1 = new Team(1, "Ferarri", ListManagerObj.Teams);
            Team team2 = new Team(2, "McLaren", ListManagerObj.Teams);
            Team team3 = new Team(3, "Mercedes", ListManagerObj.Teams);
            Team team4 = new Team(4, "Red Bull", ListManagerObj.Teams);
            Team team5 = new Team(5, "RB", ListManagerObj.Teams);
            Team team6 = new Team(6, "Aston Martin", ListManagerObj.Teams);
            Team team7 = new Team(7, "Alpine", ListManagerObj.Teams);
            Team team8 = new Team(8, "Williams", ListManagerObj.Teams);
            Team team9 = new Team(9, "Sauber", ListManagerObj.Teams);
            Team team10 = new Team(10, "Haas", ListManagerObj.Teams);


            // put cars in teams
            team1.VehiclesInTeam.Add(vehicle1);
            team1.VehiclesInTeam.Add(vehicle2);
            team1.VehiclesInTeam.Add(vehicle3);
            team2.VehiclesInTeam.Add(vehicle4);
            team2.VehiclesInTeam.Add(vehicle5);
            team3.VehiclesInTeam.Add(vehicle6);
            team4.VehiclesInTeam.Add(vehicle7);
            team5.VehiclesInTeam.Add(vehicle8);


            // Initialize some circuits
            Circuit circuit1 = new Circuit(1, "Bahrain", 57, 5.4, ListManagerObj.Circuits);
            Circuit circuit2 = new Circuit(2, "Saudi Arabian", 50, 6.2, ListManagerObj.Circuits);
            Circuit circuit3 = new Circuit(3, "Australian", 58, 5.2, ListManagerObj.Circuits);
            Circuit circuit4 = new Circuit(4, "Chinese", 56, 5.6, ListManagerObj.Circuits);
            Circuit circuit5 = new Circuit(5, "Spanish", 66, 4.7, ListManagerObj.Circuits);
            Circuit circuit6 = new Circuit(6, "Monaco", 77, 3.3, ListManagerObj.Circuits);
            Circuit circuit7 = new Circuit(7, "Canadian", 70, 4.4, ListManagerObj.Circuits);
            Circuit circuit8 = new Circuit(8, "Azerbaijan", 51, 6, ListManagerObj.Circuits);
            Circuit circuit9 = new Circuit(9, "Austrian", 71, 4.3, ListManagerObj.Circuits);
            Circuit circuit10 = new Circuit(10, "British", 52, 4.4, ListManagerObj.Circuits);
            Circuit circuit11 = new Circuit(11, "Hungarian", 70, 4.4, ListManagerObj.Circuits);
            Circuit circuit12 = new Circuit(12, "Belgian", 44, 7, ListManagerObj.Circuits);
            Circuit circuit13 = new Circuit(13, "Italian", 63, 5.8, ListManagerObj.Circuits);
            Circuit circuit14 = new Circuit(14, "Singapore", 61, 4.9, ListManagerObj.Circuits);
            Circuit circuit15 = new Circuit(15, "Japanese", 53, 5.8, ListManagerObj.Circuits);
            Circuit circuit16 = new Circuit(16, "United States", 56, 5.5, ListManagerObj.Circuits);
            Circuit circuit17 = new Circuit(17, "Mexican", 71, 4.3, ListManagerObj.Circuits);
            Circuit circuit18 = new Circuit(18, "Brazilian", 71, 4.3, ListManagerObj.Circuits);
            Circuit circuit19 = new Circuit(19, "Abu Dahabi", 58, 5.6, ListManagerObj.Circuits);
            Circuit circuit20 = new Circuit(20, "Netherlands", 72, 4.3, ListManagerObj.Circuits);
            Circuit circuit21 = new Circuit(21, "Italian (Emilia-Romagna)", 63, 5, ListManagerObj.Circuits);
            Circuit circuit22 = new Circuit(22, "Qatar", 57, 5.4, ListManagerObj.Circuits);
            Circuit circuit23 = new Circuit(23, "Miami", 57, 5.4, ListManagerObj.Circuits);
            Circuit circuit24 = new Circuit(24, "Las Vegas", 50, 6.1, ListManagerObj.Circuits);
        }


        public void UserInteractsWithMenu()
        {
            Menu = new Menu();

            int userInput;

            do
            {
                Menu.ShowMenu();
                userInput = Menu.ChooseMenuOption();

                switch (userInput)
                {
                    case 1:
                        RaceManagerObj.StartGrandPrix(ResultsManagerObj, ListManagerObj.Teams, ListManagerObj.Circuits, ListManagerObj.SeasonResults);
                        break;

                    case 2:
                        ListManagerObj.HowManyTeamsAreThere();
                        ListManagerObj.HowManyVehiclesAreThere();
                        ListManagerObj.HowManyCircuitsAreThere();
                        Console.WriteLine();
                        break;

                    case 3:
                        ListManagerObj.ShowAllVehicles();                                          
                        break;

                    case 4:
                        ListManagerObj.ShowVehiclesInEachTeam();
                        break;

                    case 5:
                        ListManagerObj.ShowAllTeams();
                        break;

                    case 6:
                        ListManagerObj.ShowAllCircuits();
                        break;

                    case 7:
                        var numberOfCircuits = ListManagerObj.HowManyCircuits();
                        CircuitManagerObj.AddCircuit(numberOfCircuits, ListManagerObj.Circuits);
                        break;

                    case 8:
                        ListManagerObj.ShowSeasonResults();
                        break;
                }
            }

            while (userInput != 9 );
        }       
    }
}
