using System;
using System.Collections.Generic;

namespace Race
{
    public class Team
    {
        // ****************************************************************
        // Fields
        // ****************************************************************        
        private int _id;


        // ****************************************************************
        // Properties
        // ****************************************************************
        public static int NumberOfTeams { get; private set; } = 1;
        public static List<Team> Teams { get; private set; } = new List<Team>();

        public int ID
        {
            get { return _id; }
            private set
            {
                _id = NumberOfTeams;
            }
        }
        public List<Vehicle> VehiclesInTeam { get; private set; } = new List<Vehicle>();
        public string Name { get; private set; }
        

        // ****************************************************************
        // Constructor
        // ****************************************************************
        public Team(int id, string name)
        {
            ID = id;
            Name = name;
            NumberOfTeams++;
            Teams.Add(this);
        }


        // ****************************************************************
        // Methods
        // ****************************************************************
    }
}
