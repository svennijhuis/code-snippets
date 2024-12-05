using System;

namespace ComparisonExample
{
    // Enum vs Class vs Interface Comparisons
    // ---------------------------------------

    // Enum for Status
    public enum OrderStatus
    {
        Pending,
        Shipped,
        Delivered
    }

    // Class for Order
    public class Order
    {
        public int OrderId { get; set; }
        public OrderStatus Status { get; set; }

        public void PrintStatus()
        {
            Console.WriteLine($"Order {OrderId} is {Status}.");
        }
    }

    // Interface for Printable Objects
    public interface IPrintable
    {
        void Print();
    }

    public class Invoice : IPrintable
    {
        public int InvoiceId { get; set; }

        public void Print()
        {
            Console.WriteLine($"Printing Invoice {InvoiceId}...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Enum Example Usage
            Order order = new Order { OrderId = 1, Status = OrderStatus.Shipped };
            order.PrintStatus(); // Output: Order 1 is Shipped.

            // Interface Example Usage
            Invoice invoice = new Invoice { InvoiceId = 101 };
            invoice.Print(); // Output: Printing Invoice 101...
        }
    }
}

// Summary Table
// +----------------------------+------------------------------------------------+
// | Comparison                 | Details                                        |
// +----------------------------+------------------------------------------------+
// | Enum vs Class              | Enum: Represents fixed constants.              |
// |                            | Class: Blueprint for objects.                  |
// |                            | Enum: Cannot have methods or properties.       |
// |                            | Class: Can have fields, methods, properties.   |
// +----------------------------+------------------------------------------------+
// | Class vs Interface         | Class: Can have implemented methods.           |
// |                            | Interface: No implementations (except default).|
// |                            | Class: Single inheritance.                     |
// |                            | Interface: Multiple implementations.           |
// +----------------------------+------------------------------------------------+
// | When to Use                | Enum: Fixed set of constants.                  |
// |                            | Class: Encapsulate data and behavior.          |
// |                            | Interface: Define common contracts.            |
// +----------------------------+------------------------------------------------+
