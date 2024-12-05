using System;

class CalculationExample
{
    static void Main()
    {
        // 1. Basic Arithmetic Operations
        int a = 10;
        int b = 5;

        int sum = a + b;          // Addition
        int difference = a - b;   // Subtraction
        int product = a * b;      // Multiplication
        double quotient = (double)a / b; // Division
        int remainder = a % b;    // Modulus

        Console.WriteLine($"Sum: {sum}");             // Output: Sum: 15
        Console.WriteLine($"Difference: {difference}"); // Output: Difference: 5
        Console.WriteLine($"Product: {product}");     // Output: Product: 50
        Console.WriteLine($"Quotient: {quotient}");   // Output: Quotient: 2.0
        Console.WriteLine($"Remainder: {remainder}"); // Output: Remainder: 0

        // 2. Using Math Class for Advanced Calculations
        double power = Math.Pow(a, 2);       // Power (a^2)
        double squareRoot = Math.Sqrt(a);    // Square root of a
        double sineValue = Math.Sin(a);      // Sine of a (in radians)
        double absoluteValue = Math.Abs(-10); // Absolute value of -10

        Console.WriteLine($"Power: {power}");           // Output: Power: 100
        Console.WriteLine($"Square Root: {squareRoot}"); // Output: Square Root: 3.16227766016838
        Console.WriteLine($"Sine Value: {sineValue}");   // Output: Sine Value: -0.54402111088937
        Console.WriteLine($"Absolute Value: {absoluteValue}"); // Output: Absolute Value: 10

        // 3. Rounding Operations
        double value = 3.14159;
        double roundedValue = Math.Round(value, 2); // Rounds to 2 decimal places

        Console.WriteLine($"Rounded Value: {roundedValue}"); // Output: Rounded Value: 3.14

        // 4. Parsing and Converting Numbers
        string strNumber = "123";
        if (int.TryParse(strNumber, out int parsedNumber))
        {
            Console.WriteLine($"Parsed Number: {parsedNumber}"); // Output: Parsed Number: 123
        }
        else
        {
            Console.WriteLine("Failed to parse the number.");
        }

        // 5. Simple Interest Calculation Example
        double principal = 1000; // Principal amount
        double rate = 5; // Interest rate
        double time = 3; // Time period in years

        double interest = (principal * rate * time) / 100;
        Console.WriteLine($"Simple Interest: {interest}"); // Output: Simple Interest: 150
    }
}

// Summary Table
// +----------------------------+-----------------------------------------------------------+-------------------------+
// | Concept                    | Description                                               | Example                 |
// +----------------------------+-----------------------------------------------------------+-------------------------+
// | Arithmetic Operations      | Basic addition, subtraction, multiplication, division.    | int sum = a + b;       |
// | Math Class                 | Advanced math functions like power, square root, etc.     | Math.Pow(a, 2);        |
// | Rounding Operations        | Rounding numbers to specific decimal places.              | Math.Round(value, 2);  |
// | Parsing and Converting     | Converting strings to numbers safely using TryParse.      | int.TryParse(...);     |
// | Simple Interest Calculation| Calculate simple interest using formula.                  | interest = (P * R * T) / 100; |
// +----------------------------+-----------------------------------------------------------+-------------------------+
