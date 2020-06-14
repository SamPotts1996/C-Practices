// Lets look at some of the examples on Threads
// I've used the following resources to explore use of the Thread Class: 
/*
--  https://docs.microsoft.com/en-us/dotnet/api/system.threading.thread?view=netcore-3.1 -  Microsoft documentation on the Thread Class
--  https://docs.microsoft.com/en-us/dotnet/standard/threading/using-threads-and-threading - Microsoft documentation on 'use of threads'
--  https://www.youtube.com/watch?v=hOVSKuFTUiI - Derek Banas
--  https://www.youtube.com/watch?v=UgVkI7ZJyMc - Bucky Roberts 
*/
// I'm going to try produce an output to demonstrate the use of Thread, Lock & Sleep statements.
// This is primarily for my own practice however, I've laid this example out as an informal tutorial so others can learn too! 

#region Irrelevant include statements 

using System;

#endregion

// Include the thread class. 
using System.Threading;

namespace Threads_Example
{
    class Program
    {
        // Constants 
        private const int ThreadLoopCount = 10;

        // Declare the threads 
        private static Thread ThreadOne { get; set; }
        private static Thread ThreadTwo { get; set; }

        /// <summary>
        ///  The 'Main Thread' ;)
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Prompt the user to start
            Console.WriteLine("Press enter to start: ");
            Console.ReadLine();

            // Initiate the threads with the example methods 
            ThreadOne = new Thread(ExampleMethodOne);
            ThreadTwo = new Thread(ExampleMethodTwo);
          
            // Start thread without parameter
            ThreadOne.Start();

            // Start thread with parameter
            ThreadTwo.Start("Test2");

            // Pause the console
            Console.ReadLine();
        }

        /// <summary>
        /// Example method used for 'ThreadOne'.
        /// </summary>
        private static void ExampleMethodOne()
        {
            var output = "Test1";


            // Print output (ThreadLoopCount) amount of times.
            for (int i = 0; i < ThreadLoopCount; i++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Thread 1: {output}");
            }
        }

        /// <summary>
        /// Example method with parameter used for ThreadTwo
        /// </summary>
        /// <param name="output"></param>
        private static void ExampleMethodTwo(object output)
        {
            // Print output (ThreadLoopCount) amount of times.
            for (int i = 0; i < ThreadLoopCount; i++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Thread 2: {output}");
            }
        }
    }
}
