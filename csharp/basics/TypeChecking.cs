using System;

class TypeCheckingExample
{
    static void Main()
    {
        // 'is' and 'as' Keywords Example
        // When to use: Use 'is' to safely check an object's type before accessing it, and 'as' for attempting to cast an object to a type without throwing an exception if the cast fails.
        object obj = "This is a string";
        if (obj is string str)
        {
            Console.WriteLine($"The object is a string: {str}"); // Output: The object is a string: This is a string
        }

        obj = 42;
        string castStr = obj as string;
        Console.WriteLine(castStr ?? "Conversion failed"); // Output: Conversion failed
    }
}
