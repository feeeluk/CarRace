namespace CarRace
{
    internal class Program
    {     
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
    }
}
