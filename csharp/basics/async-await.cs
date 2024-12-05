using System;
using System.Threading.Tasks;

namespace AsyncAwaitExample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // 1. Simple Async/Await Example
            Console.WriteLine("Start");
            await PerformTask();
            Console.WriteLine("End");
            // Output:
            // Start
            // Task started...
            // Task completed!
            // End

            // 2. Returning a Value from an Async Method
            int result = await CalculateSumAsync(5, 10);
            Console.WriteLine($"Result: {result}"); // Output: Result: 15

            // 3. Handling Exceptions in Async Methods
            try
            {
                result = await DivideAsync(10, 0);
                Console.WriteLine($"Result: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}"); // Output: Error: Attempted to divide by zero.
            }

            // 4. Parallel Tasks with Task.WhenAll
            Task task1 = PerformTaskAsync("Task 1", 2000);
            Task task2 = PerformTaskAsync("Task 2", 1000);
            Task task3 = PerformTaskAsync("Task 3", 1500);

            await Task.WhenAll(task1, task2, task3);
            Console.WriteLine("All tasks completed!"); // Output: All tasks completed!

            // 5. Running Tasks in Background
            result = await Task.Run(() => LongRunningCalculation(5));
            Console.WriteLine($"Background Task Result: {result}"); // Output: Background Task Result: 25
        }

        static async Task PerformTask()
        {
            Console.WriteLine("Task started...");
            await Task.Delay(2000); // Simulates a 2-second delay
            Console.WriteLine("Task completed!");
        }

        static async Task<int> CalculateSumAsync(int a, int b)
        {
            await Task.Delay(1000); // Simulate delay
            return a + b;
        }

        static async Task<int> DivideAsync(int a, int b)
        {
            await Task.Delay(500); // Simulate delay
            return a / b; // Will throw DivideByZeroException if b is 0
        }

        static async Task PerformTaskAsync(string name, int delay)
        {
            Console.WriteLine($"{name} started...");
            await Task.Delay(delay);
            Console.WriteLine($"{name} completed!");
        }

        static int LongRunningCalculation(int input)
        {
            // Simulate a long-running operation
            System.Threading.Thread.Sleep(2000);
            return input * input;
        }
    }
}

// Summary Table
// +------------------------+---------------------------------------------------+
// | Concept                | Description                                       |
// +------------------------+---------------------------------------------------+
// | async                  | Marks a method as asynchronous, enabling await.   |
// | await                  | Suspends method execution until the task completes.|
// | Task                   | Represents an asynchronous operation.            |
// | Task.Delay             | Simulates asynchronous delay.                    |
// | Task.Run               | Runs a task on a background thread.              |
// | Task.WhenAll           | Waits for multiple tasks to complete.            |
// | Exception Handling     | Use try-catch with await to handle exceptions.   |
// +------------------------+---------------------------------------------------+
