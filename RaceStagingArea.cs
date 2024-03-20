using Race.Classes.Circuits;
using Race.Classes.Managers;
using Race.Classes.Teams;
using Race.Classes.Vehicles;
using Race.Users;

namespace Race
{
    public class RaceStagingArea
    {
        // ****************************************************************
        // Properties
        // ****************************************************************
        RaceDirector RaceDirectorObj { get; set; }
        Menu Menu { get; set; }
        VehicleManager VehicleManagerObj { get; set; }
        TeamManager TeamManagerObj { get; set; }
        CircuitManager CircuitManagerObj { get; set; }
        ResultManager ResultManagerObj { get; set; }


        // ****************************************************************
        // Constructor
        // ****************************************************************
        public RaceStagingArea()
        {
            Initialise();
            UserInteractsWithMenu();
        }


        // ****************************************************************
        // Methods
        // ****************************************************************
        public void Initialise()
        {
            // Initialize objects of various 'controller' classes 
            RaceDirectorObj = new RaceDirector();
            VehicleManagerObj = new VehicleManager();
            TeamManagerObj = new TeamManager();
            CircuitManagerObj = new CircuitManager();            
            ResultManagerObj = new ResultManager();


            // Initialize some test vehicles
            Vehicle vehicle1 = new Car(1, 1, "Ford", "Focus", "Black", "2013", "CAR", 4, 86, "speed category", false, VehicleManagerObj.AllVehicles, VehicleManagerObj.UnassignedVehicles);
            Vehicle vehicle2 = new Car(2, 1, "Volvo", "V40", "White", "2024", "car", 4, 79, "speed category", false, VehicleManagerObj.AllVehicles, VehicleManagerObj.UnassignedVehicles);
            Vehicle vehicle3 = new Car(3, 1, "Audi", "A5", "Grey", "2012", "car", 4, 110, "speed category", false, VehicleManagerObj.AllVehicles, VehicleManagerObj.UnassignedVehicles);
            Vehicle vehicle4 = new Car(4, 2, "Toyota", "Corolla", "Black", "2023", "CAR", 4, 92, "speed category", false, VehicleManagerObj.AllVehicles, VehicleManagerObj.UnassignedVehicles);
            Vehicle vehicle5 = new Car(5, 2, "Fiat", "500", "Black", "2013", "CAR", 4, 86, "speed category", false, VehicleManagerObj.AllVehicles, VehicleManagerObj.UnassignedVehicles);
            Vehicle vehicle6 = new Car(6, 2, "Renault", "Clio", "White", "2024", "car", 4, 79, "speed category", false, VehicleManagerObj.AllVehicles, VehicleManagerObj.UnassignedVehicles);
            Vehicle vehicle7 = new Car(7, 3, "Honda", "Civic", "Black", "2013", "CAR", 4, 86, "speed category", false, VehicleManagerObj.AllVehicles, VehicleManagerObj.UnassignedVehicles);
            Vehicle vehicle8 = new Car(8, 3, "Seat", "Ibiza", "White", "2024", "car", 4, 79, "speed category", false, VehicleManagerObj.AllVehicles, VehicleManagerObj.UnassignedVehicles);
            Vehicle vehicle9 = new Car(9, 3, "BMW", "320", "Black", "2013", "CAR", 4, 86, "speed category", false, VehicleManagerObj.AllVehicles, VehicleManagerObj.UnassignedVehicles);
            Vehicle vehicle10 = new Car(10, 4, "Volvo", "V40", "White", "2024", "car", 4, 79, "speed category", false, VehicleManagerObj.AllVehicles, VehicleManagerObj.UnassignedVehicles);
            Vehicle vehicle11 = new Bike(11, 4, "Canyon", "Strive", "Black", "2015", "BIKE", 2, 27, "speed category", false, VehicleManagerObj.AllVehicles, VehicleManagerObj.UnassignedVehicles);
            Vehicle vehicle12 = new Bike(12, 4,"Marin", "Nail Trail", "Silver", "2003", "BIKE", 2, 18, "speed category", false, VehicleManagerObj.AllVehicles, VehicleManagerObj.UnassignedVehicles);
            Vehicle vehicle13 = new Bike(13, 5, "Specialized", "Strive", "Black", "2015", "BIKE", 2, 27, "speed category", false, VehicleManagerObj.AllVehicles, VehicleManagerObj.UnassignedVehicles);
            Vehicle vehicle14 = new Bike(14, 5, "Giant", "Nail Trail", "Silver", "2003", "BIKE", 2, 18, "speed category", false, VehicleManagerObj.AllVehicles, VehicleManagerObj.UnassignedVehicles);
            Vehicle vehicle15 = new Bike(15, 5, "Planet X", "Strive", "Black", "2015", "BIKE", 2, 27, "speed category", false, VehicleManagerObj.AllVehicles, VehicleManagerObj.UnassignedVehicles);
            Vehicle vehicle16 = new Bike(16, 6, "Marin", "Nail Trail", "Silver", "2003", "BIKE", 2, 18, "speed category", false, VehicleManagerObj.AllVehicles, VehicleManagerObj.UnassignedVehicles);
            Vehicle vehicle17 = new Bike(17, 6, "Canyon", "Strive", "Black", "2015", "BIKE", 2, 27, "speed category", false, VehicleManagerObj.AllVehicles, VehicleManagerObj.UnassignedVehicles);
            Vehicle vehicle18 = new Bike(18, 6, "Raleigh", "Nail Trail", "Silver", "2003", "BIKE", 2, 18, "speed category", false, VehicleManagerObj.AllVehicles, VehicleManagerObj.UnassignedVehicles);
            Vehicle vehicle19 = new Bike(19, 7, "Boardman", "Strive", "Black", "2015", "BIKE", 2, 27, "speed category", false, VehicleManagerObj.AllVehicles, VehicleManagerObj.UnassignedVehicles);
            Vehicle vehicle20 = new Bike(20, 7, "Norco", "Nail Trail", "Silver", "2003", "BIKE", 2, 18, "speed category", false, VehicleManagerObj.AllVehicles, VehicleManagerObj.UnassignedVehicles);
            Vehicle vehicle21 = new Truck(21, 7, "Volvo", "FH", "White", "2018", "TRUCK", 10, 71, "speed category", false, VehicleManagerObj.AllVehicles, VehicleManagerObj.UnassignedVehicles);
            Vehicle vehicle22 = new Truck(22, 8, "Scania", "R Series", "White", "2019", "TRUCK", 10, 68, "speed category", false, VehicleManagerObj.AllVehicles, VehicleManagerObj.UnassignedVehicles);
            Vehicle vehicle23 = new Truck(23, 8, "Leyland", "FH", "White", "2018", "TRUCK", 10, 71, "speed category", false, VehicleManagerObj.AllVehicles, VehicleManagerObj.UnassignedVehicles);
            Vehicle vehicle24 = new Truck(24, 8, "Scania", "R Series", "White", "2019", "TRUCK", 10, 68, "speed category", false, VehicleManagerObj.AllVehicles, VehicleManagerObj.UnassignedVehicles);
            Vehicle vehicle25 = new Truck(25, 9, "DAF", "FH", "White", "2018", "TRUCK", 10, 71, "speed category", false, VehicleManagerObj.AllVehicles, VehicleManagerObj.UnassignedVehicles);
            Vehicle vehicle26 = new Truck(26, 9, "Iveco", "R Series", "White", "2019", "TRUCK", 10, 68, "speed category", false, VehicleManagerObj.AllVehicles, VehicleManagerObj.UnassignedVehicles);
            Vehicle vehicle27 = new Truck(27, 9, "Volvo", "FH", "White", "2018", "TRUCK", 10, 71, "speed category", false, VehicleManagerObj.AllVehicles, VehicleManagerObj.UnassignedVehicles);
            Vehicle vehicle28 = new Truck(28, 10, "Scania", "R Series", "White", "2019", "TRUCK", 10, 68, "speed category", false, VehicleManagerObj.AllVehicles, VehicleManagerObj.UnassignedVehicles);
            Vehicle vehicle29 = new Truck(29, 10, "Volvo", "FH", "White", "2018", "TRUCK", 10, 71, "speed category", false, VehicleManagerObj.AllVehicles, VehicleManagerObj.UnassignedVehicles);
            Vehicle vehicle30 = new Truck(30, 10, "Scania", "R Series", "White", "2019", "TRUCK", 10, 68, "speed category", false, VehicleManagerObj.AllVehicles, VehicleManagerObj.UnassignedVehicles);


            // Initialize some test teams
            Team team1 = new Team(1, "Ferarri", TeamManagerObj.Teams);
            Team team2 = new Team(2, "McLaren", TeamManagerObj.Teams);
            Team team3 = new Team(3, "Mercedes", TeamManagerObj.Teams);
            Team team4 = new Team(4, "Red Bull", TeamManagerObj.Teams);
            Team team5 = new Team(5, "RB", TeamManagerObj.Teams);
            Team team6 = new Team(6, "Aston Martin", TeamManagerObj.Teams);
            Team team7 = new Team(7, "Alpine", TeamManagerObj.Teams);
            Team team8 = new Team(8, "Williams", TeamManagerObj.Teams);
            Team team9 = new Team(9, "Sauber", TeamManagerObj.Teams);
            Team team10 = new Team(10, "Haas", TeamManagerObj.Teams);


            // put cars in teams
            team1.VehiclesInTeam.Add(vehicle1);
            team1.VehiclesInTeam.Add(vehicle2);
            team1.VehiclesInTeam.Add(vehicle3);
            team2.VehiclesInTeam.Add(vehicle4);
            team2.VehiclesInTeam.Add(vehicle5);
            team2.VehiclesInTeam.Add(vehicle6);
            team3.VehiclesInTeam.Add(vehicle7);
            team3.VehiclesInTeam.Add(vehicle8);
            team3.VehiclesInTeam.Add(vehicle9);
            team4.VehiclesInTeam.Add(vehicle10);
            team4.VehiclesInTeam.Add(vehicle11);
            team4.VehiclesInTeam.Add(vehicle12);
            team5.VehiclesInTeam.Add(vehicle13);
            team5.VehiclesInTeam.Add(vehicle14);
            team5.VehiclesInTeam.Add(vehicle15);
            team6.VehiclesInTeam.Add(vehicle16);
            team6.VehiclesInTeam.Add(vehicle17);
            team6.VehiclesInTeam.Add(vehicle18);
            team7.VehiclesInTeam.Add(vehicle19);
            team7.VehiclesInTeam.Add(vehicle20);
            team7.VehiclesInTeam.Add(vehicle21);
            team8.VehiclesInTeam.Add(vehicle22);
            team8.VehiclesInTeam.Add(vehicle23);
            team8.VehiclesInTeam.Add(vehicle24);
            team9.VehiclesInTeam.Add(vehicle25);
            team9.VehiclesInTeam.Add(vehicle26);
            team9.VehiclesInTeam.Add(vehicle27);
            team10.VehiclesInTeam.Add(vehicle28);
            team10.VehiclesInTeam.Add(vehicle29);
            team10.VehiclesInTeam.Add(vehicle30);


            // Initialize some circuits
            Circuit circuit1 = new Circuit(1, "Bahrain", 57, 5.4, CircuitManagerObj.Circuits);
            Circuit circuit2 = new Circuit(2, "Saudi Arabian", 50, 6.2, CircuitManagerObj.Circuits);
            Circuit circuit3 = new Circuit(3, "Australian", 58, 5.2, CircuitManagerObj.Circuits);
            Circuit circuit4 = new Circuit(4, "Chinese", 56, 5.6, CircuitManagerObj.Circuits);
            Circuit circuit5 = new Circuit(5, "Spanish", 66, 4.7, CircuitManagerObj.Circuits);
            Circuit circuit6 = new Circuit(6, "Monaco", 77, 3.3, CircuitManagerObj.Circuits);
            Circuit circuit7 = new Circuit(7, "Canadian", 70, 4.4, CircuitManagerObj.Circuits);
            Circuit circuit8 = new Circuit(8, "Azerbaijan", 51, 6, CircuitManagerObj.Circuits);
            Circuit circuit9 = new Circuit(9, "Austrian", 71, 4.3, CircuitManagerObj.Circuits);
            Circuit circuit10 = new Circuit(10, "British", 52, 4.4, CircuitManagerObj.Circuits);
            Circuit circuit11 = new Circuit(11, "Hungarian", 70, 4.4, CircuitManagerObj.Circuits);
            Circuit circuit12 = new Circuit(12, "Belgian", 44, 7, CircuitManagerObj.Circuits);
            Circuit circuit13 = new Circuit(13, "Italian", 63, 5.8, CircuitManagerObj.Circuits);
            Circuit circuit14 = new Circuit(14, "Singapore", 61, 4.9, CircuitManagerObj.Circuits);
            Circuit circuit15 = new Circuit(15, "Japanese", 53, 5.8, CircuitManagerObj.Circuits);
            Circuit circuit16 = new Circuit(16, "United States", 56, 5.5, CircuitManagerObj.Circuits);
            Circuit circuit17 = new Circuit(17, "Mexican", 71, 4.3, CircuitManagerObj.Circuits);
            Circuit circuit18 = new Circuit(18, "Brazilian", 71, 4.3, CircuitManagerObj.Circuits);
            Circuit circuit19 = new Circuit(19, "Abu Dahabi", 58, 5.6, CircuitManagerObj.Circuits);
            Circuit circuit20 = new Circuit(20, "Netherlands", 72, 4.3, CircuitManagerObj.Circuits);
            Circuit circuit21 = new Circuit(21, "Italian (Emilia-Romagna)", 63, 5, CircuitManagerObj.Circuits);
            Circuit circuit22 = new Circuit(22, "Qatar", 57, 5.4, CircuitManagerObj.Circuits);
            Circuit circuit23 = new Circuit(23, "Miami", 57, 5.4, CircuitManagerObj.Circuits);
            Circuit circuit24 = new Circuit(24, "Las Vegas", 50, 6.1, CircuitManagerObj.Circuits);
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
                        RaceDirectorObj.StartGrandPrix(ResultManagerObj, TeamManagerObj.Teams, CircuitManagerObj.Circuits, ResultManagerObj.SeasonResults);
                        break;

                    case 2:
                        TeamManagerObj.HowManyTeamsAreThere();
                        VehicleManagerObj.HowManyVehiclesAreThere();
                        CircuitManagerObj.HowManyCircuitsAreThere();
                        Console.WriteLine();
                        break;

                    case 3:
                        VehicleManagerObj.ShowAllVehicles();                                          
                        break;

                    case 4:
                        TeamManagerObj.ShowVehiclesInEachTeam();
                        break;

                    case 5:
                        TeamManagerObj.ShowAllTeams();
                        break;

                    case 6:
                        CircuitManagerObj.ShowAllCircuits();
                        break;

                    case 7:
                        var numberOfCircuits = CircuitManagerObj.HowManyCircuits();
                        CircuitManagerObj.AddCircuit(numberOfCircuits, CircuitManagerObj.Circuits);
                        break;

                    case 8:
                        ResultManagerObj.ShowSeasonResults();
                        break;
                }
            }

            while (userInput != 9 );
        }       
    }
}
