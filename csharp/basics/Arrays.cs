// Create and Initialize Arrays
int[] numbers = new int[5]; // Array of size 5 - Declare and initialize an array with a fixed size

int[] numbers = { 1, 2, 3, 4, 5 }; // Declare and initialize an array with values

// Access and Modify Elements

int first = numbers[0]; // Access the first element (index 0)

numbers[0] = 10; // Modify the first element

// Iterate Through an Array

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}

foreach (int number in numbers)
{
    Console.WriteLine(number);
}

// Check if an Array Contains a Value

if (numbers.Contains(3))
{
    Console.WriteLine("The array contains 3.");
}

// Sort an Array

Array.Sort(numbers); // Sort in ascending order

Array.Sort(numbers);
Array.Reverse(numbers); // Sort in descending order

// Find Elements in an Array

int found = Array.Find(numbers, x => x > 2);
Console.WriteLine(found); // Output: first number greater than 2 - Find the first match

int[] greaterThanTwo = Array.FindAll(numbers, x => x > 2); // Find all matches

// Resize an Array

Array.Resize(ref numbers, 10); // Resize to 10 elements - Arrays are fixed in size, but you can resize using Array.Resize

// Convert an Array to a List

List<int> numberList = numbers.ToList(); // Convert array to list

// Copy an Array

int[] copy = new int[numbers.Length];
Array.Copy(numbers, copy, numbers.Length); // Shallow copy

int[] clone = (int[])numbers.Clone(); // Deep copy

// Reverse an Array

Array.Reverse(numbers);
