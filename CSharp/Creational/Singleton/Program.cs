/*
 * Singleton Design Pattern
 * Ensures a class has only one instance and provides a global point of access to it.
 */

using System;
namespace Singleton
{

    // This is not therad-safe testing implementation. In a multithreaded environment, multiple threads could create multiple instances of Logger. 
    // class Program
    // {
    //     static void Main(string[] args)
    //     {
    //         Logger logger1 = Logger.GetLogger();
    //         logger1.Log("This is the first log message.");
    //         Logger logger2 = Logger.GetLogger();
    //         logger2.Log("This is the second log message.");
    //     }
    // }

    // Thread-safe testing implementation using double-checked locking
    class Program
    {
        public void user1logs()
        {
            Logger logger1 = Logger.GetLogger();
            logger1.Log("User 1: This is the first log message.");
        }

        public void user2logs()
        {
            Logger logger2 = Logger.GetLogger();
            logger2.Log("User 2: This is the second log message.");
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            System.Threading.Thread thread1 = new System.Threading.Thread(program.user1logs);
            System.Threading.Thread thread2 = new System.Threading.Thread(program.user2logs);

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();  

        }
    }
}
