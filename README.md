# The Atom class

This exercise you will be persisting data by writing text to file and
serialization to and deserialization using json.

## You must follow the specifications exactly (To demo to instructor beginning of next class)

This is the front end of the application. There are 12 members.

<table>
<colgroup>
<col style="width: 100%" />
</colgroup>
<thead>
<tr class="header">
<th><p>Atom</p>
<p>Class</p></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td>Fields</td>
</tr>
<tr class="even">
<td></td>
</tr>
<tr class="odd">
<td>Properties</td>
</tr>
<tr class="even">
<td><p><strong>+</strong> «c# property, set» Name :
<strong>string</strong></p>
<p><strong>+</strong> «c# property, set» Symbol :
<strong>string</strong></p>
<p><strong>+</strong> «c# property, set» Proton :
<strong>int</strong></p>
<p><strong>+</strong> «c# property, set» Neutron :
<strong>int</strong></p>
<p><strong>+</strong> «c# property, set» Weight :
<strong>double</strong></p></td>
</tr>
<tr class="odd">
<td>Methods</td>
</tr>
<tr class="even">
<td><p><strong>+</strong> «c# constructor» Atom()</p>
<p><strong>+</strong> «c# constructor» Atom(<br />
<strong>string</strong> name,<br />
<strong>int</strong> proton,<br />
<strong>int</strong> neutron,<br />
<strong>double</strong> weight,<br />
<strong>string</strong> symbol)</p>
<p><strong>$+</strong> Parse(<strong>string</strong> objectData) :
<mark>Atom</mark></p>
<p><strong>$+</strong> GetAtoms() : <mark>List&lt;Atom&gt;</mark></p>
<p><strong>+</strong> ToString() : <strong>double</strong></p></td>
</tr>
</tbody>
</table>

## Description of class members

### Fields:

There are no fields in this class.

### Properties:

All the properties have public get and set

**Name** – this is a string representing the name of this atom. Both the
getter and setter are public.

**Symbol** – this is a two-letter string representing the name of this
atom that is used in chemistry. Both the getter and setter are public.

**Proton** – this is an int representing the number of protons in the
nucleus of this atom. Both the getter and setter are public.

**Neutron** – this is a int representing the number of neutrons in the
nucleus of this atom. Both the getter and setter are public.

**Weight** – this is a double representing the atomic weight of this
atom. Both the getter and setter are public.

### Constructor:

There are two constructors for this class: a default one and a user
defined one

**public** **Atom()** – This is a default constructor that is necessary
for serialization. This is an empty constructor that does not do
anything.

**public** **Atom**(**string** name, **int** proton, **int** neutron,
**double** weight, **string** symbol) – This constructor assigns the
arguments to the appropriate fields.

### Methods

**public static Atom Parse(string line)** – This is a public class
method that takes a string and returns an Atom object. The argument is
one string that is comprised of the five fields of this object. It does
the following:

- It uses the Split() method to parse the argument into five parts.

If you do not have five parts, the correct thing to do is throw an
exception.

- I~~f the argument does not yield five parts then throw an exception~~.

- Otherwise create an Atom object and initialize the fields with the
  appropriate parts.

- Return the above object

You will need to examine the arguments to decide what part will be
assign to which field.

**public override string ToString()** – This is a public method
overrides the corresponding method in the object class to return a
stringify form of the object.

## Test Harness

Insert the following code statements in your Program.cs file:

Write create two methods that will be called from Main. The first method
will serialize a collection of atoms to a file and the second will
deserialized the contents of a file to a list of atom.

**static void WriteJson(**<span class="mark">List\<Atom\></span>
**atoms, string filename)** – This void class method that takes the list
of atoms and a filename. You will write the necessary code to serialize
the first argument to the specified file.

**static void ReadJson(string filename)** – This void class method that
takes a filename. You will write the necessary code to deserialize the
file contents to a <span class="mark">List\<Atom\></span> and then
display all atoms.

Appendix

Code for the GetAtoms method of the Atom class

<span class="mark">public static List\<Atom\> GetAtoms()</span>

