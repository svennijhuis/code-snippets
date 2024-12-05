using System;

class Program
{
    static void Main()
    {
        // 1. Value Types
        // Numeric Types
        byte b = 255;
        sbyte sb = -128;
        short s = 32767;
        ushort us = 65535;
        int i = 1000;
        uint ui = 1000;
        long l = 1000L;
        ulong ul = 1000UL;
        float f = 1.5f;
        double d = 1.5;
        decimal dec = 1.5m;

        // Character and Boolean Types
        char c = 'A';
        bool isTrue = true;

        // Other Value Types
        struct Point { public int X, Y; }
    enum Color { Red, Green, Blue }

    // 2. Reference Types
    // String
    string sText = "Hello";

    // Object
    object obj = 42;

    // Dynamic
    dynamic dValue = "Hello";

    // Array
    int[] arr = { 1, 2, 3 };

    // Class
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    // Interface
    interface IVehicle
    {
        void Drive();
    }

    // Delegate
    delegate void MyDelegate();

    // 3. Nullable Types
    int? nullableInt = null;
        if (nullableInt.HasValue)
        {
            Console.WriteLine(nullableInt.Value);
        }
        else
{
    Console.WriteLine("null"); // Output: null
}

// 4. Common Type Aliases
int num = 100;           // System.Int32
string sAlias = "Text";  // System.String
bool flag = true;        // System.Boolean
float pi = 3.14f;        // System.Single
double dNum = 3.14;      // System.Double
decimal money = 10.99m;  // System.Decimal
object o = 42;           // System.Object
char charAlias = 'A';    // System.Char

// 5. Type Conversion
// Implicit Conversion
double implicitDouble = num; // Implicit conversion from int to double

// Explicit Conversion (Casting)
double explicitDouble = 100.5;
int explicitInt = (int)explicitDouble; // Explicit casting from double to int

// Using Convert Class
string strNumber = "123";
int convertedInt = Convert.ToInt32(strNumber);

// 6. var and dynamic
var implicitVar = "I'm a string";   // Resolved at compile time, type-safe
dynamic dynamicVar = 123;           // Resolved at runtime, not type-safe
dynamicVar = "Now I'm a string";

// Output Example Summary
Console.WriteLine($"{num}, {c}, {isTrue}, {sText}");
Console.WriteLine($"{nullableInt ?? 0}, {implicitVar}, {dynamicVar}");
    }
}

// Summary Tables

// Numeric Types
// +---------+-------------------------------+-----------------------------+-------------------+
// | Type    | Description                   | Size                        | Example           |
// +---------+-------------------------------+-----------------------------+-------------------+
// | byte    | Unsigned 8-bit integer        | 0 to 255                    | byte b = 255;     |
// | sbyte   | Signed 8-bit integer          | -128 to 127                 | sbyte sb = -128;  |
// | short   | Signed 16-bit integer         | -32,768 to 32,767           | short s = 32767;  |
// | ushort  | Unsigned 16-bit integer       | 0 to 65,535                 | ushort us = 65535;|
// | int     | Signed 32-bit integer         | -2,147,483,648 to 2,147,483,647 | int i = 1000;  |
// | uint    | Unsigned 32-bit integer       | 0 to 4,294,967,295          | uint ui = 1000;   |
// | long    | Signed 64-bit integer         | Very large range            | long l = 1000L;   |
// | ulong   | Unsigned 64-bit integer       | Very large range            | ulong ul = 1000UL;|
// | float   | Single-precision floating point | ±1.5 x 10⁻⁴⁵ to ±3.4 x 10³⁸ | float f = 1.5f;  |
// | double  | Double-precision floating point | ±5.0 × 10⁻³²⁴ to ±1.7 × 10³⁰⁸ | double d = 1.5; |
// | decimal | High-precision decimal (financial calculations) | ±1.0 × 10⁻²⁸ to ±7.9 × 10²⁸ | decimal dec = 1.5m; |
// +---------+-------------------------------+-----------------------------+-------------------+

// Character and Boolean Types
// +---------+-------------------------------+-----------+-------------------+
// | Type    | Description                   | Size      | Example           |
// +---------+-------------------------------+-----------+-------------------+
// | char    | A single Unicode character    | 16-bit    | char c = 'A';     |
// | bool    | Boolean, true or false        | 1-bit     | bool isTrue = true;|
// +---------+-------------------------------+-----------+-------------------+

// Other Value Types
// +---------+------------------------------------------+-------------------------+
// | Type    | Description                              | Example                 |
// +---------+------------------------------------------+-------------------------+
// | struct  | A structure (custom value type)          | struct Point { int X, Y; } |
// | enum    | Enumeration                              | enum Color { Red, Green, Blue } |
// +---------+------------------------------------------+-------------------------+

// Reference Types
// +---------+------------------------------------------+-------------------------+
// | Type    | Description                              | Example                 |
// +---------+------------------------------------------+-------------------------+
// | string  | Immutable sequence of characters         | string s = "Hello";     |
// | object  | Base type for all types                  | object obj = 42;        |
// | dynamic | Can store any type, resolved at runtime  | dynamic d = "Hello";    |
// | Array   | Fixed-size sequence of elements          | int[] arr = { 1, 2, 3 };|
// | class   | A blueprint for creating objects         | class Person { ... }    |
// | interface | Defines a contract for classes         | interface IVehicle { void Drive(); } |
// | delegate | References a method                     | delegate void MyDelegate(); |
// +---------+------------------------------------------+-------------------------+

// Common Type Aliases
// +--------+---------------------+-----------------------+
// | Alias  | .NET Framework Type | Example               |
// +--------+---------------------+-----------------------+
// | int    | System.Int32        | int num = 100;        |
// | string | System.String       | string s = "Text";    |
// | bool   | System.Boolean      | bool flag = true;     |
// | float  | System.Single       | float pi = 3.14f;     |
// | double | System.Double       | double d = 3.14;      |
// | decimal| System.Decimal      | decimal money = 10.99m; |
// | object | System.Object       | object obj = 42;      |
// | char   | System.Char         | char c = 'A';         |
// +--------+---------------------+-----------------------+
