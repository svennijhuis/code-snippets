using System;

namespace ClassExample
{
    // 1. Class Declaration
    public class Person
    {
        // Fields
        private string name;

        // Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age { get; set; }

        // Constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Methods
        public void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name} and I'm {Age} years old.");
        }
    }

    // 2. Static Members
    public class Calculator
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
    }

    // 3. Inheritance
    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating...");
        }
    }

    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Barking...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 1. Class Example Usage
            Person person = new Person("Alice", 30);
            person.Introduce();
            // Output: Hi, I'm Alice and I'm 30 years old.

            // 2. Static Members Example
            int result = Calculator.Add(5, 3);
            Console.WriteLine("Static Method Result: " + result); // Output: 8

            // 3. Inheritance Example
            Dog dog = new Dog();
            dog.Eat();  // Output: Eating...
            dog.Bark(); // Output: Barking...
        }
    }
}

// Summary Table
// +---------------------------+---------------------------------------------+
// | Task                      | Example Usage                               |
// +---------------------------+---------------------------------------------+
// | Class Declaration         | class Person { public string Name { get; ... }|
// | Constructor               | public Person(string name, int age) { ... } |
// | Method Declaration        | public void Introduce() { ... }             |
// | Static Members            | public static int Add(int a, int b) { ... } |
// | Inheritance               | class Dog : Animal { public void Bark() ... }|
// +---------------------------+---------------------------------------------+
