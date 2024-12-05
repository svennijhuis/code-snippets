// String is null or empty.
string str = "";

if (string.IsNullOrEmpty(str))
{
    Console.WriteLine("String is null or empty.");
}

if (string.IsNullOrWhiteSpace(str))
{
    Console.WriteLine("String is null, empty, or whitespace.");
}

// Arrays
int[] array = new int[0];

if (array == null || array.Length == 0)
{
    Console.WriteLine("Array is null or empty.");
}

// Collections (e.g., Lists, Dictionaries)
// Note: This will not work for arrays.

List<int> list = new List<int>();

if (list == null || list.Count == 0)
{
    Console.WriteLine("List is null or empty.");
}

Dictionary<string, int> dictionary = new Dictionary<string, int>();

if (dictionary == null || dictionary.Count == 0)
{
    Console.WriteLine("Dictionary is null or empty.");
}
