using System;
using System.Collections.Generic;

namespace Race
{
    public class RaceManager
    {
        // ****************************************************************
        // Fields
        // ****************************************************************       
        public Menu menu { get; set; }


        // ****************************************************************
        // Properties
        // ****************************************************************


        // ****************************************************************
        // Constructor
        // ****************************************************************
        public RaceManager()
        {
            Initialise();
            UserInteractsWithMenu();
        }


        // ****************************************************************
        // Methods
        // ****************************************************************
        public void Initialise()
        {
            // Initialize some test vehicles
            Vehicle vehicle1 = new Car(0, "Ford", "Focus", "Black", "2013", "CAR", 4, 86, "test");
            Vehicle vehicle2 = new Car(0, "Volvo", "V40", "White", "2024", "car", 4, 79, "test");
            Vehicle vehicle3 = new Car(0, "Audi", "A5", "Grey", "2012", "car", 4, 110, "test");
            Vehicle vehicle4 = new Car(0, "Toyota", "Corolla", "Black", "2023", "CAR", 4, 92, "test");
            Vehicle vehicle5 = new Bike(0, "Canyon", "Strive", "Black", "2015", "BIKE", 4, 27, "test");
            Vehicle vehicle6 = new Bike(0, "Marin", "Nail Trail", "Silver", "2003", "BIKE", 4, 18, "test");
            Vehicle vehicle7 = new Truck(0, "Volvo", "FH", "White", "2018", "TRUCK", 10, 71, "test");
            Vehicle vehicle8 = new Truck(0, "Scania", "R Series", "White", "2019", "TRUCK", 10, 68, "test");


            // Initialize some test teams
            Team team1 = new Team("Ferarri");
            Team team2 = new Team("McLaren");
            Team team3 = new Team("Mercedes");
            Team team4 = new Team("Red Bull");
            Team team5 = new Team("RB");
            Team team6 = new Team("Aston Martin");
            Team team7 = new Team("Alpine");
            Team team8 = new Team("Williams");
            Team team9 = new Team("Sauber");
            Team team10 = new Team("Haas");


            // Add some vehicles to a team
            team2.vehiclesInTeam.Add(vehicle3);
            Vehicle.unassignedVehicles.Remove(vehicle3);
            team2.vehiclesInTeam.Add(vehicle5);
            Vehicle.unassignedVehicles.Remove(vehicle5);
            team2.vehiclesInTeam.Add(vehicle8);
            Vehicle.unassignedVehicles.Remove(vehicle8);


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
                        break;

                    case 2:
                        break;

                    case 3:
                        break;

                    case 4:
                        StartAllVehicles();
                        break;

                    case 5:
                        StopAllVehicles();
                        break;

                    case 6:
                        break;

                    case 7:
                        break;

                    case 13:
                        HowManyTeamsAreThere();
                        HowManyVehiclesAreThere();
                        HowManyCircuitsAreThere();
                        Console.WriteLine();
                        break;

                    case 14:
                        ShowAllVehicles();                                          
                        break;

                    case 15:
                        ShowVehiclesInEachTeam();
                        break;

                    case 16:
                        ShowVehiclesNotAssignedToAnyTeam();
                        break;

                    case 17:
                        ShowAllTeams();
                        break;

                    case 18:
                        ShowAllCircuits();
                        break;
                }
            }

            while (userInput != 21);
        }


        ////////////////////////////////////////////////////////
        // Methods relating to Vehicles
        ////////////////////////////////////////////////////////
        public void HowManyVehiclesAreThere()
        {
            Console.WriteLine($"vehicles = {Vehicle.NumberOfVehicles}");
        }

        
        public void ShowAllVehicles()
        {
            int number = 1;

            Console.WriteLine($"Every vehicle:");
            Console.WriteLine($"==============");

            foreach (Vehicle vehicle in Vehicle.allVehicles)
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

            foreach (Vehicle vehicle in Vehicle.unassignedVehicles)
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
            Console.WriteLine($"Teams = {Team.NumberOfTeams}");
        }


        public void ShowAllTeams()
        {
            int number = 1;
            Console.WriteLine($"The teams are:");
            foreach (Team team in Team.teams)
            {
                Console.WriteLine($"- {team.Name}");
                number++;
            }

            Console.WriteLine();
        }


        public void ShowVehiclesInEachTeam()
        {
            Console.WriteLine("Vehicles per team:");
            Console.WriteLine($"=================");

            foreach (Team team in Team.teams)
            {
                Console.WriteLine($"     - {team.Name}");

                foreach (Vehicle vehicle in team.vehiclesInTeam)
                {
                    Console.WriteLine($"\tVehicle #{vehicle.ID} - {vehicle.Type.ToUpper()}, {vehicle.Make}, {vehicle.Model}, {vehicle.Colour}, {vehicle.Year}, {vehicle.SpeedCategory.ToUpper()}");
                }
            }

            Console.WriteLine();
        }


        public void StartAllVehicles()
        {
            Console.WriteLine("Start Vehicles:");
            Console.WriteLine($"=================");

            foreach (Team team in Team.teams)
            {

                foreach (Vehicle vehicle in team.vehiclesInTeam)
                {
                    vehicle.StartMoving();
                }
            }

            Console.WriteLine();
        }


        public void StopAllVehicles()
        {
            Console.WriteLine("Stop Vehicles:");
            Console.WriteLine($"=================");

            foreach (Team team in Team.teams)
            {

                foreach (Vehicle vehicle in team.vehiclesInTeam)
                {
                    vehicle.StopMoving();
                }
            }

            Console.WriteLine();
        }


        ////////////////////////////////////////////////////////
        // Methods relating to Circuits
        ////////////////////////////////////////////////////////
        public void HowManyCircuitsAreThere()
        {
            Console.WriteLine($"Circuits = {Circuit.NumberOfCircuits}");
        }


        public void ShowAllCircuits()
        {
            foreach(Circuit circuit in Circuit.circuits)
            {
                double totalCircuitLengthKm = circuit.LapLengthKm * circuit.NumberOfLaps;
                Console.WriteLine($"- #{circuit.ID}, {circuit.Name}, {circuit.NumberOfLaps} laps, 1xlap ={circuit.LapLengthKm}km, TOTAL LENGTH = {Math.Round(totalCircuitLengthKm, 1)}km");
            }

            Console.WriteLine();
        }


    }
}
