using System;
using System.Collections.Generic;
using System.Diagnostics;

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
            NumberOfCars++;
            cars.Add(this);
        }

    // ################################################################
    // Fields
        public static List<Car> cars = new List<Car>();
        

    // ################################################################
    // Properties

        public String Make { get; private set; }
        public String Model { get; private set; }
        public String Colour { get; private set; }
        public String Year { get; private set; }

        public static int NumberOfCars { get; private set; }

    // ################################################################
    // Static Methods

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

        public static void EditCar(Garage theGarage)
        {
            int carNumberToEdit = Car.WhichCarToEdit();      
            
            bool isValid = Car.IsCarNumberValid(theGarage, carNumberToEdit);
            
            if(isValid == false)
            {
                Console.WriteLine("There isn't a car in the garage that matches.");
                Console.WriteLine();
                Car.EditCar(theGarage);
            }

            else if (isValid == true)
            {               
                while (true)
                {
                String isThisTheCorrectCar = ConfirmWhichCarToEdit(theGarage, carNumberToEdit);
                    
                    switch (isThisTheCorrectCar)
                    {
                        case "y":
                        case "Y":
                            UpdateCarDetails(theGarage, carNumberToEdit);
                            break;

                        case "n":
                        case "N":
                            Console.WriteLine();
                            Car.EditCar(theGarage);
                            break;

                        default:
                            continue;
                    }
                }
            }            
        }

        private static string ConfirmWhichCarToEdit(Garage theGarage, int carNumberToEdit)
        {
            carNumberToEdit--;

            Console.WriteLine();
            Console.WriteLine("#############################################");
            Console.WriteLine("Is this the car you would like to edit?");

            Console.WriteLine();
            Console.Write($"{theGarage.carsInTheGarage.ElementAt(carNumberToEdit).Make}, ");
            Console.Write($"{theGarage.carsInTheGarage.ElementAt(carNumberToEdit).Model}, ");
            Console.Write($"{theGarage.carsInTheGarage.ElementAt(carNumberToEdit).Colour}, ");
            Console.Write($"{theGarage.carsInTheGarage.ElementAt(carNumberToEdit).Year}");
            Console.WriteLine();

            Console.WriteLine("(Y/N)");

            String response = Console.ReadLine();
            return response;
        }

        private static void UpdateCarDetails(Garage theGarage, int carNumberToEdit)
        {
            String make;
            String model;
            String colour;
            String year;

            Console.WriteLine();

            Console.Write($"edit Make: ");
            make = Console.ReadLine();

            Console.Write($"edit Model: ");
            model = Console.ReadLine();

            Console.Write($"edit Colour: ");
            colour = Console.ReadLine();

            Console.Write($"edit Year: ");
            year = Console.ReadLine();

            Console.WriteLine();

            theGarage.carsInTheGarage.ElementAt(carNumberToEdit).Make = make;
            theGarage.carsInTheGarage.ElementAt(carNumberToEdit).Model = model;
            theGarage.carsInTheGarage.ElementAt(carNumberToEdit).Colour = colour;
            theGarage.carsInTheGarage.ElementAt(carNumberToEdit).Year = year;
        }

        public static int WhichCarToEdit()
        {
            Console.WriteLine("###############################################");
            Console.WriteLine("Which car in the garage would you like to edit?");
            int carNumberToEdit = Convert.ToInt32(Console.ReadLine());
            return carNumberToEdit;
        }

        public static bool IsCarNumberValid(Garage theGarage, int carNumberToEdit)
        {
            if (carNumberToEdit > theGarage.carsInTheGarage.Count || carNumberToEdit < theGarage.carsInTheGarage.Count)
            {
                return false;
            }

            else
            {
                return true;
            }
        }

        public static void ShowAllCars()
        {
            int number = 1;

            Console.WriteLine($"The cars are:");

            foreach (Car car in cars)
            {
                Console.WriteLine($"Car {number} - {car.Make}, {car.Model}, {car.Colour}, {car.Year}");
                number++;
            }

            Console.WriteLine();
        }

        public static void HowManyCars()
        {
            Console.WriteLine($"Cars = {NumberOfCars}");
        }

        public static Car WhichCarToAdd()
        {
            Console.WriteLine($"Which car would you like to add to a team?");
            int userInput = Convert.ToInt32(Console.ReadLine())-1;
            Console.WriteLine();
            return cars.ElementAt(userInput);
        }
    }
}