class RecordExample
{
    static void Main()
    {
        // Record Type Example
        // When to use: Use records when you need an immutable data model, such as representing data that doesn't change after creation, like configuration settings or response data from an API.
        record PersonRecord(string Name, int Age);
        PersonRecord personRecord = new("Alice", 30);
        Console.WriteLine(personRecord); // Output: PersonRecord { Name = Alice, Age = 30 }
    }
}
