using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace CarRace
{
    public class Team
    {

    // ################################################################
    // Constructor

        public Team(String name)
        {
            Name = name;
            NumberOfTeams++;
            teams.Add(this);
        }

    // ################################################################
    // Fields
        public static List<Team> teams = new List<Team>();
        public List<Car> carsInTeam = new List<Car>();

    // ################################################################
    // Properties
        public String Name { get; set; }
        public static int NumberOfTeams { get; private set;}
    
    // ################################################################
    // Methods        

        public void AddCarToTeam(Car car)
        {
            carsInTeam.Add(car);
        }

        public void ShowCarsInTeam() 
        {
            Console.WriteLine($"The cars in {Name} are:");
            foreach (Car car in carsInTeam)
            {
                Console.WriteLine($"{car.Make}, {car.Model}, {car.Colour}, {car.Year} ");
            }
            Console.WriteLine();
        }

        public void ClearCars()
        {
            carsInTeam.Clear();
        }

    // ################################################################
    // Static Methods

        public static String GetTeamName()
        {
            Console.WriteLine("What is the name of the team?");
            String teamName = Console.ReadLine();
            Console.WriteLine();
            return teamName;
        }

        public static void CreateTeam(String teamName)
        {
            Team newTeam = new Team(teamName);
            Console.WriteLine($"New team \"{teamName}\" created.");
            Console.WriteLine();
        }

        public static void ShowAllTeams()
        {
            int number = 1;
            
            Console.WriteLine($"The teams are:");
            
            foreach ( Team team in teams )
            {
                Console.WriteLine($"Team {number} - {team.Name}");
                number++;
            }

            Console.WriteLine();
        }

        public static void HowManyTeams()
        {
            Console.WriteLine($"Teams = {NumberOfTeams}");
        }

        public static Team WhichTeam()
        {
            Console.WriteLine($"Which team would you like to add the car to?");
            int userInput = Convert.ToInt32(Console.ReadLine())-1;
            Console.WriteLine();
            return teams.ElementAt(userInput);
        }

        public static Team ShowWhichTeam()
        {
            Console.WriteLine($"Which team would you like to view?");
            int userInput = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.WriteLine();
            return teams.ElementAt(userInput);
        }

        public static Team ClearWhichTeam()
        {
            Console.WriteLine($"Which team would you like to clear?");
            int userInput = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.WriteLine();
            return teams.ElementAt(userInput);
        }
    }
}
