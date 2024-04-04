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
        Team ChosenTeam { get; set; }
        int teamChoiceInt { get; set; }
        String IsChoiceCorrect { get; set; }
        


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


        public void ShowAllVehicles(List<MotorisedVehicle> motorisedVehicles)
        {
            Console.WriteLine($"  All Vehicles:");
            Console.WriteLine($"  ==============");
            int i = 1;
            foreach (Vehicle v in AllVehicles)
            {
                if (v.IsMotorisedVehicle == true)
                {
                    MotorisedVehicle mv = motorisedVehicles.Find(x => x.VehicleID == i);
                    Console.WriteLine($"    - Vehicle #{mv.VehicleID} - {mv.VehicleType}," +
                        $"{mv.VehicleMake}, {mv.VehicleModel}, {mv.VehicleColour}, {mv.VehicleYear}, " +
                        $"{mv.VehicleSpeedCategory}, " +
                        $"Engine(ID:{mv.MotorisedVehicleEngine.EngineID}, {mv.MotorisedVehicleEngine.EngineName}, {mv.MotorisedVehicleEngine.EngineFuelType}), " +
                        $"Fuel Tank(ID:{mv.MotorisedVehicleFuelTank.FuelTankID}, {mv.MotorisedVehicleFuelTank.FuelTankName}, {mv.MotorisedVehicleFuelTank.FuelTankSize} ltrs)");
                }

                else
                {
                    Console.WriteLine($"    - Vehicle #{v.VehicleID} - {v.VehicleType}, " +
                        $"{v.VehicleMake}, {v.VehicleModel}, {v.VehicleColour}, {v.VehicleYear}, " +
                        $"{v.VehicleSpeedCategory}");
                }
                i++;
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
                ChosenTeam = UserChoosesTeam();
                IsChoiceCorrect = UserConfirmsChosenTeam();

                Console.WriteLine("");

                switch (IsChoiceCorrect)
                {
                    case "y":
                    case "Y":

                        Add();

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
                        Console.WriteLine("  Invalid response! 'y', 'n' or 'x'");
                        Console.WriteLine();
                        continue;
                }


                Team UserChoosesTeam()
                {
                    Console.WriteLine($"  Which Team do you want to choose?");
                    teamChoiceInt = Convert.ToInt32(Console.ReadLine()) - 1;

                    return DisplayChosenTeam(teamChoiceInt);
                }


                Team DisplayChosenTeam(int userChoice)
                {
                    Console.WriteLine();
                    Team choice = teams.ElementAt(userChoice);
                    Console.WriteLine($"  You have selected: #{choice.ID} - {choice.Name}");
                    Console.WriteLine();
                    return choice;
                }


                String UserConfirmsChosenTeam()
                {
                    Console.WriteLine($"  Is this correct? y(yes) n(no) x(exit)");
                    return Console.ReadLine();
                }


                String WhatMake()
                {
                    Console.Write($"  What is the make?");
                    return Console.ReadLine();
                }


                String WhatModel()
                {
                    Console.Write($"  What is the model?");
                    return Console.ReadLine();
                }


                String WhatColour()
                {
                    Console.Write($"  What is it's colour?");
                    return Console.ReadLine();
                }


                String WhatYear()
                {
                    Console.Write($"  What year was it made?");
                    return Console.ReadLine();
                }


                int WhatSpeed()
                {
                    Console.Write($"  What is it's speed?");
                    return Convert.ToInt32(Console.ReadLine());
                }


                bool IsItMotorised()
                {
                    Console.Write($"  Is it motorised? y / n:");

                    String isItMotorised = Console.ReadLine();

                    switch (isItMotorised)
                    {
                        case "y":
                        case "Y":
                            break;

                        case "n":
                        case "N":
                            return false;
                    }

                    return true;
                }


                int WhichTypeOfVehicle(bool isMotorised)
                {
                    List<VehicleType> list = AllVehicles.Where(x => x.IsMotorisedVehicle == isMotorised).Select(x => x.VehicleType).Distinct().ToList();
                    int i = 1;
                    Console.WriteLine("  What type of vehicle is it? ");
                    foreach (VehicleType v in list)
                    {
                        Console.WriteLine($"    {v} ({i})");
                        i++;
                    }

                    return Convert.ToInt32(Console.ReadLine());
                }
                
                
                Engine WhichEngine()
                {
                    int i = 0;
                    Console.WriteLine($"  Which engine? ");
                    foreach (Engine e in engines)
                    {
                        Console.WriteLine($"    {e.EngineName} ({i + 1})");
                        i++;
                    }

                    int engine = Convert.ToInt32(Console.ReadLine());
                    return engines.ElementAt(engine - 1);
                }


                FuelTank WhichFuelTank()
                {
                    int i = 0;
                    Console.WriteLine($"  Which fuel tank? ");
                    foreach (FuelTank fk in fuelTanks)
                    {
                        Console.WriteLine($"    {fk.FuelTankName} ({i + 1})");
                        i++;
                    }

                    int fuelTank = Convert.ToInt32(Console.ReadLine());
                    return fuelTanks.ElementAt(fuelTank - 1);
                }


                void Add()
                {
                    int newVehicleTeamID = teamChoiceInt + 1;
                    String newVehicleMake = WhatMake();
                    String newVehicleModel = WhatModel();
                    String newVehicleColour = WhatColour();
                    String newVehicleYear = WhatYear();
                    int newVehicleSpeed = WhatSpeed();
                    bool newVehicleIsMotorised = IsItMotorised();

                    if (newVehicleIsMotorised == true)
                    {
                        int newVehicleType = WhichTypeOfVehicle(newVehicleIsMotorised);

                        Engine newVehicleEngine = WhichEngine();
                        FuelTank newVehicleFuelTank = WhichFuelTank();

                        if (newVehicleType == 1)
                        {
                            Vehicle vehicle1 = new Car(newVehicleTeamID, newVehicleMake, newVehicleModel, newVehicleColour, newVehicleYear, newVehicleSpeed, allVehicles, motorisedVehicles, newVehicleEngine, newVehicleFuelTank);
                            Console.WriteLine();
                            Console.WriteLine($"  NEW CAR ADDED TO TEAM");

                            Thread.Sleep(500);
                        }

                        else if (newVehicleType == 2)
                        {
                            Vehicle vehicle1 = new Truck(newVehicleTeamID, newVehicleMake, newVehicleModel, newVehicleColour, newVehicleYear, newVehicleSpeed, allVehicles, motorisedVehicles, newVehicleEngine, newVehicleFuelTank);
                            Console.WriteLine();
                            Console.WriteLine($"  NEW TRUCK ADDED TO TEAM");
                            Thread.Sleep(500);
                        }
                    }

                    else
                    {
                        int newVehicleType = WhichTypeOfVehicle(newVehicleIsMotorised);

                        if (newVehicleType == 1)
                        {
                            Vehicle vehicle1 = new Bike(newVehicleTeamID, newVehicleMake, newVehicleModel, newVehicleColour, newVehicleYear, newVehicleSpeed, allVehicles);
                            Console.WriteLine();
                            Console.WriteLine($"  NEW Bike ADDED TO TEAM");
                            Thread.Sleep(500);
                        }
                    }
                }
            }
            Console.WriteLine("");
        }
    }
}
