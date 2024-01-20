using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace design_pattern.Services.Factory
{
    //Factory Class to Produce the Products
    public static class LoggerFactory
    {
        public static ILogger CreateLogger(string type)
        {
            switch (type.ToLower())
            {
                case "console":
                    return new ConsoleLogger();
                case "file":
                    return new FileLogger("log.txt");
                // For simplicity, file path is hardcoded
                // You can extend here with other logger types
                default:
                    throw new ArgumentException("Invalid logger type");
            }
        }
    }
}



//// Document **********

//According to Gang of Four (GoF), “A factory is an object used for creating other objects. In technical terms,
//we can say that a factory is a class with a method. That method will create and return different objects based on the received input,parameter“.

//From Lehman’s point of view, we can say that a factory is a place where products are created.
//In other words, we can say that it is a centralized place for creating products. Later, based on the order received,
//the factory delivers the appropriate product. For example, a car factory can produce different types of cars.
//If you order a car based on your requirements or specifications, the factory will create the appropriate car and then deliver that car to you.

//When to use the Factory Design Pattern in C# Real-Time Applications?
//Here are some scenarios in real-time applications where you might consider using the Factory Design Pattern in C#:
//Complex Object Creation: When the creation logic of objects is complex and should not be part of the client code. Factory pattern abstracts the instantiation process and hides the complexity from the client.
//Decoupling: It’s useful when there needs to be a decoupling between the implementation of a class and its users. The Factory pattern allows for this by letting a class defer instantiation to subclasses or another class.
//Conditional Object Creation: If the creation of an object depends on certain conditions or configurations, the Factory pattern can encapsulate these conditions and ensure the creation of the appropriate object.
//Extensibility: When the system needs to be extensible, allowing the addition of new types of objects that conform to an interface or abstract class easily without modifying existing code.
//Object Pooling: In scenarios where object creation is expensive, you need to manage and reuse instances efficiently, such as in database connections or thread pools.
//Family of Objects: If your application needs to create a family of related or dependent objects, the Factory pattern can ensure that the objects created are compatible with each other.
//Integration and Unit Testing: For easier integration and Unit Testing, the Factory pattern allows for creating mock objects and stubs, which can be used in unit testing more effectively than direct instantiation.
//Readability and Maintenance: It improves code readability and maintenance by encapsulating the creation logic in one place and promoting a clean separation of concerns.

//In real world we can use factory for:
//Payment Gateway Integration:allows multiple payment gateways like PayPal, Stripe, and Credit Card processing.
//Document Conversion System:allows users to convert documents between different formats like DOCX, PDF, and TXT
//Logging System
//A Simple System to Handle Notifications:an application may need to send different types of notifications to users, such as email notifications, SMS notifications, or push notifications.
//Discounts in an E-commerce Application:Consider an e-commerce platform where different types of discounts are applied to products based on different criteria: seasonal offers, clearance sales, and member discounts.
//Transport Application:users can choose between different transportation modes, like a car, bus, or bike
//Developing a Graphics Editor
//Designing a System for a Bank
//Report Generation
//Cloud Storage System
//UI Theme System

//Personal point: 
//1. For using this design pattern, first we need an interface, then implement this interface in deference classes(for deference condition<
//for example :Payment Gateway Integration that we have some different payment and each class implement interface and do some config for
//different payment, then a factory static class needed, to base on user request, return suitable class, and finally in client side,
//client just call the factory class with suitable request(needed payment)

//Advantages of Factory Design Pattern in C#:
//Loose Coupling: The Factory Pattern decouples the implementation of the product from its use. This means that the client code doesn’t need to know the specifics of how to create the product.
//Flexibility and Scalability: Introducing new concrete products without changing the client code is easy. This makes the application more flexible and scalable.
//Single Responsibility Principle: The factory class encapsulates the creation logic for the products, adhering to the Single Responsibility Principle. This leads to cleaner, more organized code.
//Open/Closed Principle: The Factory Pattern aligns with the Open/Closed Principle as you can introduce new types of products without altering existing factory or client code.
//Manage Complexity: It can manage and centralize complex creation logic, especially useful when creating objects requires more than simple instantiation.
//Control Over Instantiation: Factories can control how and when objects are created. For instance, you can implement singleton, prototype, or pool patterns within a factory.

//Disadvantages of Factory Design Pattern in C#:
//Complexity: Introducing a factory pattern can add complexity to the code, especially when a simple object creation would suffice.
//Indirection: There’s an extra layer of abstraction, which can sometimes make the code harder to understand and debug, especially for those unfamiliar with the pattern.
//Overhead: In performance-critical applications, the additional method call and object creation overhead can be a drawback.
//Dependency on Factories: The client code still depends on the factory for creating objects, which can lead to problems like the proliferation of factory classes for complex systems.
//Refactoring Existing Code: Integrating the Factory Pattern into existing code that wasn’t designed with this pattern in mind can be challenging and require significant refactoring.
//Requires Proper Design: Misuse or incorrect implementation of the Factory Pattern (like using too many factories or incorrect abstraction) can lead to maintenance issues and increase the difficulty of further modifications.