using Race.Objects.Vehicles;
namespace Race.Objects.Teams
{
    public class Team
    {
        // ****************************************************************
        // Properties
        // ****************************************************************
        public int ID { get; set; }
        public string Name { get; set; }
        //public List<Vehicle> VehiclesInTeam { get; set; } = new List<Vehicle>();


        // ****************************************************************
        // Constructor
        // ****************************************************************
        public Team(int id, string name, List<Team> teams)
        {
            ID = id;
            Name = name;
            teams.Add(this);
        }
    }
}
