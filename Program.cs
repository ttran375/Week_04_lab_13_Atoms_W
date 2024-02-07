using System.Text.Json;

namespace Week_04_lab_13_Atoms_W
{
    internal class Program
    {
        public static void Main()
        {
            // Test harness methods
            List<Atom> atoms = Atom.GetAtoms();
            DisplayItems(atoms);
            SerializeFirstItemToJson(atoms, "first_atom.json");
            DeserializeAndDisplayFirstItemFromJson("first_atom.json");
            SerializeAllItemsToJson(atoms, "all_atoms.json");
            DeserializeAndDisplayAllItemsFromJson("all_atoms.json");
        }

        static void DisplayItems(List<Atom> atoms)
        {
            foreach (var atom in atoms)
            {
                Console.WriteLine(atom);
            }
        }

        static void SerializeFirstItemToJson(List<Atom> atoms, string filename)
        {
            Atom firstAtom = atoms[0];
            string json = JsonSerializer.Serialize(firstAtom);
            File.WriteAllText(filename, json);
        }

        static void DeserializeAndDisplayFirstItemFromJson(string filename)
        {
            string json = File.ReadAllText(filename);
            Atom? atom = JsonSerializer.Deserialize<Atom>(json);
            Console.WriteLine(atom);
        }

        static void SerializeAllItemsToJson(List<Atom> atoms, string filename)
        {
            string json = JsonSerializer.Serialize(atoms);
            File.WriteAllText(filename, json);
        }

