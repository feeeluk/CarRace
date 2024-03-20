using System.Collections.Generic;
using Race.Classes.Circuits;
using Race.Classes.Managers;
using Race.Classes.Results;
using Race.Classes.Teams;
using Race.Classes.Vehicles;

namespace Race.Classes.Circuits
{
    public class Circuit
    {
        // ****************************************************************
        // Fields
        // ****************************************************************


        // ****************************************************************
        // Properties
        // ****************************************************************
        public int ID { get; private set; }
        public string Name { get; private set; }
        public int NumberOfLaps { get; private set; }
        public double LapLengthKm { get; private set; }




        // ****************************************************************
        // Constructor
        // ****************************************************************
        public Circuit(int id, string name, int laps, double lapLength, List<Circuit> circuits)
        {
            ID = id;
            Name = name;
            NumberOfLaps = laps;
            LapLengthKm = lapLength;
            circuits.Add(this);
        }


        // ****************************************************************
        // Methods
        // ****************************************************************
    }
}
