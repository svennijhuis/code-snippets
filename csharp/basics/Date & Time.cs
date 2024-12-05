// DateAndTimeExample.cs
using System;

class DateAndTimeExample
{
    static void Main()
    {
        // 1. Get the Current Date and Time
        DateTime currentDate = DateTime.Now;
        Console.WriteLine($"Current Date and Time: {currentDate}"); // Output: Current Date and Time: (current date and time)

        // 2. Get Only the Date
        DateTime currentDateOnly = DateTime.Today;
        Console.WriteLine($"Current Date: {currentDateOnly.ToString("dd-MM-yyyy")}"); // Output: Current Date: (e.g., 05-12-2024)

        // 3. Format the Date
        string formattedDate = currentDate.ToString("dddd, dd MMMM yyyy");
        Console.WriteLine($"Formatted Date: {formattedDate}"); // Output: Formatted Date: (e.g., Thursday, 05 December 2024)

        // 4. Add/Subtract Time
        DateTime futureDate = currentDate.AddDays(10); // Adds 10 days to the current date
        Console.WriteLine($"Future Date (+10 days): {futureDate:dd-MM-yyyy}"); // Output: Future Date (+10 days): (e.g., 15-12-2024)

        DateTime pastDate = currentDate.AddMonths(-2); // Subtracts 2 months from the current date
        Console.WriteLine($"Past Date (-2 months): {pastDate:dd-MM-yyyy}"); // Output: Past Date (-2 months): (e.g., 05-10-2024)

        // 5. Calculate Difference Between Dates
        DateTime specificDate = new DateTime(2024, 12, 31);
        TimeSpan dateDifference = specificDate - currentDate;
        Console.WriteLine($"Days until {specificDate:dd-MM-yyyy}: {dateDifference.Days}"); // Output: Days until 31-12-2024: (number of days)

        // 6. Displaying Only Time
        DateTime currentTime = DateTime.Now;
        string formattedTime = currentTime.ToString("HH:mm:ss");
        Console.WriteLine($"Current Time: {formattedTime}"); // Output: Current Time: (e.g., 14:35:42)

        // 7. Parse Date from String
        string dateString = "05-12-2024";
        if (DateTime.TryParseExact(dateString, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime parsedDate))
        {
            Console.WriteLine($"Parsed Date: {parsedDate:dd-MM-yyyy}"); // Output: Parsed Date: 05-12-2024
        }
        else
        {
            Console.WriteLine("Invalid date format.");
        }

        // 8. Using DateTimeOffset for Time Zones
        DateTimeOffset dateTimeOffset = DateTimeOffset.Now;
        Console.WriteLine($"Current Date and Time with Offset: {dateTimeOffset}"); // Output: Current Date and Time with Offset: (e.g., 05-12-2024 14:35:42 +00:00)
    }
}

// Summary Table
// +----------------------------+-----------------------------------------------------------+-----------------------------------+
// | Concept                    | Description                                               | Example                           |
// +----------------------------+-----------------------------------------------------------+-----------------------------------+
// | Current Date and Time      | Gets the current date and time.                           | DateTime.Now;                     |
// | Current Date Only          | Gets only the current date, without time.                 | DateTime.Today;                   |
// | Format Date                | Format the date to a readable string.                     | currentDate.ToString("dd-MM-yyyy");|
// | Add/Subtract Time          | Add or subtract days, months, years.                      | currentDate.AddDays(10);          |
// | Date Difference            | Calculate the number of days between two dates.           | specificDate - currentDate;       |
// | Display Time Only          | Format and display only the time part of DateTime.        | currentTime.ToString("HH:mm:ss"); |
// | Parse Date from String     | Convert a string to a DateTime object.                    | DateTime.TryParseExact(...);      |
// | DateTimeOffset             | Handle date and time with timezone offset.                | DateTimeOffset.Now;               |
// +----------------------------+-----------------------------------------------------------+-----------------------------------+
