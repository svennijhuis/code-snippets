using System;

class StructExample
{
    static void Main()
    {
        // Struct Type Example
        // When to use: Use structs for small, lightweight data types that are not intended to be modified. Useful for representing geometric coordinates or points in space, especially when performance is critical.
        struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
    Point point = new Point { X = 10, Y = 20 };
    Console.WriteLine($"Point: ({point.X}, {point.Y})"); // Output: Point: (10, 20)
    }
}
