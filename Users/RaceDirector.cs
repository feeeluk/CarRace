using Race.ObjectsManagers;
using Race.Objects.Vehicles;
using Race.Objects.Circuits;
using Race.Objects.Results;
using Race.Objects.Teams;

namespace Race.Users
{
    public class RaceDirector
    {
        // ****************************************************************
        // Properties
        // ****************************************************************
        Circuit CircuitChoice { get; set; }
        String CircuitAnswer { get; set; }


        // ****************************************************************
        // Methods
        // ****************************************************************
        public void StartGrandPrix(ResultManager resultsManagerObj, List<Vehicle> vehicles, List<Team> teams, List<Circuit> circuits, List<RaceResult> seasonResults)
        {
            Console.WriteLine($"  Start race");
            Console.WriteLine($"  ==========");

            int x = 0;

            while (x == 0)
            {
                CircuitChoice = AskUserToChooseCircuit();
                CircuitAnswer = ConfirmChoiceOfCircuit();

                switch (CircuitAnswer)
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
                        Console.WriteLine("  invalid response, please press 'y', 'n' or 'x'");
                        Console.WriteLine();
                        continue;
                }

                StartRace(CircuitChoice);
                StopRace(resultsManagerObj, CircuitChoice, teams, seasonResults, vehicles);


                Circuit AskUserToChooseCircuit()
                {
                    int userChoice = GetChoiceOfCircuit();
                    return DisplayChoiceOfCircuit(userChoice);

                    int GetChoiceOfCircuit()
                    {
                        Console.WriteLine($"  Which circuit do you want to choose?");
                        return Convert.ToInt32(Console.ReadLine()) - 1;
                    }

                    Circuit DisplayChoiceOfCircuit(int userChoice)
                    {
                        Console.WriteLine();
                        Circuit choice = circuits.ElementAt(userChoice);
                        Console.WriteLine($"  You have selected: #{choice.ID} - {choice.Name} Grand Prix");
                        Console.WriteLine();
                        return choice;
                    }
                }


                string ConfirmChoiceOfCircuit()
                {
                    Console.WriteLine($"  Is this correct? y(yes) n(no) x(exit)");
                    return Console.ReadLine();
                }


                void StartRace(Circuit circuit)
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


                    void StartAllVehicles()
                    {
                        Console.WriteLine($"  Starting Vehicles:");

                        foreach (Vehicle vehicle in vehicles)
                        {
                            vehicle.Start();                          
                        }

                        Console.WriteLine();
                    }

                    void ShowEachLap(Circuit circuit)
                    {
                        Console.WriteLine($"  Race progress");

                        for (int i = 1; i <= circuit.NumberOfLaps; i++)
                        {
                            Console.WriteLine($"  Lap number {i}");
                            Thread.Sleep(25);
                        }

                        Console.WriteLine();
                    }
                }


                void StopRace(ResultManager resultsMangerObj, Circuit circuitChoice, List<Team> teams, List<RaceResult> seasonResults, List<Vehicle> vehicles)
                {
                    Console.WriteLine($"  The race is ending...");
                    Console.WriteLine();
                    Thread.Sleep(1000);

                    StopAllVehicles();
                    Thread.Sleep(1000);

                    resultsManagerObj.RaceResults(teams, circuitChoice, seasonResults, vehicles);
                    Thread.Sleep(1000);

                    Console.WriteLine($"  The Grand Prix has ended!");
                    Console.WriteLine($"  =========================");
                    Console.WriteLine();


                    void StopAllVehicles()
                    {
                        Console.WriteLine($"  Stopping Vehicles:");

                        foreach (Vehicle vehicle in vehicles)
                        {
                            vehicle.Stop();
                        }

                        Console.WriteLine();
                    }
                }


            }
        }


    }
}
