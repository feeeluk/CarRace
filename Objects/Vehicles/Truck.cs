using System;
using System.Collections.Generic;

namespace Race.Classes.Vehicles
{
    public class Truck : Vehicle
    {
        // ****************************************************************
        // Fields
        // ****************************************************************


        // ****************************************************************
        // Properties
        // ****************************************************************  


        // ****************************************************************
        // Constructor
        // ****************************************************************
        public Truck(int id, int teamID, string make, string model, string colour, string year, string type, int numberOfWheels, int speed, string speedCategory, bool vehicleStart, List<Vehicle> allVehicles, List<Vehicle> unassignedVehicles) : base(id, teamID, make, model, colour, year, type, numberOfWheels, speed, speedCategory, vehicleStart, allVehicles, unassignedVehicles)
        {
        }


        // ****************************************************************
        // Methods
        // ****************************************************************

    }
}