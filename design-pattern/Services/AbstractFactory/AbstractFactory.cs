using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_pattern.Services.AbstractFactory
{
    // The AbstractFactory interface
    // The Abstract Factory interface declares a set of methods that return different abstract products. 
    // These products are called a family. 
    // A family of products may have several variants
    public interface IVehicleFactory
    {
        //Abstract Product A
        IBike CreateBike();
        //Abstract Product B
        ICar CreateCar();
    }
}


//// Document **********

//The Abstract Factory Design Pattern provides a way to encapsulate a group of factories,
//with a common theme without specifying their concrete classes.

//In simple words, we can say that the Abstract Factory is a super factory that creates other factories.
//This Abstract Factory is also called the Factory of Factories. That means the Abstract Factory design pattern provides
//an interface for creating families of related or dependent products but leaves the actual object creation to the concrete factory classes.

//When to use Abstract Factory Design Pattern?
//The Abstract Factory Design Pattern is particularly useful in scenarios where your application needs to:
//Create Families of Related Products: When you have a set of related products designed to be used together, you need to enforce this constraint.
//Ensure Consistency Among Products: If your application should use only products from the same family to ensure compatibility and consistency.
//Decouple Concrete Implementations: The pattern helps in decoupling the client code from the concrete implementations of the interfaces it relies on.
//Facilitate Exchange of Product Families: If your application needs to be flexible enough to work with multiple families of related products and switch between them easily.
//Provide a Layer of Abstraction: When you need to provide a high level of abstraction for creating complex objects. This can be especially useful in systems where the construction involves dependency injection or configuration.
//Support Configurability and Scalability: If your application needs to be configurable and scalable, it allows for introducing new families of products without modifying existing client code.
//Platform-Specific Implementations: In situations where your application needs to support different environments or platforms, each requiring different implementations of a set of products.
//Facilitate Testing and Mocking: Abstract Factory can create mock objects for unit testing, making it easier to test components in isolation.

//Where can we use this design pattern in real world?
//Payment Gateways in E-commerce
//Cross-Platform UI Development
//Vehicle Manufacturing Company
//Cross-Platform Application Configuration
//Furniture Shop
//Managing Connections to Different Types of Databases
//Multi-Device User Interfaces
//Animal Kingdoms
//Multimedia Software
//Beverages