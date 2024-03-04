using System;
using System.Collections.Generic;

namespace CarRace
{
    public class Car
    {

    // ################################################################
    // Constructor

        public Car(String make, String model, String colour, String year)
        {
            Make = make;
            Model = model;
            Colour = colour;
            Year = year;
        }

    // ################################################################
    // Fields

        private String make;
        private String model;
        private String colour;
        private String year;

    // ################################################################
    // Properties

        public String Make { get { return make; } set { make = value; } }
        public String Model { get { return model; } set { model = value; } }
        public String Colour { get { return colour; } set { colour = value; } }
        public String Year { get { return year; } set { year = value; } }

    // ################################################################
    // Methods

        public static List<Car> CreateCars()
        {
            List<Car> listOfNewCars = new List<Car>();

            Console.WriteLine("How many cars would you like to add?");
            int numberOfCars = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= numberOfCars; i++)
            {
                Car newCar = Car.CreateIndividualCar(i);
                listOfNewCars.Add(newCar);
            }

            Console.WriteLine();

            return listOfNewCars;
        }

        public static Car CreateIndividualCar(int i)
        {
            Car newCar;
            int carNumber = i;
            String make;
            String model;
            String colour;
            String year;

            Console.WriteLine();
            Console.Write($"Car {carNumber}: What is the make? ");
            make = Console.ReadLine();

            Console.Write($"Car {carNumber}: What is the model? ");
            model = Console.ReadLine();

            Console.Write($"Car {carNumber}: What is the colour? ");
            colour = Console.ReadLine();

            Console.Write($"Car {carNumber}: What is the year? ");
            year = Console.ReadLine();

            newCar = new Car(make, model, colour, year);
            return newCar;
        }
    }
}