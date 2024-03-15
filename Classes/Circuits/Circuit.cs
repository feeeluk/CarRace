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
        private int _id;


        // ****************************************************************
        // Properties
        // ****************************************************************
        public static List<Circuit> Circuits { get; private set; } = new List<Circuit>();
        public static int NumberOfCircuits { get; private set; } = 1;

        public int ID
        {
            get { return _id; }
            set
            {
                _id = NumberOfCircuits;
            }
        }
        public string Name { get; private set; }
        public int NumberOfLaps { get; private set; }
        public double LapLengthKm { get; private set; }




        // ****************************************************************
        // Constructor
        // ****************************************************************
        public Circuit(int id, string name, int laps, double lapLength)
        {
            ID = id;
            Name = name;
            NumberOfLaps = laps;
            Circuits.Add(this);
            LapLengthKm = lapLength;

            NumberOfCircuits++;
        }


        // ****************************************************************
        // Methods
        // ****************************************************************
    }
}
