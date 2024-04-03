using Race.Objects.Vehicles;
using Race.Objects;
using Race.Objects.Teams;

namespace Race.ObjectsManagers
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
            Console.WriteLine($"   All Vehicles:");
            Console.WriteLine($"   ==============");

            foreach (Vehicle v in AllVehicles)
            {
                if (v.IsMotorisedVehicle == true)
                {
                    Console.WriteLine($"    - Vehicle #{v.VehicleID} - {v.VehicleType}, {v.VehicleMake}, {v.VehicleModel}, {v.VehicleColour}, {v.VehicleYear}, {v.VehicleSpeedCategory.ToUpper()}, Has an engine.");

                }

                else
                {
                    Console.WriteLine($"    - Vehicle #{v.VehicleID} - {v.VehicleType}, {v.VehicleMake}, {v.VehicleModel}, {v.VehicleColour}, {v.VehicleYear}, {v.VehicleSpeedCategory.ToUpper()}");
                }
            }

            Console.WriteLine();
        }


        public void AddVehicle(List<Team> teams, List<Vehicle> allVehicles, List<MotorisedVehicle> motorisedVehicles, List<Engine> engines, List<FuelTank> fuelTanks)
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

                        int ii = 0;
                        Console.WriteLine($"  Which engine?");
                        foreach (Engine e in engines)
                        {
                            Console.WriteLine($"  {e.EngineName} ({ii + 1})");
                            ii++;
                        }

                        int getEngine = Convert.ToInt32(Console.ReadLine());


                        int iii = 0;
                        Console.WriteLine($"  Which fuel tank?");
                        foreach (FuelTank fk in fuelTanks)
                        {
                            Console.WriteLine($"  {fk.FuelTankName} ({iii + 1})");
                            iii++;
                        }

                        int getFuelTank = Convert.ToInt32(Console.ReadLine());

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
                        Engine newVehicleEngine = engines.ElementAt(ii-1);
                        FuelTank newVehicleFuelTank = fuelTanks.ElementAt(iii-1);
                        int newVehicleTeamID = 1 + TeamChoiceInt;
                        int newVehicleType = getNewVehicleType;
                        String newVehicleMake = getNewVehicleMake;
                        String newVehicleModel = getNewVehicleModel;
                        String newVehicleColour = getNewVehicleColour;
                        String newVehicleYear = getNewVehicleYear;
                        int newVehicleSpeed = getNewVehicleSpeed;

                        if (newVehicleType == 1)
                        {
                            Vehicle vehicle1 = new Car(newVehicleTeamID, newVehicleMake, newVehicleModel, newVehicleColour, newVehicleYear, newVehicleSpeed, allVehicles, motorisedVehicles, newVehicleEngine, newVehicleFuelTank);
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
                            Vehicle vehicle1 = new Truck(newVehicleTeamID, newVehicleMake, newVehicleModel, newVehicleColour, newVehicleYear, newVehicleSpeed, allVehicles, motorisedVehicles, newVehicleEngine, newVehicleFuelTank);
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
