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
        public Bike(int id, string make, string model, string colour, string year, string type, int numberOfWheels, int speed, string speedCategory) : base(id, make, model, colour, year, type, numberOfWheels, speed, speedCategory)
        {
            ID = id;
            Make = make;
            Model = model;
            Colour = colour;
            Year = year;
            Type = type;
            NumberOfWheels = numberOfWheels;
            Speed = speed;
            SpeedCategory = speedCategory;
        }


        // ****************************************************************
        // Methods
        // ****************************************************************

    }
}