using System;

class DynamicExample
{
    static void Main()
    {
        // Dynamic Type Example
        // When to use: Use dynamic when the type of the data is not known until runtime. This is particularly useful for interoperability scenarios, such as working with COM objects or dynamic JSON deserialization.
        dynamic dyn = "Hello";
        Console.WriteLine(dyn); // Output: Hello
        dyn = 123;
        Console.WriteLine(dyn); // Output: 123
    }
}
