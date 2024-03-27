using Race.Classes.Vehicles;
using Race.Objects.Teams;
using System.Runtime.Serialization;

namespace Race.Classes.Managers
{
    public class VehicleManager
    {
        // ****************************************************************
        // Properties
        // ****************************************************************
        public List<Vehicle> AllVehicles { get; set; }
        Team TeamChoice { get; set; }
        int TeamChoiceInt { get; set; }
        String ConfirmTeamChoice { get; set; }
        


        // ****************************************************************
        // Constructor
        // ****************************************************************
        public VehicleManager()
        {
            AllVehicles = new List<Vehicle>();
        }


        // ****************************************************************
        // Methods relating to Vehicles
        // ****************************************************************
        public void HowManyVehiclesAreThere()
        {
            Console.WriteLine($"  vehicles = {AllVehicles.Count}");
        }


        public void ShowAllVehicles()
        {
            int number = 1;

            Console.WriteLine($"   All Vehicles:");
            Console.WriteLine($"   ==============");

            foreach (Vehicle vehicle in AllVehicles)
            {
                Console.WriteLine($"    - Vehicle #{vehicle.VehicleID} - {vehicle.VehicleType}, {vehicle.VehicleMake}, {vehicle.VehicleModel}, {vehicle.VehicleColour}, {vehicle.VehicleYear}, {vehicle.VehicleSpeedCategory.ToUpper()}");
                number++;
            }

            Console.WriteLine();
        }


        public void AddVehicle(List<Team> teams, List<Vehicle> allVehicles)
        {
            Console.WriteLine($"  Add a Vehicle to a team");
            Console.WriteLine($"  =======================");

            int x = 0;

            while (x == 0)
            {
                TeamChoice = AskUserToChooseTeam();
                ConfirmTeamChoice = ConfirmChoiceOfTeam();
                
                Console.WriteLine("");

                switch (ConfirmTeamChoice)
                {
                    case "y":
                    case "Y":
                        
                        int i = 0;

                        Console.WriteLine($"  What type of vehicle is it?");
                        foreach (var v in Enum.GetNames(typeof(VehicleType)))
                        {
                            Console.WriteLine($"  {v} ({i+1})");
                            i++;
                        }

                        int getNewVehicleType = Convert.ToInt32(Console.ReadLine());

                        Console.Write($"  What is the make?");
                        String getNewVehicleMake = Console.ReadLine();

                        Console.Write($"  What is the model?");
                        String getNewVehicleModel = Console.ReadLine();

                        Console.Write($"  What is it's colour?");
                        String getNewVehicleColour = Console.ReadLine();

                        Console.Write($"  What year was it made?");
                        String getNewVehicleYear = Console.ReadLine();

                        Console.Write($"  What is it's speed?");
                        int getNewVehicleSpeed = Convert.ToInt32(Console.ReadLine());

                        int newVehicleTeamID = 1 + TeamChoiceInt;
                        int newVehicleType = getNewVehicleType;
                        String newVehicleMake = getNewVehicleMake;
                        String newVehicleModel = getNewVehicleModel;
                        String newVehicleColour = getNewVehicleColour;
                        String newVehicleYear = getNewVehicleYear;
                        int newVehicleSpeed = getNewVehicleSpeed;

                        if (newVehicleType == 1)
                        {
                            Vehicle vehicle1 = new Car(newVehicleTeamID, newVehicleMake, newVehicleModel, newVehicleColour, newVehicleYear, newVehicleSpeed, allVehicles);
                            Console.WriteLine();
                            Console.WriteLine($"  NEW CAR ADDED TO TEAM");
                            Thread.Sleep(500);
                        }

                        else if (newVehicleType == 2)
                        {
                            Vehicle vehicle1 = new Bike(newVehicleTeamID, newVehicleMake, newVehicleModel, newVehicleColour, newVehicleYear, newVehicleSpeed, allVehicles);
                            Console.WriteLine();
                            Console.WriteLine($"  NEW Bike ADDED TO TEAM");
                            Thread.Sleep(500);
                        }

                        else if (newVehicleType == 3)
                        {
                            Vehicle vehicle1 = new Truck(newVehicleTeamID, newVehicleMake, newVehicleModel, newVehicleColour, newVehicleYear, newVehicleSpeed, allVehicles);
                            Console.WriteLine();
                            Console.WriteLine($"  NEW TRUCK ADDED TO TEAM");
                            Thread.Sleep(500);
                        }
                        
                        Console.WriteLine();

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
                        Console.WriteLine("  invalid response, please press 'y', 'n' or 'x'");
                        Console.WriteLine();
                        continue;
                }

                Team AskUserToChooseTeam()
                {
                    TeamChoiceInt = GetChoiceOfTeam();
                    return DisplayChoiceOfTeam(TeamChoiceInt);

                    int GetChoiceOfTeam()
                    {
                        Console.WriteLine($"  Which Team do you want to choose?");
                        return Convert.ToInt32(Console.ReadLine()) - 1;
                    }

                    Team DisplayChoiceOfTeam(int userChoice)
                    {
                        Console.WriteLine();
                        Team choice = teams.ElementAt(userChoice);
                        Console.WriteLine($"  You have selected: #{choice.ID} - {choice.Name}");
                        Console.WriteLine();
                        return choice;
                    }
                }


                string ConfirmChoiceOfTeam()
                {
                    Console.WriteLine($"  Is this correct? y(yes) n(no) x(exit)");
                    return Console.ReadLine();
                }

            }
            Console.WriteLine("");
        }
    }
}
