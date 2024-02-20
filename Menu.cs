using System;
using System.Collections.Generic;


namespace CarRace
{
    public class Menu
    {
        enum MenuOptions
        {
            Create_Cars_And_Add_To_Garage,
            Show_Cars_In_Garage,
            Remove_Cars_From_Garage,
            Edit_Car_Details,
        }

        public static void ShowMenu()
        {
            Console.WriteLine("*************************************");
            Console.WriteLine("*************** MENU ****************");

            for (int i =0, a=1; i < Enum.GetValues(typeof(MenuOptions)).Length; i++, a++)
            {
                Console.WriteLine($"{a} - {Enum.GetName(typeof(MenuOptions), i)}");
            }

            Console.WriteLine("*************************************");
            Console.WriteLine();
        }

        public static int ChooseMenuOption()
        {
            Console.WriteLine($"Select an option (#)");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            return choice;
        }

        public static void RunChosenOption(int _choice, Garage _theGarage)
        {
            int userChoice;

            switch (_choice)
            {
                // Create_Cars_And_Add_To_Garage
                case 1:
                    List<Car> listOfNewCars = Car.CreateCars();
                    _theGarage.AddCarsToTheGarage(listOfNewCars);
                    Program.Main(_theGarage);
                    break;

                // Show_Cars_In_Garage
                case 2:
                    _theGarage.ShowCarsInTheGarage(_theGarage);
                    Program.Main(_theGarage);
                    break;

                // Remove_Cars_From_Garage
                case 3:
                    _theGarage.RemoveCarsFromGarage(_theGarage);
                    Program.Main(_theGarage);
                    break;

                // Edit_Car_Details
                case 4:
                    // which car # do you want to edit?
                    Console.WriteLine("which car would you like to edit?");
                    int carNumberToEdit = Convert.ToInt32(Console.ReadLine()) -1;

                    // edit the details of the chosen car
                    _theGarage.EditCar(_theGarage, carNumberToEdit);
                    
                    Program.Main(_theGarage);
                    break;
            }
        }
    }
}
