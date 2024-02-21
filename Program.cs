#define SIMONS_CODE

namespace CarRace
{
    internal class Program
    {


#if SIMONS_CODE

        public static Garage TheGarage = new Garage();

        public static void Main(string[] args)
        {
            //Garage theGarage = new Garage();
            
            // Provide user with a menu of actions
            Menu.ShowMenu();

            // Get user's choice of action to perform
            int userChoice = Menu.ChooseMenuOption();

            // Perform the requested action
            Menu.RunChosenOption(userChoice, TheGarage);      
        }


#else

        public static void Main(string[] args)
        {
            Garage theGarage = new Garage();
            
            // Provide user with a menu of actions
            Menu.ShowMenu();

            // Get user's choice of action to perform
            int userChoice = Menu.ChooseMenuOption();

            // Perform the requested action
            Menu.RunChosenOption(userChoice, theGarage);      
        }

        public static void Main(Garage _theGarage)
        {
            Garage theGarage = new Garage();

            // Provide user with a menu of actions
            Menu.ShowMenu();

            // Get user's choice of action to perform
            int userChoice = Menu.ChooseMenuOption();

            // Perform the requested action
            Menu.RunChosenOption(userChoice, _theGarage);
        }

#endif

    }
}
