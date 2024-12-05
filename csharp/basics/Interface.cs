using System;

namespace InterfaceExample
{
    // 1. Interface Declaration
    public interface IVehicle
    {
        void Start();
        void Stop();
    }

    // 2. Implementing an Interface
    public class Car : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Car starting...");
        }

        public void Stop()
        {
            Console.WriteLine("Car stopping...");
        }
    }

    // 3. Multiple Interfaces
    public interface IEngine
    {
        void StartEngine();
    }

    public class MultiInterfaceCar : IVehicle, IEngine
    {
        public void Start()
        {
            Console.WriteLine("Car starting...");
        }

        public void Stop()
        {
            Console.WriteLine("Car stopping...");
        }

        public void StartEngine()
        {
            Console.WriteLine("Engine started.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 1. Interface Example Usage
            IVehicle vehicle = new Car();
            vehicle.Start();
            vehicle.Stop();
            // Output:
            // Car starting...
            // Car stopping...

            // 2. Multiple Interfaces Example
            MultiInterfaceCar multiCar = new MultiInterfaceCar();
            multiCar.StartEngine(); // Output: Engine started.
            multiCar.Start();       // Output: Car starting...
            multiCar.Stop();        // Output: Car stopping...
        }
    }
}

// Summary Table
// +---------------------------+---------------------------------------------+
// | Task                      | Example Usage                               |
// +---------------------------+---------------------------------------------+
// | Interface Declaration     | interface IVehicle { void Start(); ... }    |
// | Implementing Interface    | class Car : IVehicle { public void Start() ... } |
// | Multiple Interfaces       | class MultiInterfaceCar : IVehicle, IEngine { ... }|
// | Interface Usage           | IVehicle vehicle = new Car(); vehicle.Start(); |
// +---------------------------+---------------------------------------------+
