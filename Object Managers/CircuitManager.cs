using Race.Classes.Circuits;

namespace Race.Classes.Managers
{
    public class CircuitManager
    {
        // ****************************************************************
        // Properties
        // ****************************************************************
        public List<Circuit> Circuits { get; set; }


        // ****************************************************************
        // Constructor
        // ****************************************************************
        public CircuitManager()
        {
            Circuits = new List<Circuit>();
        }

        // ****************************************************************
        // Methods
        // ****************************************************************
        public void HowManyCircuitsAreThere()
        {
            Console.WriteLine($"Circuits = {Circuits.Count}");
        }


        public int HowManyCircuits()
        {
            return Circuits.Count;
        }


        public void ShowAllCircuits()
        {
            Console.WriteLine($"   List all Circuits");
            Console.WriteLine($"   =================");

            foreach (Circuit circuit in Circuits)
            {
                double totalCircuitLengthKm = circuit.LapLengthKm * circuit.NumberOfLaps;
                Console.WriteLine($"   - Circuit #{circuit.ID}, {circuit.Name}, {circuit.NumberOfLaps} laps, 1xlap ={circuit.LapLengthKm}km, TOTAL LENGTH = {Math.Round(totalCircuitLengthKm, 1)}km");
            }

            Console.WriteLine();
        }


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