<span class="mark">{</span>

<span class="mark">List\< Atom \> elements = new List\< Atom
\>();</span>

<span class="mark">elements.Add(Atom.Parse("Hydrogen 1 0 1.0079
H"));</span>

<span class="mark">elements.Add(Atom.Parse("Helium 2 2 4.0026 He"));
;</span>

<span class="mark">elements.Add(Atom.Parse("Lithium 3 4 6.941 Li"));
;</span>

<span class="mark">elements.Add(Atom.Parse("Beryllium 4 5 9.0122
Be"));</span>

<span class="mark">elements.Add(Atom.Parse("Boron 5 6 10.811
B"));</span>

<span class="mark">elements.Add(Atom.Parse("Carbon 6 6 12.0107
C"));</span>

<span class="mark">elements.Add(Atom.Parse("Nitrogen 7 7 14.0067
N"));</span>

<span class="mark">elements.Add(Atom.Parse("Oxygen 8 8 15.9994
O"));</span>

<span class="mark">elements.Add(Atom.Parse("Fluorine 9 10 18.9984
F"));</span>

<span class="mark">elements.Add(Atom.Parse("Neon 10 10 20.1797
Ne"));</span>

<span class="mark">elements.Add(Atom.Parse("Sodium 11 12 22.9897
Na"));</span>

<span class="mark">elements.Add(Atom.Parse("Magnesium 12 12 24.305
Mg"));</span>

<span class="mark">elements.Add(Atom.Parse("Aluminum 13 14 26.9815
Al"));</span>

<span class="mark">elements.Add(Atom.Parse("Silicon 14 14 28.0855
Si"));</span>

<span class="mark">elements.Add(Atom.Parse("Phosphorus 15 16 30.9738
P"));</span>

<span class="mark">elements.Add(Atom.Parse("Sulfur 16 16 32.065
S"));</span>

<span class="mark">elements.Add(Atom.Parse("Chlorine 17 18 35.453
Cl"));</span>

<span class="mark">elements.Add(Atom.Parse("Potassium 19 20 39.0983
K"));</span>

<span class="mark">elements.Add(Atom.Parse("Argon 18 22 39.948
Ar"));</span>

<span class="mark">elements.Add(Atom.Parse("Calcium 20 20 40.078
Ca"));</span>

<span class="mark">elements.Add(Atom.Parse("Scandium 21 24 44.9559
Sc"));</span>

<span class="mark">elements.Add(Atom.Parse("Titanium 22 26 47.867
Ti"));</span>

<span class="mark">elements.Add(Atom.Parse("Vanadium 23 28 50.9415
V"));</span>

<span class="mark">elements.Add(Atom.Parse("Chromium 24 28 51.9961
Cr"));</span>

<span class="mark">elements.Add(Atom.Parse("Manganese 25 30 54.938
Mn"));</span>

<span class="mark">elements.Add(Atom.Parse("Iron 26 30 55.845
Fe"));</span>

<span class="mark">elements.Add(Atom.Parse("Nickel 28 31 58.6934
Ni"));</span>

<span class="mark">elements.Add(Atom.Parse("Cobalt 27 32 58.9332
Co"));</span>

<span class="mark">elements.Add(Atom.Parse("Copper 29 35 63.546
Cu"));</span>

<span class="mark">elements.Add(Atom.Parse("Zinc 30 35 65.39
Zn"));</span>

<span class="mark">elements.Add(Atom.Parse("Gallium 31 39 69.723
Ga"));</span>

<span class="mark">elements.Add(Atom.Parse("Germanium 32 41 72.64
Ge"));</span>

<span class="mark">elements.Add(Atom.Parse("Arsenic 33 42 74.9216
As"));</span>

<span class="mark">elements.Add(Atom.Parse("Selenium 34 45 78.96
Se"));</span>

<span class="mark">elements.Add(Atom.Parse("Bromine 35 45 79.904
Br"));</span>

<span class="mark">elements.Add(Atom.Parse("Krypton 36 48 83.8
Kr"));</span>

<span class="mark">elements.Add(Atom.Parse("Rubidium 37 48 85.4678
Rb"));</span>

<span class="mark">elements.Add(Atom.Parse("Strontium 38 50 87.62
Sr"));</span>

<span class="mark">elements.Add(Atom.Parse("Yttrium 39 50 88.9059
Y"));</span>

<span class="mark">elements.Add(Atom.Parse("Zirconium 40 51 91.224
Zr"));</span>

<span class="mark">elements.Add(Atom.Parse("Niobium 41 52 92.9064
Nb"));</span>

<span class="mark">elements.Add(Atom.Parse("Molybdenum 42 54 95.94
Mo"));</span>

<span class="mark">elements.Add(Atom.Parse("Technetium 43 55 98
Tc"));</span>

<span class="mark">elements.Add(Atom.Parse("Ruthenium 44 57 101.07
Ru"));</span>

<span class="mark">elements.Add(Atom.Parse("Rhodium 45 58 102.9055
Rh"));</span>

<span class="mark">elements.Add(Atom.Parse("Palladium 46 60 106.42
Pd"));</span>

<span class="mark">elements.Add(Atom.Parse("Silver 47 61 107.8682
Ag"));</span>

<span class="mark">elements.Add(Atom.Parse("Cadmium 48 64 112.411
Cd"));</span>

<span class="mark">elements.Add(Atom.Parse("Indium 49 66 114.818
In"));</span>

<span class="mark">elements.Add(Atom.Parse("Tin 50 69 118.71
Sn"));</span>

<span class="mark">elements.Add(Atom.Parse("Antimony 51 71 121.76
Sb"));</span>

<span class="mark">elements.Add(Atom.Parse("Iodine 53 74 126.9045
I"));</span>

<span class="mark">elements.Add(Atom.Parse("Tellurium 52 76 127.6
Te"));</span>

<span class="mark">elements.Add(Atom.Parse("Xenon 54 77 131.293
Xe"));</span>

<span class="mark">elements.Add(Atom.Parse("Cesium 55 78 132.9055
Cs"));</span>

<span class="mark">elements.Add(Atom.Parse("Barium 56 81 137.327
Ba"));</span>

<span class="mark">elements.Add(Atom.Parse("Lanthanum 57 82 138.9055
La"));</span>

<span class="mark">elements.Add(Atom.Parse("Cerium 58 82 140.116
Ce"));</span>

<span class="mark">elements.Add(Atom.Parse("Praseodymium 59 82 140.9077
Pr"));</span>

<span class="mark">elements.Add(Atom.Parse("Neodymium 60 84 144.24
Nd"));</span>

<span class="mark">elements.Add(Atom.Parse("Promethium 61 84 145
Pm"));</span>

<span class="mark">elements.Add(Atom.Parse("Samarium 62 88 150.36
Sm"));</span>

<span class="mark">elements.Add(Atom.Parse("Europium 63 89 151.964
Eu"));</span>

<span class="mark">elements.Add(Atom.Parse("Gadolinium 64 93 157.25
Gd"));</span>

<span class="mark">elements.Add(Atom.Parse("Terbium 65 94 158.9253
Tb"));</span>

<span class="mark">elements.Add(Atom.Parse("Dysprosium 66 97 162.5
Dy"));</span>

<span class="mark">elements.Add(Atom.Parse("Holmium 67 98 164.9303
Ho"));</span>

<span class="mark">elements.Add(Atom.Parse("Erbium 68 99 167.259
Er"));</span>

<span class="mark">elements.Add(Atom.Parse("Thulium 69 100 168.9342
Tm"));</span>

<span class="mark">elements.Add(Atom.Parse("Ytterbium 70 103 173.04
Yb"));</span>

<span class="mark">elements.Add(Atom.Parse("Lutetium 71 104 174.967
Lu"));</span>

<span class="mark">elements.Add(Atom.Parse("Hafnium 72 106 178.49
Hf"));</span>

<span class="mark">elements.Add(Atom.Parse("Tantalum 73 108 180.9479
Ta"));</span>

<span class="mark">elements.Add(Atom.Parse("Tungsten 74 110 183.84
W"));</span>

<span class="mark">elements.Add(Atom.Parse("Rhenium 75 111 186.207
Re"));</span>

<span class="mark">elements.Add(Atom.Parse("Osmium 76 114 190.23
Os"));</span>

<span class="mark">elements.Add(Atom.Parse("Iridium 77 115 192.217
Ir"));</span>

<span class="mark">elements.Add(Atom.Parse("Platinum 78 117 195.078
Pt"));</span>

<span class="mark">elements.Add(Atom.Parse("Gold 79 118 196.9665
Au"));</span>

<span class="mark">elements.Add(Atom.Parse("Mercury 80 121 200.59
Hg"));</span>

<span class="mark">elements.Add(Atom.Parse("Thallium 81 123 204.3833
Tl"));</span>

<span class="mark">elements.Add(Atom.Parse("Lead 82 125 207.2
Pb"));</span>

<span class="mark">elements.Add(Atom.Parse("Bismuth 83 126 208.9804
Bi"));</span>

<span class="mark">elements.Add(Atom.Parse("Polonium 84 125 209
Po"));</span>

<span class="mark">elements.Add(Atom.Parse("Astatine 85 125 210
At"));</span>

<span class="mark">elements.Add(Atom.Parse("Radon 86 136 222
Rn"));</span>

<span class="mark">elements.Add(Atom.Parse("Francium 87 136 223
Fr"));</span>

<span class="mark">elements.Add(Atom.Parse("Radium 88 138 226
Ra"));</span>

<span class="mark">elements.Add(Atom.Parse("Actinium 89 138 227
Ac"));</span>

<span class="mark">elements.Add(Atom.Parse("Protactinium 91 140 231.0359
Pa"));</span>

<span class="mark">elements.Add(Atom.Parse("Thorium 90 142 232.0381
Th"));</span>

<span class="mark">elements.Add(Atom.Parse("Neptunium 93 144 237
Np"));</span>

<span class="mark">elements.Add(Atom.Parse("Uranium 92 146 238.0289
U"));</span>

<span class="mark">elements.Add(Atom.Parse("Americium 95 148 243
Am"));</span>

<span class="mark">elements.Add(Atom.Parse("Plutonium 94 150 244
Pu"));</span>

<span class="mark">elements.Add(Atom.Parse("Curium 96 151 247
Cm"));</span>

<span class="mark">elements.Add(Atom.Parse("Berkelium 97 150 247
Bk"));</span>

<span class="mark">elements.Add(Atom.Parse("Californium 98 153 251
Cf"));</span>

<span class="mark">elements.Add(Atom.Parse("Einsteinium 99 153 252
Es"));</span>

<span class="mark">elements.Add(Atom.Parse("Fermium 100 157 257
Fm"));</span>

<span class="mark">elements.Add(Atom.Parse("Mendelevium 101 157 258
Md"));</span>

<span class="mark">elements.Add(Atom.Parse("Nobelium 102 157 259
No"));</span>

<span class="mark">elements.Add(Atom.Parse("Rutherfordium 104 157 261
Rf"));</span>

<span class="mark">elements.Add(Atom.Parse("Lawrencium 103 159 262
Lr"));</span>

<span class="mark">elements.Add(Atom.Parse("Dubnium 105 157 262
Db"));</span>

<span class="mark">elements.Add(Atom.Parse("Bohrium 107 157 264
Bh"));</span>

<span class="mark">elements.Add(Atom.Parse("Seaborgium 106 160 266
Sg"));</span>

<span class="mark">elements.Add(Atom.Parse("Meitnerium 109 159 268
Mt"));</span>

<span class="mark">elements.Add(Atom.Parse("Roentgenium 111 161 272
Rg"));</span>

<span class="mark">elements.Add(Atom.Parse("Hassium 108 169 277
Hs"));</span>

<span class="mark">return elements;</span>

<span class="mark">}</span>

Create static methods that does the following and then called them from
your main

<span class="mark">//Create class methods to do the following:</span>

<span class="mark">//1 - Display all the items in the collection
elements</span>

<span class="mark">//2 - Serialize the first item using xml format and
save to a suitable file</span>

<span class="mark">//3 - Read the above file and display the item</span>

<span class="mark">~~//4 - Serialize the entire collection using xml
format and save to a suitable file~~</span>

~~Reminder: To simplify access to the XmlSerializer class, you must add
a using statement.~~

<span class="mark">~~//5 - Read the above file and display the all the
items~~</span>

<span class="mark">//6 - Serialize the first item using json format and
save to a suitable file</span>

Reminder: To gain access to the **JavaScriptSerializer** class, you must
add a reference to the **System.Web.Extension.dll** library and to
simplify access you need to insert a using statement.

<span class="mark">//7 - Read the above file and display the item</span>

<span class="mark">//8 - Serialize the entire collection using json
format and save to a suitable file</span>

<span class="mark">//9 - Read the above file and display all the
items</span>
