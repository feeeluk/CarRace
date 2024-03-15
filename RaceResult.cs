using System;
using System.Collections.Generic;

namespace Race
{
    public class RaceResult
    {
        // ****************************************************************
        // Properties
        // ****************************************************************
        public int VehicleID { get; set; }
        public int CircuitID { get; set; }
        public double Time { get; set; }
        public int Position { get; set; }
        public String VehicleType { get; set; }
        public String VehicleMake { get; set; }
        public String VehicleModel { get; set; }


        // ****************************************************************
        // Constructor
        // ****************************************************************
        public RaceResult(int vehicle, int circuit, double time, int position, String type, String make, String model)
        {
            VehicleID = vehicle;
            CircuitID = circuit;
            Time = time;
            Position = position;
            VehicleType = type;
            VehicleMake = make;
            VehicleModel = model;
        }
    }
}
