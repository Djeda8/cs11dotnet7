using System.Xml.Serialization; // XmlSerializer
using static System.Environment;
using static System.IO.Path;

// create a list of Shapes to serialize
List<Shape> listOfShapes = new()
{
    new Circle { Colour = "Red", Radius = 2.5 },
    new Rectangle { Colour = "Blue", Height = 20.0, Width = 10.0 },
    new Circle { Colour = "Green", Radius = 8.0 },
    new Circle { Colour = "Purple", Radius = 12.3 },
    new Rectangle { Colour = "Blue", Height = 45.0, Width = 18.0 }
};

// create object that will format a List of Shapes as XML
XmlSerializer xs = new(type: listOfShapes.GetType());

// create a file to write to
string path = Combine(CurrentDirectory, "shape.xml");

using (FileStream stream = File.Create(path))
{
    // serialize the object graph to the stream
    xs.Serialize(stream, listOfShapes);
}

WriteLine("Written {0:N0} bytes of XML to {1}",
arg0: new FileInfo(path).Length,
arg1: path);
WriteLine();

// Display the serialized object graph
WriteLine(File.ReadAllText(path));

WriteLine();
WriteLine("* Deserializing XML files");
using (FileStream fileXml = File.Open(path, FileMode.Open))
{
    // deserialize and cast the object graph into a List of Person
    List<Shape>? loadedShapesXml = xs.Deserialize(fileXml) as List<Shape>;

    if (loadedShapesXml is not null)
    {
        foreach (Shape item in loadedShapesXml)
        {
            WriteLine("{0} is {1} and has an area of {2:N2}",
            item.GetType().Name, item.Colour, item.Area);
        }
    }
}