using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // 1. map in C#
        // JavaScript: const numbers = [1, 2, 3]; const doubled = numbers.map(n => n * 2);
        int[] numbers = { 1, 2, 3 };
        var doubled = numbers.Select(n => n * 2).ToArray();
        Console.WriteLine("Map - Select: " + string.Join(", ", doubled)); // Output: 2, 4, 6

        // 2. filter in C#
        // JavaScript: const numbers = [1, 2, 3, 4]; const evens = numbers.filter(n => n % 2 === 0);
        numbers = new int[] { 1, 2, 3, 4 };
        var evens = numbers.Where(n => n % 2 == 0).ToArray();
        Console.WriteLine("Filter - Where: " + string.Join(", ", evens)); // Output: 2, 4

        // 3. pop in C#
        // JavaScript: const numbers = [1, 2, 3]; const last = numbers.pop();
        List<int> numbersList = new List<int> { 1, 2, 3 };
        int last = numbersList[^1]; // Get the last element
        numbersList.RemoveAt(numbersList.Count - 1); // Remove the last element
        Console.WriteLine("Pop - RemoveAt: " + last); // Output: 3
        Console.WriteLine("List after pop: " + string.Join(", ", numbersList)); // Output: 1, 2

        // 4. find in C#
        // JavaScript: const numbers = [1, 2, 3, 4]; const firstEven = numbers.find(n => n % 2 === 0);
        numbers = new int[] { 1, 2, 3, 4 };
        int firstEven = numbers.FirstOrDefault(n => n % 2 == 0);
        Console.WriteLine("Find - FirstOrDefault: " + firstEven); // Output: 2

        // 5. reduce in C#
        // JavaScript: const numbers = [1, 2, 3]; const sum = numbers.reduce((acc, n) => acc + n, 0);
        numbers = new int[] { 1, 2, 3 };
        int sum = numbers.Aggregate(0, (acc, n) => acc + n);
        Console.WriteLine("Reduce - Aggregate: " + sum); // Output: 6

        // 6. push in C#
        // JavaScript: const numbers = [1, 2]; numbers.push(3);
        numbersList = new List<int> { 1, 2 };
        numbersList.Add(3);
        Console.WriteLine("Push - Add: " + string.Join(", ", numbersList)); // Output: 1, 2, 3

        // 7. slice in C#
        // JavaScript: const numbers = [1, 2, 3, 4]; const slice = numbers.slice(1, 3);
        numbers = new int[] { 1, 2, 3, 4 };
        var slice = numbers.Skip(1).Take(2).ToArray();
        Console.WriteLine("Slice - Skip + Take: " + string.Join(", ", slice)); // Output: 2, 3

        // 8. includes in C#
        // JavaScript: const numbers = [1, 2, 3]; console.log(numbers.includes(2));
        numbers = new int[] { 1, 2, 3 };
        Console.WriteLine("Includes - Contains (2): " + numbers.Contains(2)); // Output: True
        Console.WriteLine("Includes - Contains (4): " + numbers.Contains(4)); // Output: False

        // 9. forEach in C#
        // JavaScript: const numbers = [1, 2, 3]; numbers.forEach(n => console.log(n));
        Console.WriteLine("ForEach - Foreach loop:");
        foreach (int n in numbers)
        {
            Console.WriteLine(n);
        }

        numbersList = new List<int> { 1, 2, 3 };
        Console.WriteLine("ForEach - List.ForEach method:");
        numbersList.ForEach(n => Console.WriteLine(n));

        // 10. some in C#
        // JavaScript: const numbers = [1, 2, 3]; const hasEven = numbers.some(n => n % 2 === 0);
        numbers = new int[] { 1, 2, 3 };
        bool hasEven = numbers.Any(n => n % 2 == 0);
        Console.WriteLine("Some - Any: " + hasEven); // Output: True

        // 11. every in C#
        // JavaScript: const numbers = [2, 4, 6]; const allEven = numbers.every(n => n % 2 === 0);
        numbers = new int[] { 2, 4, 6 };
        bool allEven = numbers.All(n => n % 2 == 0);
        Console.WriteLine("Every - All: " + allEven); // Output: True

        // 12. shift in C#
        // JavaScript: const numbers = [1, 2, 3]; const first = numbers.shift();
        numbersList = new List<int> { 1, 2, 3 };
        int first = numbersList[0]; // Get the first element
        numbersList.RemoveAt(0); // Remove the first element
        Console.WriteLine("Shift - RemoveAt(0): " + first); // Output: 1
        Console.WriteLine("List after shift: " + string.Join(", ", numbersList)); // Output: 2, 3

        // 13. unshift in C#
        // JavaScript: const numbers = [2, 3]; numbers.unshift(1);
        numbersList = new List<int> { 2, 3 };
        numbersList.Insert(0, 1); // Insert 1 at the beginning
        Console.WriteLine("Unshift - Insert(0, 1): " + string.Join(", ", numbersList)); // Output: 1, 2, 3

        // 14. concat in C#
        // JavaScript: const arr1 = [1, 2]; const arr2 = [3, 4]; const combined = arr1.concat(arr2);
        int[] arr1 = { 1, 2 };
        int[] arr2 = { 3, 4 };
        var combined = arr1.Concat(arr2).ToArray();
        Console.WriteLine("Concat - Concat: " + string.Join(", ", combined)); // Output: 1, 2, 3, 4

        // 15. indexOf in C#
        // JavaScript: const numbers = [1, 2, 3]; const index = numbers.indexOf(2);
        numbers = new int[] { 1, 2, 3 };
        int index = Array.IndexOf(numbers, 2);
        Console.WriteLine("IndexOf - IndexOf: " + index); // Output: 1

        // 16. reverse in C#
        // JavaScript: const numbers = [1, 2, 3]; numbers.reverse();
        numbers = new int[] { 1, 2, 3 };
        Array.Reverse(numbers);
        Console.WriteLine("Reverse - Array.Reverse: " + string.Join(", ", numbers)); // Output: 3, 2, 1

        // 17. flat in C#
        // JavaScript: const nested = [[1, 2], [3, 4]]; const flat = nested.flat();
        int[][] nested = { new int[] { 1, 2 }, new int[] { 3, 4 } };
        var flat = nested.SelectMany(arr => arr).ToArray();
        Console.WriteLine("Flat - SelectMany: " + string.Join(", ", flat)); // Output: 1, 2, 3, 4

        // 18. splice in C#
        // JavaScript: const numbers = [1, 2, 3, 4]; numbers.splice(1, 2);
        numbersList = new List<int> { 1, 2, 3, 4 };
        numbersList.RemoveRange(1, 2); // Remove 2 and 3
        Console.WriteLine("Splice - RemoveRange: " + string.Join(", ", numbersList)); // Output: 1, 4
        numbersList.InsertRange(1, new int[] { 5, 6 }); // Insert 5 and 6 at index 1
        Console.WriteLine("Splice - InsertRange: " + string.Join(", ", numbersList)); // Output: 1, 5, 6, 4

        // 19. sort in C#
        // JavaScript: const numbers = [3, 1, 2]; numbers.sort();
        numbers = new int[] { 3, 1, 2 };
        Array.Sort(numbers);
        Console.WriteLine("Sort - Array.Sort: " + string.Join(", ", numbers)); // Output: 1, 2, 3

        // 20. fill in C#
        // JavaScript: const numbers = new Array(5).fill(0);
        numbers = Enumerable.Repeat(0, 5).ToArray();
        Console.WriteLine("Fill - Enumerable.Repeat: " + string.Join(", ", numbers)); // Output: 0, 0, 0, 0, 0

        // 21. Chaining Methods (Map, Filter, etc.) in C#
        // JavaScript: const numbers = [1, 2, 3, 4]; const result = numbers.filter(n => n % 2 === 0).map(n => n * 2);
        numbers = new int[] { 1, 2, 3, 4 };
        var result = numbers.Where(n => n % 2 == 0).Select(n => n * 2).ToArray();
        Console.WriteLine("Chaining - Where + Select: " + string.Join(", ", result)); // Output: 4, 8

        // Summary Table
        // +-----------------+------------------+
        // | JavaScript      | C# Equivalent    |
        // +-----------------+------------------+
        // | map             | Select           |
        // | filter          | Where            |
        // | pop             | RemoveAt         |
        // | find            | FirstOrDefault   |
        // | reduce          | Aggregate        |
        // | push            | Add (List)       |
        // | slice           | Skip + Take      |
        // | includes        | Contains         |
        // | forEach         | foreach          |
        // | some            | Any              |
        // | every           | All              |
        // | shift           | RemoveAt(0)      |
        // | unshift         | Insert(0, value) |
        // | concat          | Concat           |
        // | indexOf         | IndexOf          |
        // | reverse         | Reverse          |
        // | flat            | SelectMany       |
        // | splice          | RemoveRange/InsertRange |
        // | sort            | Sort             |
        // | fill            | Enumerable.Repeat|
        // +-----------------+------------------+
    }
}
