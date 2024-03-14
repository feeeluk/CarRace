using System;
using System.Collections.Generic;

namespace Race
{
    public class Bike : Vehicle
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
        public Bike(int id, string make, string model, string colour, string year, string type, int numberOfWheels, int speed, string speedCategory, bool vehicleStart) : base(id, make, model, colour, year, type, numberOfWheels, speed, speedCategory, vehicleStart)
        {
        }


        // ****************************************************************
        // Methods
        // ****************************************************************

    }
}