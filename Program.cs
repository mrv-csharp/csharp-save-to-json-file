// SAVE TO JSON DEMO by MR. V

//*********************************************************************************
// Demo of how to save Data to a file as JSON
// JSON stands for JavaScript Object Notation
// It is a notation for representing data
// JSON may be used to convert data to a string and vice versa
// *********************************************************************************

// Import JSON module
using System.Text.Json;

// Create some data (List of Point Objects)
List<Point> points = new List<Point>();
points.Add(new Point(11, 1));
points.Add(new Point(21, 2));
points.Add(new Point(31, 3));

// Use the JSON Serialize method to convert point data to a json string
string jsonString = JsonSerializer.Serialize(points);

// Write the jsonString to a file
File.WriteAllText("point-data.json", jsonString);

class Point
{
    // Properties
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }

    public override string ToString()
    {
        return $"({this.X},{this.Y})";
    }
}