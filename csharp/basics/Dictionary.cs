// Create and Initialize a Dictionary
// using System.Collections.Generic;

Dictionary<int, string> dictionary = new Dictionary<int, string>();

Dictionary<int, string> dictionary = new Dictionary<int, string>
{
    { 1, "One" },
    { 2, "Two" },
    { 3, "Three" }
}; // Initialize with values

// Add Elements

Dictionary<int, string> dictionary = new Dictionary<int, string>();
dictionary.Add(1, "One");
dictionary.Add(2, "Two");

// Access Elements

string value = dictionary[1];
Console.WriteLine(value);

if (dictionary.ContainsKey(6))
{
    Console.WriteLine(dictionary[6]);
}
else
{
    Console.WriteLine("Key not found.");
} // Check if a key exists before accessing

// Update a Value

if (dictionary.ContainsKey(2))
{
    dictionary[2] = "Updated Two";
    Console.WriteLine("Value updated.");
}

// Remove Elements
dictionary.Remove(3); // Removes the key-value pair for key 3

dictionary.Clear(); // Removes all elements

// Check if a Key or Value Exists

if (dictionary.ContainsKey(1))
{
    Console.WriteLine("Key exists.");
} // Check if a key exists

if (dictionary.ContainsValue("One"))
{
    Console.WriteLine("Value exists.");
} // Check if a value exists

// Iterate Through a Dictionary

foreach (KeyValuePair<int, string> pair in dictionary)
{
    Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
}

foreach (int key in dictionary.Keys)
{
    Console.WriteLine(key);
}

foreach (string value in dictionary.Values)
{
    Console.WriteLine(value);
}

// Get Value Safely

if (dictionary.TryGetValue(2, out string value))
{
    Console.WriteLine($"Value: {value}");
}
else
{
    Console.WriteLine("Key not found.");
} // Use TryGetValue to avoid exceptions when a key is not found

// Count Elements

int count = dictionary.Count;

// Merge Two Dictionaries

Dictionary<int, string> anotherDictionary = new Dictionary<int, string>
{
    { 6, "Six" },
    { 7, "Seven" }
};

foreach (var kvp in anotherDictionary)
{
    if (!dictionary.ContainsKey(kvp.Key))
    {
        dictionary.Add(kvp.Key, kvp.Value);
    }
} // You can merge dictionaries, keeping unique keys

// Convert to Other Collections

List<KeyValuePair<int, string>> kvpList = dictionary.ToList(); // Convert to a list of key-value pairs

List<int> keys = dictionary.Keys.ToList();
List<string> values = dictionary.Values.ToList(); // Convert keys or values to a list

// Sort a Dictionary
// Note: Dictionaries are not inherently ordered, but you can sort them into a new collection

var sortedByKey = dictionary.OrderBy(kvp => kvp.Key).ToDictionary(kvp => kvp.Key, kvp => kvp.Value); // Sort by key

var sortedByValue = dictionary.OrderBy(kvp => kvp.Value).ToDictionary(kvp => kvp.Key, kvp => kvp.Value); // Sort by value

// Group by Key or Value

var groupedByKey = dictionary.GroupBy(kvp => kvp.Key).ToDictionary(g => g.Key, g => g.Select(kvp => kvp.Value).ToList()); // Use LINQ to group

// Work with Custom Objects
// Note: Dictionaries can also store custom objects

// class Person
// {
//     public string Name { get; set; }
//     public int Age { get; set; }
// }

// Dictionary<int, Person> people = new Dictionary<int, Person>
// {
//     { 1, new Person { Name = "Alice", Age = 30 } },
//     { 2, new Person { Name = "Bob", Age = 25 } }
// };

// Person person = people[1];
// Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");


// Thread-Safe Dictionary
// using System.Collections.Concurrent;

ConcurrentDictionary<int, string> concurrentDict = new ConcurrentDictionary<int, string>();

concurrentDict.AddOrUpdate(1, "One", (key, oldValue) => "Updated One"); //  Add or update atomically - For thread-safe operations, use ConcurrentDictionary from System.Collections.Concurrent

// Clear Dictionary Safely
lock (dictionary)
{
    dictionary.Clear();
}

// Compare Two Dictionaries - Compare keys and values
bool areEqual = dictionary.OrderBy(kvp => kvp.Key).SequenceEqual(anotherDictionary.OrderBy(kvp => kvp.Key));
Console.WriteLine($"Dictionaries are equal: {areEqual}");


// Merging Two Dictionaries
//
Dictionary<string, string> dict1 = new Dictionary<string, string> { { "Superman", "Flight" } };
Dictionary<string, string> dict2 = new Dictionary<string, string> { { "Batman", "Gadgets" } };

// Using LINQ
var merged = dict1.Concat(dict2).ToDictionary(x => x.Key, x => x.Value);

// Using a foreach loop
foreach (var item in dict2)
{
    dict1[item.Key] = item.Value;
}

// Using the Union extension method
var merged2 = dict1.Union(dict2).ToDictionary(x => x.Key, x => x.Value);

// Inverting a Dictionary

Dictionary<string, string> heroesAbilities = new Dictionary<string, string>
{
    { "Flash", "Super Speed" },
    { "Green Lantern", "Power Ring" },
    { "Aquaman", "Atlantean Strength" }
};

// Inverting the dictionary using LINQ
var inverted = heroesAbilities.ToDictionary(x => x.Value, x => x.Key);

// Inverting the dictionary using a foreach loop
Dictionary<string, string> inverted2 = new Dictionary<string, string>();
foreach (var item in heroesAbilities)
{
    inverted2[item.Value] = item.Key;
}
