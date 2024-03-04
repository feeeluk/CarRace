namespace CarRace
{
    internal static class Program
    {     
        public static void Main(string[] args)
        {
            // Initialise the Menu object (there should only be 1)
            Menu programMenu = new Menu();           
            
            // Initialize the Garage object (there should only be 1 for now, but will add more in the future)
            Garage theGarage = new Garage("Phil's");

            // Insert some sample cars into the Garage object
            theGarage.carsInTheGarage.Add(new Car("Ford","Focus","Black","2013"));

            // Provide user with menu
            programMenu.ProvideUserWithMenu(theGarage);
                  
        }
    }
}
