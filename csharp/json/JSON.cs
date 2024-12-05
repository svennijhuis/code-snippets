using System;
using System.Text.Json;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

class Program
{
    static void Main()
    {
        // 1. Serialize an Object to JSON
        // Using System.Text.Json
        var person = new
        {
            Name = "Alice",
            Age = 30,
            IsEmployed = true
        };

        string jsonString = JsonSerializer.Serialize(person);
        Console.WriteLine("System.Text.Json Serialize: " + jsonString);
        // Output: {"Name":"Alice","Age":30,"IsEmployed":true}

        // Using Newtonsoft.Json
        jsonString = JsonConvert.SerializeObject(person);
        Console.WriteLine("Newtonsoft.Json Serialize: " + jsonString);
        // Output: {"Name":"Alice","Age":30,"IsEmployed":true}

        // 2. Deserialize JSON to an Object
        // Using System.Text.Json
        jsonString = @"{\"Name\":\"Alice\",\"Age\":30,\"IsEmployed\":true}";
        var deserializedPerson = JsonSerializer.Deserialize<Person>(jsonString);
        Console.WriteLine($"System.Text.Json Deserialize: {deserializedPerson.Name}, {deserializedPerson.Age}, {deserializedPerson.IsEmployed}");

        // Using Newtonsoft.Json
        deserializedPerson = JsonConvert.DeserializeObject<Person>(jsonString);
        Console.WriteLine($"Newtonsoft.Json Deserialize: {deserializedPerson.Name}, {deserializedPerson.Age}, {deserializedPerson.IsEmployed}");

        // 3. Parse JSON Without Defining a Class
        // Using System.Text.Json
        using JsonDocument doc = JsonDocument.Parse(jsonString);
        JsonElement root = doc.RootElement;
        string name = root.GetProperty("Name").GetString();
        int age = root.GetProperty("Age").GetInt32();
        bool isEmployed = root.GetProperty("IsEmployed").GetBoolean();
        Console.WriteLine($"System.Text.Json Parse: {name}, {age}, {isEmployed}");

        // Using Newtonsoft.Json
        JObject jObject = JObject.Parse(jsonString);
        name = jObject["Name"].ToString();
        age = (int)jObject["Age"];
        isEmployed = (bool)jObject["IsEmployed"];
        Console.WriteLine($"Newtonsoft.Json Parse: {name}, {age}, {isEmployed}");

        // 4. Serialize and Deserialize Collections
        // Serialize a List to JSON
        var people = new List<Person>
        {
            new Person { Name = "Alice", Age = 30, IsEmployed = true },
            new Person { Name = "Bob", Age = 25, IsEmployed = false }
        };
        jsonString = JsonSerializer.Serialize(people);
        Console.WriteLine("System.Text.Json Serialize List: " + jsonString);
        // Output: [{"Name":"Alice","Age":30,"IsEmployed":true},{"Name":"Bob","Age":25,"IsEmployed":false}]

        // Deserialize JSON into a List
        jsonString = @"[
            {\"Name\":\"Alice\",\"Age\":30,\"IsEmployed\":true},
            {\"Name\":\"Bob\",\"Age\":25,\"IsEmployed\":false}
        ]";
        var deserializedPeople = JsonSerializer.Deserialize<List<Person>>(jsonString);
            foreach (var p in deserializedPeople)
            {
                Console.WriteLine($"Deserialized List: {p.Name}, {p.Age}, {p.IsEmployed}");
            }

            // 5. Handle JSON with Nested Objects
            jsonString = @"{
            \"Name\":\"Alice\",\"Address\":{\"Street\":\"123 Main St\",\"City\":\"Wonderland\"}
        }
        ";
        var personWithAddress = JsonSerializer.Deserialize<PersonWithAddress>(jsonString);
        Console.WriteLine($"Nested Object: {personWithAddress.Name}, {personWithAddress.Address.Street}, {personWithAddress.Address.City}");

        // 6. Handle JSON Arrays
        string[] fruits = { "Apple", "Banana", "Cherry" };
        jsonString = JsonSerializer.Serialize(fruits);
        Console.WriteLine("Serialize Array: " + jsonString); // Output: ["Apple","Banana","Cherry"]

        jsonString = @"[\"Apple\",\"Banana\",\"Cherry\"]";
        string[] deserializedFruits = JsonSerializer.Deserialize<string[]>(jsonString);
        Console.WriteLine("Deserialize Array: " + string.Join(", ", deserializedFruits)); // Output: Apple, Banana, Cherry

        // 7. Customize Serialization and Deserialization
        var personWithIgnore = new PersonWithIgnore { Name = "Alice", Age = 30 };
        jsonString = JsonSerializer.Serialize(personWithIgnore);
        Console.WriteLine("Ignore Property: " + jsonString); // Output: {"Name":"Alice"}

        var personWithCustomName = new PersonWithCustomName { Name = "Alice" };
        jsonString = JsonSerializer.Serialize(personWithCustomName);
        Console.WriteLine("Custom Property Name: " + jsonString); // Output: {"full_name":"Alice"}

        // 8. JSON in ASP.NET Core
        // Example of returning JSON from a controller action is provided in ASP.NET Core context
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsEmployed { get; set; }
    }

    class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
    }

    class PersonWithAddress
    {
        public string Name { get; set; }
        public Address Address { get; set; }
    }

    class PersonWithIgnore
    {
        public string Name { get; set; }
        [JsonIgnore]
        public int Age { get; set; }
    }

    class PersonWithCustomName
    {
        [JsonPropertyName("full_name")]
        public string Name { get; set; }
    }
}

// Summary Table
// +-------------------------+-----------------------------------------+
// | Task                    | System.Text.Json      | Newtonsoft.Json |
// +-------------------------+-----------------------------------------+
// | Serialize               | JsonSerializer.Serialize(object)        | JsonConvert.SerializeObject(object) |
// | Deserialize             | JsonSerializer.Deserialize<T>(json)     | JsonConvert.DeserializeObject<T>(json) |
// | Parse Dynamic JSON      | JsonDocument.Parse(json)               | JObject.Parse(json) |
// | Ignore Properties       | [JsonIgnore]                           | [JsonIgnore] |
// | Custom Property Names   | [JsonPropertyName("name")]             | [JsonProperty("name")] |
// +-------------------------+-----------------------------------------+
