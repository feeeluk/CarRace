using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Race
{
    public class Circuit
    {
        // ****************************************************************
        // Fields
        // ****************************************************************
        public static List<Circuit> circuits = new List<Circuit>();
        private int _id; 


        // ****************************************************************
        // Properties
        // ****************************************************************
        public string Name { get; private set; }
        public int NumberOfLaps { get; private set; }
        public double LapLengthKm { get; private set; }
        public static int NumberOfCircuits { get; private set; }
        public int ID
        {
            get { return _id; }
            set
            {
                _id = NumberOfCircuits;
            }
        }


        // ****************************************************************
        // Constructor
        // ****************************************************************
        public Circuit(int id, string name, int laps, double lapLength)
        {
            NumberOfCircuits++; 
            ID = id;
            Name = name;
            NumberOfLaps = laps;
            circuits.Add(this);
            LapLengthKm = lapLength;
        }


        // ****************************************************************
        // Methods
        // ****************************************************************
    }
}
