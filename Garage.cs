using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace CarRace
{
    public class Garage
    {

    // ################################################################
    // Constructor

        public Garage(String name)
        {
            Name = name;
            carsInTheGarage = new List<Car>();
        }

    // ################################################################
    // Fields

        public List<Car> carsInTheGarage;

    // ################################################################
    // Properties

        String Name { get; set; }
    
    // ################################################################
    // Methods        

        public void AddCarsToTheGarage(List<Car> newCar)
        {
            foreach (Car car in newCar)
            {
                carsInTheGarage.Add(car);
            }                
        }

        public void ShowCarsInTheGarage(Garage theGarage)
        {
            if (theGarage.carsInTheGarage.Count > 0)
            {
                var car = theGarage.carsInTheGarage[0];
                int carNumber = 1;
                
                Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - -");
                Console.WriteLine($"The following cars are in {theGarage.Name} garage:");
                Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - -");

                foreach (Car cars in theGarage.carsInTheGarage)
                {
                    Console.WriteLine($"\t#{carNumber} = {car.Make}, {car.Model}, {car.Colour}, {car.Year}");
                    carNumber++;
                }

                Console.WriteLine("\t= = = = = = = = = = = = = = =");
                Console.WriteLine();
            }

            else 
            {
                Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - -");
                Console.WriteLine("\tThere are no cars in the garage");
                Console.WriteLine("\t= = = = = = = = = = = = = = =");
                Console.WriteLine();
            }     
        }

        public void RemoveCarsFromGarage(Garage theGarage)
        {
            theGarage.carsInTheGarage.Clear();
        }
    }
}
