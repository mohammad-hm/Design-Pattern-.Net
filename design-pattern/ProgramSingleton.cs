//using design_pattern.Services.Singleton;
//using System;
//using System.Threading.Tasks;
//namespace SingletonDemo
//{
//    class ProgramSingleton
//    {
//        //Example to Understand Thraed-Safe Singleton Design Pattern using Eager Loading
//        //When use in a Multithreaded Environment
//        static void Main(string[] args)
//        {
//            //The following Code will Invoke both methods Parallely using two different Threads
//            Parallel.Invoke(
//                //Let us Assume PrintTeacherDetails method is Invoked by Thread-1
//                () => PrintTeacherDetails(),
//                //Let us Assume PrintStudentdetails method is Invoked by Thread-2
//                () => PrintStudentdetails()
//                );
//            Console.ReadLine();
//        }

//        private static void PrintTeacherDetails()
//        {
//            //Thread-1 Calling the GetInstance() Method of the Singleton class
//            EagerLoadingSingletonExample fromTeacher = EagerLoadingSingletonExample.GetInstance();
//            fromTeacher.PrintDetails("From Teacher");
//        }

//        private static void PrintStudentdetails()
//        {
//            //At the same time, Thread-2 also Calling the GetInstance() Method of the Singleton Class
//            EagerLoadingSingletonExample fromStudent = EagerLoadingSingletonExample.GetInstance();
//            fromStudent.PrintDetails("From Student");
//        }
//    }
//}