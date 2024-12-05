using System;
using System.Collections.Generic;

namespace StackExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Stack Declaration
            Stack<int> stack = new Stack<int>();

            // 2. Push (Add an Item to the Stack)
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            // 3. Pop (Remove and Return the Top Item)
            int topItem = stack.Pop();
            Console.WriteLine($"Popped: {topItem}"); // Output: Popped: 30

            // 4. Peek (View the Top Item Without Removing It)
            topItem = stack.Peek();
            Console.WriteLine($"Peek: {topItem}"); // Output: Peek: 20

            // 5. Check the Count
            Console.WriteLine($"Stack Count: {stack.Count}"); // Output: Stack Count: 2

            // 6. Check if the Stack is Empty
            if (stack.Count == 0)
            {
                Console.WriteLine("The stack is empty.");
            }

            // 7. Iterate Through a Stack
            Console.WriteLine("Items in Stack:");
            foreach (int item in stack)
            {
                Console.WriteLine(item);
            }
            // Output:
            // Items in Stack:
            // 20
            // 10

            // 8. Example Usage
            Stack<string> stringStack = new Stack<string>();

            // Push items onto the stack
            stringStack.Push("First");
            stringStack.Push("Second");
            stringStack.Push("Third");

            // Peek at the top item
            Console.WriteLine($"Peek: {stringStack.Peek()}"); // Output: Third

            // Pop items from the stack
            while (stringStack.Count > 0)
            {
                Console.WriteLine($"Popped: {stringStack.Pop()}");
            }
            // Output:
            // Popped: Third
            // Popped: Second
            // Popped: First
        }
    }
}

// Summary Table
// +-----------------------------+------------------------------------------------+
// | Task                        | Example Usage                                   |
// +-----------------------------+------------------------------------------------+
// | Stack Declaration           | Stack<int> stack = new Stack<int>();           |
// | Push (Add Item)             | stack.Push(10);                                |
// | Pop (Remove Item)           | int topItem = stack.Pop();                     |
// | Peek (View Top Item)        | int topItem = stack.Peek();                    |
// | Check Count                 | int count = stack.Count;                       |
// | Check if Empty              | if (stack.Count == 0) { ... }                  |
// | Iterate Through Stack       | foreach (int item in stack) { ... }            |
// +-----------------------------+------------------------------------------------+
// | Applications                | Expression evaluation, reversing strings,      |
// |                             | undo/redo functionality, backtracking.         |
// +-----------------------------+------------------------------------------------+
