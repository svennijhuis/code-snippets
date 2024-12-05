// foreach Loop
// When to Use
// To iterate through collections like arrays, lists, dictionaries, or other enumerable objects.
// When you don’t need to modify the collection or access the index.
int[] numbers = { 1, 2, 3, 4, 5 };

foreach (int number in numbers)
{
    Console.WriteLine(number);
}

List<string> names = new List<string> { "Alice", "Bob", "Charlie" };

foreach (string name in names)
{
    Console.WriteLine(name);
}

Dictionary<int, string> dictionary = new Dictionary<int, string>
{
    { 1, "One" },
    { 2, "Two" },
    { 3, "Three" }
};

foreach (KeyValuePair<int, string> kvp in dictionary)
{
    Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
}

// while Loop
// The while loop is used when you need to repeatedly execute code as long as a condition evaluates to true.
// When to Use
// When you need more control over the iteration process.
// When the number of iterations is unknown and depends on a condition.
// To perform conditional checks before executing the loop body.

while (condition)
{
    // Code to execute while the condition is true
}

int count = 5;

while (count > 0)
{
    Console.WriteLine($"Count: {count}");
    count--;
} // Example: Counting Down

string input = "";

while (input != "exit")
{
    Console.Write("Enter a command (type 'exit' to quit): ");
    input = Console.ReadLine();
} // Example: Reading Input Until a Condition

// do-while Loop
// The do-while loop is similar to the while loop, but it ensures the loop executes at least once, regardless of the condition.
// When to Use
// When you need the loop body to execute at least once before the condition is checked.

do
{
    // Code to execute
} while (condition);


string password;

do
{
    Console.Write("Enter your password: ");
    password = Console.ReadLine();
} while (password != "1234");

Console.WriteLine("Access granted."); // Example: Prompting for Input

// Breaking Out of Loops

foreach (int number in numbers)
{
    if (number == 3)
        break; // Exit the loop
    Console.WriteLine(number);
} // Example: Breaking Out of a foreach Loop

foreach (int number in numbers)
{
    if (number % 2 == 0)
        continue; // Skip even numbers
    Console.WriteLine(number);
} // Use continue to skip the rest of the current iteration


// Differences Between foreach, while, and do-while Loops in C#

// Feature comparison table:
// Feature            | foreach                        | while                           | do-while
// -------------------|--------------------------------|--------------------------------|--------------------------------
// Usage              | Iterates through collections  | Executes while condition is true | Executes once, then checks condition
// Condition Check    | Implicit (end of collection)  | Before loop starts              | After loop body executes
// Collection Support | Yes                           | No                              | No
// Minimum Iterations | 0                             | 0                               | 1
// Example Use        | Iterating arrays, lists       | Reading input until valid       | Input prompts, menu loops


// Choosing Between foreach and while
// Use foreach when:
// You're iterating over a collection or array.
// You don't need to modify the collection or use indices.
//
// Use while or do-while when:
// You need to loop based on a condition.
// The iteration depends on a condition rather than a collection.
// You need explicit control over the loop (e.g., using counters or breaking based on external input).
