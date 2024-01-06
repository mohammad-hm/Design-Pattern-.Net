using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using static System.Net.Mime.MediaTypeNames;

namespace design_pattern.Services
{
    //Sealed in .NET is a modifier that can be applied to classes, methods, or properties. It prevents other classes from inheriting from a sealed class, or other methods or properties from overriding a sealed method or property. For example, you can use sealed to protect your class from being modified by subclasses, or to ensure that your method or property behaves as expected in derived classes
    public sealed class EagerLoadingSingletonExample
    {
        //This variable value will be increment by 1 each time the object of the class is created
        private static int Counter = 0;

        //This variable is going to store the Singleton Instance
        //Initiazling the Variable at the time of class start-up and make it ready to be used in Future
        private static readonly EagerLoadingSingletonExample singleInstance = new EagerLoadingSingletonExample();

        //The following Static Method is going to return the Singleton Instance
        //This is Thread-Safe as it use Eager Loading
        public static EagerLoadingSingletonExample GetInstance()
        {
            //Now we don't need to use any NULL Checking code
            //We don't need to write Explicit code for thread-safety
            //Object initialization and Thread-Safety will be taken care by CLR as we are using Eager Loading
            //Return the Singleton Instance
            return singleInstance;
        }

        //When constructor, use 'private' then the class cant be initialized any more
        private EagerLoadingSingletonExample()
        {
            //Each Time the Constructor is called, increment the Counter value by 1
            Counter++;
            Console.WriteLine("Counter Value " + Counter.ToString());
        }

        //The following method can be accessed from outside of the class by using the Singleton Instance
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}

//// Document **********

///What are the Advantages of using the Singleton Pattern in C#?
//The first and most important advantage of using the singleton design pattern in C# is that it takes care of concurrent access to the shared resource. That means if we share a resource with multiple clients simultaneously, then concurrent access to that resource is well managed by the singleton design pattern.
//It can be lazy-loaded and also has Static Initialization.
//To share common data, i.e., master and configuration data, which is not frequently changed in an application. In that case, we need to cache the objects in memory.
//It is easy to maintain as it provides a single global access point to a particular instance.
//To reduce the overhead of instantiating a heavy object again and again.

//What are the Disadvantages of using the Singleton Design Pattern in C#?
//Unit testing is very difficult because it introduces a global state into an application.
//It reduces the potential for parallelism within a program because to access the singleton instance in a multi-threaded environment, and you need to serialize the object using locking.

//When to Use Singleton Design Pattern in C#?
//Managing Shared Resources: Singleton is suitable for managing shared resources, such as:
//A database connection pool.
//A file manager that handles all file operations.
//A cache where multiple parts of an application need to store and retrieve objects.