        static void DeserializeAndDisplayAllItemsFromJson(string filename)
        {
            string json = File.ReadAllText(filename);
            List<Atom>? atoms = JsonSerializer.Deserialize<List<Atom>>(json);
            if (atoms != null)
            {
                DisplayItems(atoms);
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

        public static Atom Parse(string line)
        {
            string[] parts = line.Split(' ');
            return parts.Length != 5
                ? throw new ArgumentException("Invalid format for atom data")
                : new Atom(parts[0], int.Parse(parts[1]), int.Parse(parts[2]), double.Parse(parts[3]), parts[4]);
        }

        public override string ToString()
        {
            return $"{Name} ({Symbol}): Protons={Proton}, Neutrons={Neutron}, Weight={Weight}";
        }

        public static List<Atom> GetAtoms()
        {
            List<Atom> elements = [Parse("Hydrogen 1 0 1.0079 H"), Parse("Helium 2 2 4.0026 He")];
            elements.Add(Parse("Lithium 3 4 6.941 Li")); ;
            elements.Add(Parse("Beryllium 4 5 9.0122 Be"));
            elements.Add(Parse("Boron 5 6 10.811 B"));
            elements.Add(Parse("Carbon 6 6 12.0107 C"));
            elements.Add(Parse("Nitrogen 7 7 14.0067 N"));
            elements.Add(Parse("Oxygen 8 8 15.9994 O"));
            elements.Add(Parse("Fluorine 9 10 18.9984 F"));
            elements.Add(Parse("Neon 10 10 20.1797 Ne"));
            elements.Add(Parse("Sodium 11 12 22.9897 Na"));
            elements.Add(Parse("Magnesium 12 12 24.305 Mg"));
            elements.Add(Parse("Aluminum 13 14 26.9815 Al"));
            elements.Add(Parse("Silicon 14 14 28.0855 Si"));
            elements.Add(Parse("Phosphorus 15 16 30.9738 P"));
            elements.Add(Parse("Sulfur 16 16 32.065 S"));
            elements.Add(Parse("Chlorine 17 18 35.453 Cl"));
            elements.Add(Parse("Potassium 19 20 39.0983 K"));
            elements.Add(Parse("Argon 18 22 39.948 Ar"));
            elements.Add(Parse("Calcium 20 20 40.078 Ca"));
            elements.Add(Parse("Scandium 21 24 44.9559 Sc"));
            elements.Add(Parse("Titanium 22 26 47.867 Ti"));
            elements.Add(Parse("Vanadium 23 28 50.9415 V"));
            elements.Add(Parse("Chromium 24 28 51.9961 Cr"));
            elements.Add(Parse("Manganese 25 30 54.938 Mn"));
            elements.Add(Parse("Iron 26 30 55.845 Fe"));
            elements.Add(Parse("Nickel 28 31 58.6934 Ni"));
            elements.Add(Parse("Cobalt 27 32 58.9332 Co"));
            elements.Add(Parse("Copper 29 35 63.546 Cu"));
            elements.Add(Parse("Zinc 30 35 65.39 Zn"));
            elements.Add(Parse("Gallium 31 39 69.723 Ga"));
            elements.Add(Parse("Germanium 32 41 72.64 Ge"));
            elements.Add(Parse("Arsenic 33 42 74.9216 As"));
            elements.Add(Parse("Selenium 34 45 78.96 Se"));
            elements.Add(Parse("Bromine 35 45 79.904 Br"));
            elements.Add(Parse("Krypton 36 48 83.8 Kr"));
            elements.Add(Parse("Rubidium 37 48 85.4678 Rb"));
            elements.Add(Parse("Strontium 38 50 87.62 Sr"));
            elements.Add(Parse("Yttrium 39 50 88.9059 Y"));
            elements.Add(Parse("Zirconium 40 51 91.224 Zr"));
            elements.Add(Parse("Niobium 41 52 92.9064 Nb"));
            elements.Add(Parse("Molybdenum 42 54 95.94 Mo"));
            elements.Add(Parse("Technetium 43 55 98 Tc"));
            elements.Add(Parse("Ruthenium 44 57 101.07 Ru"));
            elements.Add(Parse("Rhodium 45 58 102.9055 Rh"));
            elements.Add(Parse("Palladium 46 60 106.42 Pd"));
            elements.Add(Parse("Silver 47 61 107.8682 Ag"));
            elements.Add(Parse("Cadmium 48 64 112.411 Cd"));
            elements.Add(Parse("Indium 49 66 114.818 In"));
            elements.Add(Parse("Tin 50 69 118.71 Sn"));
            elements.Add(Parse("Antimony 51 71 121.76 Sb"));
            elements.Add(Parse("Iodine 53 74 126.9045 I"));
            elements.Add(Parse("Tellurium 52 76 127.6 Te"));
            elements.Add(Parse("Xenon 54 77 131.293 Xe"));
            elements.Add(Parse("Cesium 55 78 132.9055 Cs"));
            elements.Add(Parse("Barium 56 81 137.327 Ba"));
            elements.Add(Parse("Lanthanum 57 82 138.9055 La"));
            elements.Add(Parse("Cerium 58 82 140.116 Ce"));
            elements.Add(Parse("Praseodymium 59 82 140.9077 Pr"));
            elements.Add(Parse("Neodymium 60 84 144.24 Nd"));
            elements.Add(Parse("Promethium 61 84 145 Pm"));
            elements.Add(Parse("Samarium 62 88 150.36 Sm"));
            elements.Add(Parse("Europium 63 89 151.964 Eu"));
            elements.Add(Parse("Gadolinium 64 93 157.25 Gd"));
            elements.Add(Parse("Terbium 65 94 158.9253 Tb"));
            elements.Add(Parse("Dysprosium 66 97 162.5 Dy"));
            elements.Add(Parse("Holmium 67 98 164.9303 Ho"));
            elements.Add(Parse("Erbium 68 99 167.259 Er"));
            elements.Add(Parse("Thulium 69 100 168.9342 Tm"));
            elements.Add(Parse("Ytterbium 70 103 173.04 Yb"));
            elements.Add(Parse("Lutetium 71 104 174.967 Lu"));
            elements.Add(Parse("Hafnium 72 106 178.49 Hf"));
            elements.Add(Parse("Tantalum 73 108 180.9479 Ta"));
            elements.Add(Parse("Tungsten 74 110 183.84 W"));
            elements.Add(Parse("Rhenium 75 111 186.207 Re"));
            elements.Add(Parse("Osmium 76 114 190.23 Os"));
            elements.Add(Parse("Iridium 77 115 192.217 Ir"));
            elements.Add(Parse("Platinum 78 117 195.078 Pt"));
            elements.Add(Parse("Gold 79 118 196.9665 Au"));
            elements.Add(Parse("Mercury 80 121 200.59 Hg"));
            elements.Add(Parse("Thallium 81 123 204.3833 Tl"));
            elements.Add(Parse("Lead 82 125 207.2 Pb"));
            elements.Add(Parse("Bismuth 83 126 208.9804 Bi"));
            elements.Add(Parse("Polonium 84 125 209 Po"));
            elements.Add(Parse("Astatine 85 125 210 At"));
            elements.Add(Parse("Radon 86 136 222 Rn"));
            elements.Add(Parse("Francium 87 136 223 Fr"));
            elements.Add(Parse("Radium 88 138 226 Ra"));
            elements.Add(Parse("Actinium 89 138 227 Ac"));
            elements.Add(Parse("Protactinium 91 140 231.0359 Pa"));
            elements.Add(Parse("Thorium 90 142 232.0381 Th"));
            elements.Add(Parse("Neptunium 93 144 237 Np"));
            elements.Add(Parse("Uranium 92 146 238.0289 U"));
            elements.Add(Parse("Americium 95 148 243 Am"));
            elements.Add(Parse("Plutonium 94 150 244 Pu"));
            elements.Add(Parse("Curium 96 151 247 Cm"));
            elements.Add(Parse("Berkelium 97 150 247 Bk"));
            elements.Add(Parse("Californium 98 153 251 Cf"));
            elements.Add(Parse("Einsteinium 99 153 252 Es"));
            elements.Add(Parse("Fermium 100 157 257 Fm"));
            elements.Add(Parse("Mendelevium 101 157 258 Md"));
            elements.Add(Parse("Nobelium 102 157 259 No"));
            elements.Add(Parse("Rutherfordium 104 157 261 Rf"));
            elements.Add(Parse("Lawrencium 103 159 262 Lr"));
            elements.Add(Parse("Dubnium 105 157 262 Db"));
            elements.Add(Parse("Bohrium 107 157 264 Bh"));
            elements.Add(Parse("Seaborgium 106 160 266 Sg"));
            elements.Add(Parse("Meitnerium 109 159 268 Mt"));
            elements.Add(Parse("Roentgenium 111 161 272 Rg"));
            elements.Add(Parse("Hassium 108 169 277 Hs"));
            return elements;
        }
    }
}
