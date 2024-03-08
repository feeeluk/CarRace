using System;
using System.Collections.Generic;

namespace CarRace
{
    public static class Menu
    {

    // Methods
        public static void ProvideUserWithMenu()
        {
            int userInput;

            do
            {
                Menu.ShowMenu();
                userInput = Menu.ChooseMenuOption();

                switch (userInput)
                {
                    // Create Car
                    case 1:
                        List<Car> listOfNewCars = Car.CreateCars();
                        break;

                    // Create new team
                    case 2:
                        String teamName = Team.GetTeamName();
                        Team.CreateTeam(teamName);
                        break;

                    // Show All Cars
                    case 3:
                        Car.ShowAllCars();
                        break;

                    // Show all teams
                    case 4:
                        Team.ShowAllTeams();
                        break;

                    // Add car to team
                    case 5:
                        Car whichCar = Car.WhichCarToAdd();
                        Team whichTeam = Team.WhichTeam();
                        whichTeam.AddCarToTeam(whichCar);
                        break;

                    // Show cars in team
                    case 6:
                        Team showWhichTeam = Team.ShowWhichTeam();
                        showWhichTeam.ShowCarsInTeam();
                        break;

                    // Clear Car/s From Team
                    case 7:
                    Team clearWhichTeam = Team.ClearWhichTeam();
                    clearWhichTeam.ClearCars();
                    break;

                    // Edit Car Details
                    //case 8:
                        // which car to edit or exit
                            // is this the right car (y/n)
                                // edit details

                    // Statistics
                    case 9:
                        Team.HowManyTeams();
                        Car.HowManyCars();
                        Console.WriteLine();
                        break;

                }
            }
            
            while (userInput != 10);
        }


        public static void ShowMenu()
        {
            Console.WriteLine(" *** MENU ***");

            int item = 1;
            int enumItem = 0;
            
            foreach (MenuOptions option in Enum.GetValues(typeof(MenuOptions)))
            {
                String rawMenuItem = Enum.GetName(typeof(MenuOptions), enumItem);
                String menuItem = rawMenuItem.Replace('_', ' ');

                Console.WriteLine($"{item} - {menuItem}");
                item++;
                enumItem++;
            }

            Console.WriteLine();

        }

        public static int ChooseMenuOption()
        {
            Console.WriteLine($"Select an option:");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            return choice;
        }
    }
}
