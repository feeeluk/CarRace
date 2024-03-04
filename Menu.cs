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
                    // Create_Cars (and then add to the default garage)
                    case 1:
                        List<Car> listOfNewCars = Car.CreateCars();
                        theGarage.AddCarsToTheGarage(listOfNewCars);
                        break;

                    // Show_Cars_In_Garage
                    case 2:
                        theGarage.ShowCarsInTheGarage(theGarage);

                        break;

                    // Remove_Cars_From_Garage
                    case 3:
                        theGarage.RemoveCarsFromGarage(theGarage);

                        break;

                    // Edit_Car_Details
                    case 4:
                        // which car # do you want to edit?
                        Console.WriteLine("#################################");
                        Console.WriteLine("which car would you like to edit?");
                        int carNumberToEdit = Convert.ToInt32(Console.ReadLine());

                        // edit the details of the chosen car
                        theGarage.EditCar(theGarage, carNumberToEdit);
                        break;
                }
            }
            
            while (UserInput != 5);
        }
        
        public static void ShowMenu()
        {
            Console.WriteLine(" *** MENU ***");

            //for (int i =0, a=1; i < Enum.GetValues(typeof(MenuOptions)).Length; i++, a++)
            //{
            //    Console.WriteLine($"{a} - {Enum.GetName(typeof(MenuOptions), i)}");
            //}

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
