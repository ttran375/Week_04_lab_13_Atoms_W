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

### Fields

There are no fields in this class.

### Properties

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

### Constructor

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

``` cs

```

Create static methods that does the following and then called them from
your main

``` cs
//Create class methods to do the following:
//1 - Display all the items in the collection elements

//2 - Serialize the first item using xml format and save to a suitable file

//3 - Read the above file and display the item

//4 - Serialize the entire collection using xml format and save to a suitable file 

//5 - Read the above file and display the all the items

//6 - Serialize the first item using json format and save to a suitable file

//7 - Read the above file and display the item

//8 - Serialize the entire collection using json format and save to a suitable file 

//9 - Read the above file and display all the items
```

~~Reminder: To simplify access to the XmlSerializer class, you must add
a using statement.~~

Reminder: To gain access to the **JavaScriptSerializer** class, you must
add a reference to the **System.Web.Extension.dll** library and to
simplify access you need to insert a using statement.
