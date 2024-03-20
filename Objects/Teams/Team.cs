using System;
using System.Collections.Generic;
using Race.Classes.Vehicles;

namespace Race.Classes.Teams
{
    public class Team
    {
        // ****************************************************************
        // Fields
        // ****************************************************************        


        // ****************************************************************
        // Properties
        // ****************************************************************
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Vehicle> VehiclesInTeam { get; set; } = new List<Vehicle>();

        // ****************************************************************
        // Constructor
        // ****************************************************************
        public Team(int id, string name, List<Team> teams)
        {
            ID = id;
            Name = name;
            teams.Add(this);
        }


        // ****************************************************************
        // Methods
        // ****************************************************************
    }
}
