using System;

namespace Singleton;

// This is not therad-safe. In a multithreaded environment, multiple threads could create multiple instances of Logger.
// class Logger
// {
//     static int instanceCount = 0;
//     private static readonly object lockObj = new object();
//     static Logger loggerInstance;
//     Logger()
//     {
//         instanceCount++;
//         Console.WriteLine($"New Logger instance created. Total instances: {instanceCount} \n");
//     }

//     public static Logger GetLogger()
//     {
//         if (loggerInstance == null)
//         {
//             loggerInstance = new Logger();
//         }

//         return loggerInstance;
//     }

//     public void Log(string message)
//     {
//         Console.WriteLine($"Log: {message}\n");
//     }

// }


// Thread-safe implementation using locking where we introduce a lock object and make sure 
class Logger
{
    static int instanceCount = 0;
    private static readonly object lockObj = new object();
    static Logger loggerInstance;
    Logger()
    {
        instanceCount++;
        Console.WriteLine($"New Logger instance created. Total instances: {instanceCount} \n");
    }

    public static Logger GetLogger()
    {
        if (loggerInstance == null) // checking to make sure that only once lock is acquired when the instance is being created. This is known as double-checked locking.
        {
            lock (lockObj) // because putting a lock is really expensive
            {
                if (loggerInstance == null)
                {
                    loggerInstance = new Logger();
                }
            }
            
        }
        
        return loggerInstance;
    }

    public void Log(string message)
    {
        Console.WriteLine($"Log: {message}\n");
    }

}
