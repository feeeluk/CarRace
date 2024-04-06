using Race.ObjectsManagers;
using Race.Objects.Vehicles;
using Race.Objects.Menus;
using Race.Users;
using Race.Objects.Teams;
using Race.Objects.Circuits;

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
        MotorisedVehicleManager MotorisedVehicleManagerObj {  get; set; }
        EngineManager EngineManagerObj { get; set; }
        FuelTankManager FuelTankManagerObj { get; set; }


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
            MotorisedVehicleManagerObj = new MotorisedVehicleManager();
            EngineManagerObj = new EngineManager();
            FuelTankManagerObj = new FuelTankManager();

            // Initialize Engines
            Engine engine1 = new Engine(EngineManagerObj.Engines, "Large", "Diesel");
            Engine engine2 = new Engine(EngineManagerObj.Engines, "Small", "Petrol");


            // Initialize fuel tanks
            FuelTank fuelTank1 = new FuelTank(FuelTankManagerObj.FuelTanks, "Large", 100);
            FuelTank fuelTank2 = new FuelTank(FuelTankManagerObj.FuelTanks, "Small", 50);


            // Initialize teams
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


            // Initialize vehicles
            Vehicle vehicle1 = new Car(TeamManagerObj.Teams.ElementAt(0), "Ford", "Focus", "Black", "2013", 84, VehicleManagerObj.AllVehicles, MotorisedVehicleManagerObj.MotorisedVehicles, EngineManagerObj.Engines.ElementAt(0), FuelTankManagerObj.FuelTanks.ElementAt(0));
            Vehicle vehicle2 = new Car(TeamManagerObj.Teams.ElementAt(0), "Volvo", "V40", "White", "2024", 83, VehicleManagerObj.AllVehicles, MotorisedVehicleManagerObj.MotorisedVehicles, EngineManagerObj.Engines.ElementAt(0), FuelTankManagerObj.FuelTanks.ElementAt(0));
            Vehicle vehicle3 = new Car(TeamManagerObj.Teams.ElementAt(0), "Audi", "A5", "Grey", "2012", 85, VehicleManagerObj.AllVehicles, MotorisedVehicleManagerObj.MotorisedVehicles, EngineManagerObj.Engines.ElementAt(0), FuelTankManagerObj.FuelTanks.ElementAt(0));
            Vehicle vehicle4 = new Car(TeamManagerObj.Teams.ElementAt(1), "Toyota", "Corolla", "Black", "2023", 84, VehicleManagerObj.AllVehicles, MotorisedVehicleManagerObj.MotorisedVehicles, EngineManagerObj.Engines.ElementAt(0), FuelTankManagerObj.FuelTanks.ElementAt(0));
            Vehicle vehicle5 = new Car(TeamManagerObj.Teams.ElementAt(1), "Fiat", "500", "Black", "2013", 81, VehicleManagerObj.AllVehicles, MotorisedVehicleManagerObj.MotorisedVehicles, EngineManagerObj.Engines.ElementAt(0), FuelTankManagerObj.FuelTanks.ElementAt(0));
            Vehicle vehicle6 = new Car(TeamManagerObj.Teams.ElementAt(1), "Renault", "Clio", "White", "2024", 82, VehicleManagerObj.AllVehicles, MotorisedVehicleManagerObj.MotorisedVehicles, EngineManagerObj.Engines.ElementAt(0), FuelTankManagerObj.FuelTanks.ElementAt(0));
            Vehicle vehicle7 = new Car(TeamManagerObj.Teams.ElementAt(2), "Honda", "Civic", "Black", "2013", 83, VehicleManagerObj.AllVehicles, MotorisedVehicleManagerObj.MotorisedVehicles, EngineManagerObj.Engines.ElementAt(0), FuelTankManagerObj.FuelTanks.ElementAt(0));
            Vehicle vehicle8 = new Car(TeamManagerObj.Teams.ElementAt(2), "Seat", "Ibiza", "White", "2024", 80, VehicleManagerObj.AllVehicles, MotorisedVehicleManagerObj.MotorisedVehicles, EngineManagerObj.Engines.ElementAt(0), FuelTankManagerObj.FuelTanks.ElementAt(0));
            Vehicle vehicle9 = new Car(TeamManagerObj.Teams.ElementAt(2), "BMW", "320", "Black", "2013", 85, VehicleManagerObj.AllVehicles, MotorisedVehicleManagerObj.MotorisedVehicles, EngineManagerObj.Engines.ElementAt(0), FuelTankManagerObj.FuelTanks.ElementAt(0));
            Vehicle vehicle10 = new Car(TeamManagerObj.Teams.ElementAt(3), "Volvo", "V40", "White", "2024", 83, VehicleManagerObj.AllVehicles, MotorisedVehicleManagerObj.MotorisedVehicles, EngineManagerObj.Engines.ElementAt(0), FuelTankManagerObj.FuelTanks.ElementAt(0));
            Vehicle vehicle11 = new Bike(TeamManagerObj.Teams.ElementAt(3), "Canyon", "Strive", "Black", "2015", 27, VehicleManagerObj.AllVehicles);
            Vehicle vehicle12 = new Bike(TeamManagerObj.Teams.ElementAt(3), "Marin", "Nail Trail", "Silver", "2003", 18, VehicleManagerObj.AllVehicles);
            Vehicle vehicle13 = new Bike(TeamManagerObj.Teams.ElementAt(4), "Specialized", "Strive", "Black", "2015", 27, VehicleManagerObj.AllVehicles);
            Vehicle vehicle14 = new Bike(TeamManagerObj.Teams.ElementAt(4), "Giant", "Nail Trail", "Silver", "2003", 18, VehicleManagerObj.AllVehicles);
            Vehicle vehicle15 = new Bike(TeamManagerObj.Teams.ElementAt(4), "Planet X", "Strive", "Black", "2015", 27, VehicleManagerObj.AllVehicles);
            Vehicle vehicle16 = new Bike(TeamManagerObj.Teams.ElementAt(5), "Marin", "Nail Trail", "Silver", "2003", 18, VehicleManagerObj.AllVehicles);
            Vehicle vehicle17 = new Bike(TeamManagerObj.Teams.ElementAt(5), "Canyon", "Strive", "Black", "2015", 27, VehicleManagerObj.AllVehicles);
            Vehicle vehicle18 = new Bike(TeamManagerObj.Teams.ElementAt(5), "Raleigh", "Nail Trail", "Silver", "2003", 18, VehicleManagerObj.AllVehicles);
            Vehicle vehicle19 = new Bike(TeamManagerObj.Teams.ElementAt(6), "Boardman", "Strive", "Black", "2015", 27, VehicleManagerObj.AllVehicles);
            Vehicle vehicle20 = new Bike(TeamManagerObj.Teams.ElementAt(6), "Norco", "Nail Trail", "Silver", "2003", 18, VehicleManagerObj.AllVehicles);
            Vehicle vehicle21 = new Truck(TeamManagerObj.Teams.ElementAt(6), "Volvo", "FH", "White", "2018", 71, VehicleManagerObj.AllVehicles, MotorisedVehicleManagerObj.MotorisedVehicles, EngineManagerObj.Engines.ElementAt(0), FuelTankManagerObj.FuelTanks.ElementAt(0));
            Vehicle vehicle22 = new Truck(TeamManagerObj.Teams.ElementAt(7), "Scania", "R Series", "White", "2019", 68, VehicleManagerObj.AllVehicles, MotorisedVehicleManagerObj.MotorisedVehicles, EngineManagerObj.Engines.ElementAt(0), FuelTankManagerObj.FuelTanks.ElementAt(0));
            Vehicle vehicle23 = new Truck(TeamManagerObj.Teams.ElementAt(7), "Leyland", "FH", "White", "2018", 71, VehicleManagerObj.AllVehicles, MotorisedVehicleManagerObj.MotorisedVehicles, EngineManagerObj.Engines.ElementAt(0), FuelTankManagerObj.FuelTanks.ElementAt(0));
            Vehicle vehicle24 = new Truck(TeamManagerObj.Teams.ElementAt(7), "Scania", "R Series", "White", "2019", 68, VehicleManagerObj.AllVehicles, MotorisedVehicleManagerObj.MotorisedVehicles, EngineManagerObj.Engines.ElementAt(0), FuelTankManagerObj.FuelTanks.ElementAt(0));
            Vehicle vehicle25 = new Truck(TeamManagerObj.Teams.ElementAt(8), "DAF", "FH", "White", "2018", 71, VehicleManagerObj.AllVehicles, MotorisedVehicleManagerObj.MotorisedVehicles, EngineManagerObj.Engines.ElementAt(0), FuelTankManagerObj.FuelTanks.ElementAt(0));
            Vehicle vehicle26 = new Truck(TeamManagerObj.Teams.ElementAt(8), "Iveco", "R Series", "White", "2017", 68, VehicleManagerObj.AllVehicles, MotorisedVehicleManagerObj.MotorisedVehicles, EngineManagerObj.Engines.ElementAt(0), FuelTankManagerObj.FuelTanks.ElementAt(0));
            Vehicle vehicle27 = new Truck(TeamManagerObj.Teams.ElementAt(8), "Volvo", "FH", "White", "2018", 71, VehicleManagerObj.AllVehicles, MotorisedVehicleManagerObj.MotorisedVehicles, EngineManagerObj.Engines.ElementAt(0), FuelTankManagerObj.FuelTanks.ElementAt(0));
            Vehicle vehicle28 = new Truck(TeamManagerObj.Teams.ElementAt(9), "Scania", "R Series", "White", "2017", 68, VehicleManagerObj.AllVehicles, MotorisedVehicleManagerObj.MotorisedVehicles, EngineManagerObj.Engines.ElementAt(0), FuelTankManagerObj.FuelTanks.ElementAt(0));
            Vehicle vehicle29 = new Truck(TeamManagerObj.Teams.ElementAt(9), "Volvo", "FH", "White", "2018", 71, VehicleManagerObj.AllVehicles, MotorisedVehicleManagerObj.MotorisedVehicles, EngineManagerObj.Engines.ElementAt(0), FuelTankManagerObj.FuelTanks.ElementAt(0));
            Vehicle vehicle30 = new Truck(TeamManagerObj.Teams.ElementAt(9), "Scania", "R Series", "White", "2017", 68, VehicleManagerObj.AllVehicles, MotorisedVehicleManagerObj.MotorisedVehicles, EngineManagerObj.Engines.ElementAt(0), FuelTankManagerObj.FuelTanks.ElementAt(0));


            // Initialize circuits
            Circuit circuit1 = new Circuit(1, "Bahrain", 57, 5.4, CircuitManagerObj.Circuits);
            Circuit circuit2 = new Circuit(2, "Saudi Arabian", 50, 6.2, CircuitManagerObj.Circuits);
            Circuit circuit3 = new Circuit(3, "Australian", 58, 5.2, CircuitManagerObj.Circuits);
            Circuit circuit4 = new Circuit(4, "Japanese", 53, 5.8, CircuitManagerObj.Circuits);
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
            Circuit circuit15 = new Circuit(15, "Chinese", 56, 5.6, CircuitManagerObj.Circuits);
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
                        RaceDirectorObj.StartGrandPrix(ResultManagerObj, VehicleManagerObj.AllVehicles, TeamManagerObj.Teams, CircuitManagerObj.Circuits, ResultManagerObj.SeasonResults);
                        break;

                    case 2:
                        Console.WriteLine($"  Show statistics");
                        Console.WriteLine($"  ===============");
                        TeamManagerObj.HowManyTeamsAreThere();
                        VehicleManagerObj.HowManyVehiclesAreThere();
                        CircuitManagerObj.HowManyCircuitsAreThere();
                        ResultManagerObj.HowManyRacesHaveThereBeen();

                        Console.WriteLine();
                        break;

                    case 3:
                        VehicleManagerObj.ShowAllVehicles(MotorisedVehicleManagerObj.MotorisedVehicles);                                          
                        break;

                    case 4:
                        TeamManagerObj.ShowVehiclesInEachTeam(VehicleManagerObj.AllVehicles, MotorisedVehicleManagerObj.MotorisedVehicles);
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

                    case 9:
                        ResultManagerObj.ShowVehicleLeaderboard();
                        break;

                    case 10:
                        ResultManagerObj.ShowConstructorLeaderboard();
                        break;

                    case 11:
                        VehicleManagerObj.AddVehicle(TeamManagerObj.Teams, VehicleManagerObj.AllVehicles, MotorisedVehicleManagerObj.MotorisedVehicles, EngineManagerObj.Engines, FuelTankManagerObj.FuelTanks);
                        break;
                }
            }

            while (userInput != 12);
        }       
    }
}
