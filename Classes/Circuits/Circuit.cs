using System;
using System.Collections.Generic;
using System.Security.Cryptography;

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
