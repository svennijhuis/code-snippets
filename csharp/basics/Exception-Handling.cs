try
{
    // Code that might throw an exception.
}
catch (SpecificException ex) // Catches specific exceptions, allowing tailored responses.
{
    // Handle this specific error.
}
finally
{
    // Cleanup code. Executes regardless of whether an exception was thrown.
}


// Other option
try
{
    // Code that may throw different exceptions
}
catch (FileNotFoundException ex)
{
    Console.WriteLine($"File not found: {ex.FileName}");
}
catch (IOException ex)
{
    Console.WriteLine($"I/O error: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"General error: {ex.Message}");
}
