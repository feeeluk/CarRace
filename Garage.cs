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
                Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - -");
                Console.WriteLine($"The following cars are in {theGarage.Name} garage:");
                Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - -");
            
                for (int i = 0, a = 1; i < theGarage.carsInTheGarage.Count; i++, a++)
                {
                    Console.WriteLine($"\t#{a} = {carsInTheGarage[i].Make}, {carsInTheGarage[i].Model}, {carsInTheGarage[i].Colour}, {carsInTheGarage[i].Year}");
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

        public void EditCar(Garage theGarage, int carNumberToEdit)
        {
            
            if(carNumberToEdit > theGarage.carsInTheGarage.Count || carNumberToEdit < theGarage.carsInTheGarage.Count)
            {
                // selected car is not in the garage
                Console.WriteLine();
                Console.WriteLine("?????????????????????????????????????");
                Console.WriteLine("*** This car is not in the garage ***");
                Console.WriteLine();
            }

            else
            {
                carNumberToEdit--;
                Console.WriteLine();
                Console.Write($"{theGarage.carsInTheGarage.ElementAt(carNumberToEdit).Make}, ");
                Console.Write($"{theGarage.carsInTheGarage.ElementAt(carNumberToEdit).Model}, ");
                Console.Write($"{theGarage.carsInTheGarage.ElementAt(carNumberToEdit).Colour}, ");
                Console.Write($"{theGarage.carsInTheGarage.ElementAt(carNumberToEdit).Year}");
                Console.WriteLine();

                Console.WriteLine("#############################################");
                Console.WriteLine("Is this the car you would like to edit? (Y/N)");

                String response = Console.ReadLine();

                if (response == "y" || response=="Y")
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

                else if (response == "n" || response == "N")
                {

                }

                else
                {
                    Console.WriteLine("Please enter Y or N?");
                }
            }          
        }
    }
}
