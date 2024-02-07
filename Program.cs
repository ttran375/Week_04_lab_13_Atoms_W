using System.Text.Json;

namespace Week_01_lab_03_Date_W
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Test harness methods
            List<Atom> atoms =
            [
                new Atom("Hydrogen", 1, 0, 1.008, "H"),
                new Atom("Helium", 2, 2, 4.0026, "He"),
                new Atom("Carbon", 6, 6, 12.011, "C")
            ];

            // Serialize and write atoms to JSON file
            WriteJson(atoms, "atoms.json");

            // Deserialize and read atoms from JSON file
            ReadJson("atoms.json");
        }

        static void WriteJson(List<Atom> atoms, string filename)
        {
            string json = JsonSerializer.Serialize(atoms);
            File.WriteAllText(filename, json);
        }

        static void ReadJson(string filename)
        {
            string json = File.ReadAllText(filename);
            List<Atom>? atoms = JsonSerializer.Deserialize<List<Atom>>(json);

            Console.WriteLine("Atoms read from JSON file:");
            if (atoms != null)
            {
                foreach (Atom atom in atoms)
                {
                    Console.WriteLine(atom);
                }
            }
        }
    }


    public class Atom
    {
        public string? Name { get; set; }
        public string? Symbol { get; set; }
        public int? Proton { get; set; }
        public int? Neutron { get; set; }
        public double? Weight { get; set; }

        public Atom() { }

        public Atom(string name, int proton, int neutron, double weight, string symbol)
        {
            Name = name;
            Symbol = symbol;
            Proton = proton;
            Neutron = neutron;
            Weight = weight;
        }

        public static Atom Parse(string objectData)
        {
            string[] parts = objectData.Split(',');

            if (parts.Length != 5)
            {
                throw new ArgumentException("Invalid input format. Expected 5 parts separated by commas.");
            }

            return new Atom
            {
                Name = parts[0],
                Proton = int.Parse(parts[1]),
                Neutron = int.Parse(parts[2]),
                Weight = double.Parse(parts[3]),
                Symbol = parts[4]
            };
        }

        public override string ToString()
        {
            return $"{Name}, {Proton}, {Neutron}, {Weight}, {Symbol}";
        }
    }
}
