using Race.Objects.Vehicles;
using Race.Objects;
using Race.Objects.Teams;
using System.Collections.Generic;

namespace Race.ObjectsManagers
{
    public class VehicleManager
    {
        // ****************************************************************
        // Properties
        // ****************************************************************
        public List<Vehicle> AllVehicles { get; set; }
        Team SelectedTeam { get; set; }
        int SelectedTeamInt { get; set; }
        String ConfirmedTeam { get; set; }
        


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

            foreach (Vehicle v in AllVehicles)
            {
                Console.Write($"    - Vehicle #{v.VehicleID} - {v.VehicleType}," +
                        $"{v.VehicleMake}, {v.VehicleModel}, {v.VehicleColour}, {v.VehicleYear}, " +
                        $"{v.VehicleSpeedCategory}");

                if (v.IsMotorisedVehicle == true)
                {
                    MotorisedVehicle mv = motorisedVehicles.Find(x => x.VehicleID == v.VehicleID);
                    Console.Write($", Engine(ID:{mv.MotorisedVehicleEngine.EngineID}, {mv.MotorisedVehicleEngine.EngineName}, {mv.MotorisedVehicleEngine.EngineFuelType}), " +
                        $"Fuel Tank(ID:{mv.MotorisedVehicleFuelTank.FuelTankID}, {mv.MotorisedVehicleFuelTank.FuelTankName}, {mv.MotorisedVehicleFuelTank.FuelTankSize} ltrs)");
                }

                Console.WriteLine();
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
                ShowAllTeams();
                SelectedTeamInt = SelectATeam();
                ShowSelectedTeam(SelectedTeamInt);
                ConfirmedTeam = ConfirmSelectedTeam();

                Console.WriteLine("");

                switch (ConfirmedTeam)
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


                void ShowAllTeams()
                {
                    Console.WriteLine($"  Which Team?");
                    
                    int i = 1;
                    foreach (Team team in teams)
                    {
                        Console.WriteLine($"  - {team.Name} ({i})");
                        i++;
                    }
                }


                int SelectATeam()
                {
                    return Convert.ToInt32(Console.ReadLine()) - 1;
                }


                Team ShowSelectedTeam(int selectedTeam)
                {
                    Console.WriteLine();
                    SelectedTeam = teams.ElementAt(selectedTeam);
                    Console.WriteLine($"  You have selected: #{SelectedTeam.ID} - {SelectedTeam.Name}");
                    Console.WriteLine();
                    return SelectedTeam;
                }


                String ConfirmSelectedTeam()
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


                VehicleType WhatVehicleType()
                {

                    Console.WriteLine($"  Which VehicleType?");

                    int i = 1;
                    List<VehicleType> types = new List<VehicleType>();
                    foreach (VehicleType vt in Enum.GetValues(typeof(VehicleType)))
                    {
                        Console.WriteLine($"  - {vt} ({i})");
                        types.Add( vt );
                        i++;
                    }

                    int selected = Convert.ToInt32(Console.ReadLine()) - 1;
                    return types.ElementAt(selected);                 
                }


                bool IsItMotorised(VehicleType vt)
                {
                    List<bool> list = allVehicles.Where(x => x.VehicleType == vt).Select(x => x.IsMotorisedVehicle).Distinct().ToList();
                    return list.ElementAt(0);
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
                    Team newVehicleTeam = SelectedTeam;
                    String newVehicleMake = WhatMake();
                    String newVehicleModel = WhatModel();
                    String newVehicleColour = WhatColour();
                    String newVehicleYear = WhatYear();
                    int newVehicleSpeed = WhatSpeed();
                    VehicleType newVehicleType = WhatVehicleType();
                    bool newVehicleIsItMotorised = IsItMotorised(newVehicleType);

                    if( newVehicleIsItMotorised == true )
                    {
                        Engine newVehicleEngine = WhichEngine();
                        FuelTank newVehicleFuelTank = WhichFuelTank();

                        if (newVehicleType == VehicleType.Car)
                        {
                            Vehicle vehicle1 = new Car(newVehicleTeam, newVehicleMake, newVehicleModel, newVehicleColour, newVehicleYear, newVehicleSpeed, allVehicles, motorisedVehicles, newVehicleEngine, newVehicleFuelTank);
                            Console.WriteLine();
                            Console.WriteLine($"  NEW CAR ADDED TO TEAM");

                            Thread.Sleep(500);
                        }

                        else if (newVehicleType == VehicleType.Truck)
                        {
                            Vehicle vehicle1 = new Truck(newVehicleTeam, newVehicleMake, newVehicleModel, newVehicleColour, newVehicleYear, newVehicleSpeed, allVehicles, motorisedVehicles, newVehicleEngine, newVehicleFuelTank);
                            Console.WriteLine();
                            Console.WriteLine($"  NEW TRUCK ADDED TO TEAM");
                            Thread.Sleep(500);
                        }
                    }

                    else if(newVehicleIsItMotorised == false)
                    {
                        if (newVehicleType == VehicleType.Bike)
                        {
                            Vehicle vehicle1 = new Bike(newVehicleTeam, newVehicleMake, newVehicleModel, newVehicleColour, newVehicleYear, newVehicleSpeed, allVehicles);
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
