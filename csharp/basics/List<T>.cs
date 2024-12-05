// Create a List
//using System.Collections.Generic;

List<int> numbers = new List<int>(); // Empty list
List<string> names = new List<string> { "Alice", "Bob", "Charlie" }; // Initialized list

// Add Elements to a List

List<int> numbers = new List<int>();
numbers.Add(1);
numbers.AddRange(new int[] { 10, 15, 20 });

// Access Elements in a List
int firstNumber = numbers[0];
Console.WriteLine(firstNumber);

foreach (int number in numbers)
{
    Console.WriteLine(number);
}

for (int i = 0; i < numbers.Count; i++)
{
    Console.WriteLine(numbers[i]);
}

// Check if a List Contains an Item

if (numbers.Contains(10))
{
    Console.WriteLine("The list contains 10.");
}

// Find the Index of an Item in a List

if (numbers.Contains(10))
{
    Console.WriteLine("The list contains 10.");
}

// Find Elements in a List
int found = numbers.Find(x => x > 10);
Console.WriteLine(found); // First number greater than 10

List<int> greaterThanTen = numbers.FindAll(x => x > 10);
greaterThanTen.ForEach(x => Console.WriteLine(x));

int index = numbers.IndexOf(15);
Console.WriteLine(index);

// Remove Elements from a List
numbers.Remove(10); // Remove by value:

numbers.RemoveAt(0); // Remove by index

numbers.RemoveAll(x => x > 15); // Remove all numbers greater than 15

numbers.Clear(); // Remove all elements

// Get the last item using Linq Last() method
lastItem = myList.Last();

// Sort a List
numbers.Sort(); // Sort in ascending order

numbers.Sort((a, b) => b.CompareTo(a)); // Sort in descending order

// Reverse a List
numbers.Reverse();

// Count Elements in a List
int count = numbers.Count;
Console.WriteLine($"The list contains {count} elements.");

// Convert a List to an Array
int[] array = numbers.ToArray();

// Filter or Transform a List
//using System.Linq;

var evenNumbers = numbers.Where(x => x % 2 == 0).ToList();
evenNumbers.ForEach(x => Console.WriteLine(x)); // Using LINQ to filter

var squares = numbers.Select(x => x * x).ToList();
squares.ForEach(x => Console.WriteLine(x)); // Using LINQ to transform

// Add or Insert Elements at a Specific Position
numbers.Insert(0, 5); // Insert 5 at the beginning

// Merge Two Lists

List<int> moreNumbers = new List<int> { 100, 200, 300 };
numbers.AddRange(moreNumbers);

// Distinct Elements
//using System.Linq;

List<int> distinctNumbers = numbers.Distinct().ToList();
distinctNumbers.ForEach(x => Console.WriteLine(x)); // To get unique elements in a list

// Check if List is Empty
if (!numbers.Any())
{
    Console.WriteLine("The list is empty.");
}
}

// Copy a List
List<int> copy = new List<int>(numbers);

// Join List Elements into a String
//using System;

List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
string joined = string.Join(", ", names);
Console.WriteLine(joined); // Output: Alice, Bob, Charlie

// Compare Two Lists
bool areEqual = numbers.SequenceEqual(otherNumbers);
Console.WriteLine(areEqual); // For equality (same elements in same order)

bool isSubset = numbers.All(x => otherNumbers.Contains(x));
Console.WriteLine(isSubset); // For subset (all elements in numbers are in otherNumbers)

// Group Elements
//using System.Linq;

var grouped = numbers.GroupBy(x => x % 2 == 0 ? "Even" : "Odd");
foreach (var group in grouped)
{
    Console.WriteLine($"{group.Key}: {string.Join(", ", group)}");
} // Group list elements based on a condition

// Parallel Processing with Lists
//using System.Threading.Tasks
// Note: For large lists, you can use parallel processing

List<int> results = new List<int>();
Parallel.ForEach(numbers, number =>
{
    // Perform some parallel processing
    results.Add(number * 2);
});

// Sorting a List of Strings
//
var myList = new List<string> { "leaf", "cherry", "fish" };

// Using the Sort method
myList.Sort();

// Using the Sort method with StringComparison.OrdinalIgnoreCase for case-insensitive sorting
myList.Sort(StringComparer.OrdinalIgnoreCase);

// Using the OrderBy method with LINQ
var sortedList = myList.OrderBy(x => x).ToList();

// Using the OrderBy method with LINQ for case-insensitive sorting
var sortedIgnoreCaseList = myList.OrderBy(x => x, StringComparer.OrdinalIgnoreCase).ToList();


// Examples:
// Statically defined list
List<int> myList = new List<int> { 2, 5, 6 };
// Appending using Add()
myList.Add(5);  // [2, 5, 6, 5]
// Appending using AddRange()
myList.AddRange(new List<int> { 9 });  // [2, 5, 6, 5, 9]
// Appending using Insert()
myList.Insert(myList.Count, -4);  // [2, 5, 6, 5, 9, -4]
// Appending using InsertRange()
myList.InsertRange(myList.Count, new List<int> { 3 });  // [2, 5, 6, 5, 9, -4, 3]
