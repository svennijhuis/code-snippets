using System;

namespace EnumExample
{
    public enum DaysOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    public enum Status
    {
        InProgress = 1,
        Completed = 2,
        Failed = 3
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 1. Enum (Enumeration)
            // Declaration & Usage
            DaysOfWeek today = DaysOfWeek.Friday;

            if (today == DaysOfWeek.Friday)
            {
                Console.WriteLine("It's Friday!");
            }

            // 2. Custom Values in Enum
            Status currentStatus = Status.Completed;
            Console.WriteLine("Current Status: " + currentStatus);
            // Output: Current Status: Completed

            // 3. Convert Enum to String
            string statusName = currentStatus.ToString();
            Console.WriteLine("Convert Enum to String: " + statusName); // Output: Completed

            // 4. Convert String to Enum
            Status parsedStatus = Enum.Parse<Status>("Completed");
            Console.WriteLine("Convert String to Enum: " + (int)parsedStatus); // Output: 2

            // 5. Get All Enum Values
            Console.WriteLine("All Enum Values:");
            foreach (var status in Enum.GetValues(typeof(Status)))
            {
                Console.WriteLine(status);
            }
            // Output:
            // InProgress
            // Completed
            // Failed

            // 6. Use Enum in a .NET Scenario - Switch Case Example
            switch (today)
            {
                case DaysOfWeek.Monday:
                    Console.WriteLine("Start of the workweek.");
                    break;
                case DaysOfWeek.Friday:
                    Console.WriteLine("It's almost the weekend!");
                    break;
                case DaysOfWeek.Saturday:
                case DaysOfWeek.Sunday:
                    Console.WriteLine("Weekend vibes!");
                    break;
                default:
                    Console.WriteLine("Just another weekday.");
                    break;
            }

            // 7. Enum with Flags Attribute
            // This is useful when you need to represent combinations of values
            [Flags]
            public enum FileAccess
        {
            Read = 1,
            Write = 2,
            Execute = 4
        }

        FileAccess fileAccess = FileAccess.Read | FileAccess.Write;
        // Console.WriteLine("File Access Permissions: " + fileAccess);
        // Output: File Access Permissions: Read, Write
    }
}
}

// Summary Table
// +---------------------------+---------------------------------------------+
// | Task                      | Example Usage                               |
// +---------------------------+---------------------------------------------+
// | Enum Declaration          | enum DaysOfWeek { ... }                     |
// | Enum Usage                | DaysOfWeek today = DaysOfWeek.Friday;       |
// | Custom Values             | enum Status { InProgress = 1, ... }         |
// | Enum to String            | Status.Completed.ToString()                 |
// | String to Enum            | Enum.Parse<Status>("Completed")             |
// | Get All Enum Values       | Enum.GetValues(typeof(Status))              |
// | Switch Case with Enum     | switch(today) { case DaysOfWeek.Monday: ... }|
// | Flags Enum                | [Flags] enum FileAccess { Read = 1, ... }   |
// +---------------------------+---------------------------------------------+
