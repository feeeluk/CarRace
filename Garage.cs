using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;


namespace CarRace
{
    public class Garage
    {

    // ################################################################
    // Fields
        
        public List<Car> carsInTheGarage;

    // ################################################################
    // Constructor
        
        public Garage()
        {
            carsInTheGarage = new List<Car>();
        }

    // ################################################################
    // Methods        
        
        public void AddCarsToTheGarage(List<Car> _newCar)
        {
            foreach (Car car in _newCar)
            {
                carsInTheGarage.Add(car);
            }                
        }

        public void ShowCarsInTheGarage(Garage _theGarage)
        {
            Console.WriteLine("The following cars are in the garage:");
            for (int i = 0, a = 1; i < _theGarage.carsInTheGarage.Count; i++, a++)
            {
                Console.WriteLine($"Car #{a} = {carsInTheGarage[i].Make}, {carsInTheGarage[i].Model}, {carsInTheGarage[i].Colour}, {carsInTheGarage[i].Year}");
            }

            Console.WriteLine();
        }

        public void RemoveCarsFromGarage(Garage _theGarage)
        {
            _theGarage.carsInTheGarage.Clear();
        }
        public void EditCar(Garage _theGarage, int carNumberToEdit)
        {
            Console.WriteLine();
            Console.Write($"{_theGarage.carsInTheGarage.ElementAt(carNumberToEdit).Make}, ");
            Console.Write($"{_theGarage.carsInTheGarage.ElementAt(carNumberToEdit).Model}, ");
            Console.Write($"{_theGarage.carsInTheGarage.ElementAt(carNumberToEdit).Colour}, ");
            Console.Write($"{_theGarage.carsInTheGarage.ElementAt(carNumberToEdit).Year}");
            Console.WriteLine();

            Console.WriteLine("Is this the car you would like to edit? (Y/N)");

            String response = Console.ReadLine();

            if (response == "y" )
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

                _theGarage.carsInTheGarage.ElementAt(carNumberToEdit).Make = make;
                _theGarage.carsInTheGarage.ElementAt(carNumberToEdit).Model = model;
                _theGarage.carsInTheGarage.ElementAt(carNumberToEdit).Colour = colour;
                _theGarage.carsInTheGarage.ElementAt(carNumberToEdit).Year = year;

            }

            else
            {

            }
        }
    }
}
