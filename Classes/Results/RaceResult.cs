using System;
using System.Collections.Generic;

namespace Race.Classes.Results
{
    public class RaceResult
    {
        // ****************************************************************
        // Properties
        // ****************************************************************
        public int VehicleID { get; set; }
        public string VehicleType { get; set; }
        public string VehicleMake { get; set; }
        public string VehicleModel { get; set; }
        public string CircuitName { get; set; }
        public int TeamID { get; set; }
        public double Time { get; set; }
        public int Position { get; set; }
        public int Points { get; set; }


        // ****************************************************************
        // Constructor
        // ****************************************************************
        public RaceResult(int vehicle, string type, string make, string model, string circuit, int teamID, double time, int position, int points)
        {
            VehicleID = vehicle;
            VehicleType = type;
            VehicleMake = make;
            VehicleModel = model;
            CircuitName = circuit;
            Time = time;
            Position = position;
            Points = points;
            TeamID = teamID;
        }
    }
}
