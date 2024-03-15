using System;
using System.Collections.Generic;

namespace Race.Classes.Vehicles
{
    public class Car : Vehicle
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
        public Car(int id, string make, string model, string colour, string year, string type, int numberOfWheels, int speed, string speedCategory, bool vehicleStart) : base(id, make, model, colour, year, type, numberOfWheels, speed, speedCategory, vehicleStart)
        {
        }


        // ****************************************************************
        // Methods
        // ****************************************************************

    }
}