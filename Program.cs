namespace CarRace
{
    internal static class Program
    {     
        public static void Main(string[] args)
        {
            // Initialize some test cars
            Car car1 = new Car("Ford","Focus","Black","2013");
            Car car2 = new Car("Volvo", "V40", "White", "2024");
            Car car3 = new Car("Audio", "A5", "Grey", "2016");
            Car car4 = new Car("Toyota", "Corolla", "Black", "2023");

            // Initialize some test teams
            Team team1 = new Team("Phil's Team");
            Team team2 = new Team("Mark's Team");
            Team team3 = new Team("Ozzy's Team");

            // Add some cars to a team
            team1.carsInTeam.Add(car1);
            team1.carsInTeam.Add(car2);

            // Provide user with menu
            Menu.ProvideUserWithMenu();
                  
        }
    }
}
