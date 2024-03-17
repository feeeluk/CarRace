using Race.Classes.Circuits;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Race.Classes.Managers
{
    public class CircuitManager
    {
        public void AddCircuit(List<Circuit> list)
        {
            int circuitID = 0;

            Console.WriteLine($"Enter the name of the circuit:");
            String circuitName = Console.ReadLine();

            Console.WriteLine($"Enter the number of laps");
            int circuitLaps = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Enter the length of each lap");
            double circuitLapLength = Convert.ToInt32(Console.ReadLine());

            List<Circuit> circuitList = list;

            Circuit newCircuit = new Circuit(circuitID, circuitName, circuitLaps, circuitLapLength, circuitList);
        }

    }
}
