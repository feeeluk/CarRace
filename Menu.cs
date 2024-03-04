using System;
using System.Collections.Generic;

namespace CarRace
{
    public class Menu
    {

    // Constructor
        public Menu()
        {

        }

    // Fields

    // Properties
        private int UserInput { get; set; }

    // Methods
        public void ProvideUserWithMenu(Garage theGarage)
        {
            do
            {
                Menu.ShowMenu();
                UserInput = Menu.ChooseMenuOption();

                switch (UserInput)
                {
                    // Create Cars (and then add to the default garage)
                    case 1:
                        List<Car> listOfNewCars = Car.CreateCars();
                        theGarage.AddCarsToTheGarage(listOfNewCars);
                        break;

                    // Show Cars In Garage
                    case 2:
                        theGarage.ShowCarsInTheGarage(theGarage);

                        break;

                    // Remove Cars From Garage
                    case 3:
                        theGarage.RemoveCarsFromGarage(theGarage);

                        break;

                    // Edit Car Details
                    case 4:

                        // edit the details of the chosen car
                        Car.EditCar(theGarage);
                        break;
                }
            }
            
            while (UserInput != 5);
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
