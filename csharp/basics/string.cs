// Check if a String Contains a Substring

string text = "Hello, world!";
if (text.Contains("world"))
{
    Console.WriteLine("The string contains 'world'.");
}


// Case-Insensitive Check

string text = "Hello, world!";
if (text.IndexOf("WORLD", StringComparison.OrdinalIgnoreCase) >= 0)
{
    Console.WriteLine("The string contains 'world' (case-insensitive).");
}

// Use Regular Expressions
// using System.Text.RegularExpressions;

string text = "Hello, world!";
if (Regex.IsMatch(text, @"\bworld\b"))
{
    Console.WriteLine("The string contains 'world' as a whole word.");
}

// Get the Index of a Substring

string text = "Hello, world!";
int index = text.IndexOf("world");
if (index >= 0)
{
    Console.WriteLine($"'world' found at index {index}.");
}
else
{
    Console.WriteLine("'world' not found.");
}

// Replace a Substring

string text = "Hello, world!";
string newText = text.Replace("world", "C#");
Console.WriteLine(newText); // Output: Hello, C#!

// Split a String

string text = "Hello, world!";
string[] parts = text.Split(',');
foreach (var part in parts)
{
    Console.WriteLine(part.Trim());
}

// Check if a String Starts or Ends with a Substring

if (text.StartsWith("Hello"))
{
    Console.WriteLine("The string starts with 'Hello'.");
}

if (text.EndsWith("world!"))
{
    Console.WriteLine("The string ends with 'world!'.");
}

// Extract Part of a String

string text = "Hello, world!";
string part = text.Substring(7); // Extracts everything from index 7 onward
Console.WriteLine(part); // Output: world!

// Extract a specific range
string range = text.Substring(7, 5); // Extracts 5 characters starting at index 7
Console.WriteLine(range); // Output: world

// Check if a String Matches a Specific Pattern
string text = "Hello, world!";
if (text.StartsWith("Hello") && text.Contains("world") && text.EndsWith("!"))
{
    Console.WriteLine("The string matches the pattern.");
}

// Remove Parts of a String
string text = "Hello, world!";
string withoutHello = text.Remove(0, 7); // Removes first 7 characters
Console.WriteLine(withoutHello); // Output: world!


// Trim Whitespace or Specific Characters
string text = "   Hello, world!   ";
string trimmed = text.Trim(); // Removes whitespace
Console.WriteLine(trimmed); // Output: Hello, world!

// Trim specific characters
string specialTrim = text.Trim(' ', '!'); // Removes spaces and exclamation marks
Console.WriteLine(specialTrim); // Output: Hello, world

// Count Occurrences of a Substring
string text = "Hello, world! Hello again!";
int count = text.Split("Hello").Length - 1; // Subtract 1 because Split adds one more part
Console.WriteLine($"'Hello' appears {count} times.");

// Using LINQ for Complex Searches
//using System.Linq;

string text = "Hello, world! Hello again!";
int helloCount = text.Split(' ').Count(word => word.Contains("Hello"));
Console.WriteLine($"'Hello' appears {helloCount} times in the split words.");


// String Manipulation
string.Concat(); // Combines multiple strings.
string.Join(); // Joins elements with a separator.
str.Split(); // Splits a string based on delimiters.
str.ToUpper(); // Converts to uppercase.
str.ToLower(); // Converts to lowercase.
str.Trim(); // Removes leading and trailing whitespace.
str.Substring(); // Extracts a portion of the string.


// Comparing Strings
string player1 = "Crosby";
string player2 = "Malkin";
string player3 = "Guentzel";

// Brute force comparison (equality only)
bool isSamePlayer = player1.Length == player3.Length;
if (isSamePlayer)
{
    for (int i = 0; i < player1.Length; i++)
    {
        if (player1[i] != player3[i])
        {
            isSamePlayer = false;
            break;
        }
    }
}

// Direct comparison
bool isEqual = player1 == player3; // False
bool isGreater = player1.CompareTo(player3) > 0; // False
bool isLessOrEqual = player2.CompareTo(player2) <= 0; // True

// Reference checking
bool isSameReference = ReferenceEquals(player1, player1); // True
bool isDifferentReference = ReferenceEquals(player2, player1); // False


// Checking for Substrings
string[] addresses = {
    "123 Elm Street",
    "531 Oak Street",
    "678 Maple Street"
};

string street = "Elm Street";

// Brute force (not recommended)
foreach (string address in addresses)
{
    int addressLength = address.Length;
    int streetLength = street.Length;
    for (int index = 0; index <= addressLength - streetLength; index++)
    {
        string substring = address.Substring(index, streetLength);
        if (substring == street)
        {
            Console.WriteLine(address);
        }
    }
}

// The IndexOf() method
foreach (string address in addresses)
{
    if (address.IndexOf(street) >= 0)
    {
        Console.WriteLine(address);
    }
}

// The Contains() method (preferred)
foreach (string address in addresses)
{
    if (address.Contains(street))
    {
        Console.WriteLine(address);
    }
}
