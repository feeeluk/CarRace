using Race.Classes.Circuits;

namespace Race.Classes.Managers
{
    public class CircuitManager
    {
        public void AddCircuit(int howManyCircuitsAreThere, List<Circuit> list)
        {
            int circuitID = howManyCircuitsAreThere + 1;
            Console.WriteLine($"  Add Circuit:");
            Console.WriteLine($"  ============");
            Console.WriteLine($"  Enter the name of the circuit:");
            String circuitName = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine($"  Enter the number of laps");
            int circuitLaps = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine($"  Enter the length of each lap");
            double circuitLapLength = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            List<Circuit> circuitList = list;

            Circuit newCircuit = new Circuit(circuitID, circuitName, circuitLaps, circuitLapLength, circuitList);
            Console.WriteLine("  Circuit added");
            Console.WriteLine();
        }

    }
}
