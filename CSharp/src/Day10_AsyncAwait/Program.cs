﻿using System;
using System.IO;
using System.Threading.Tasks;

class Program
{
    public static void Main()
    {
        // Part 1: start the HandleFile method.
        Task<int> task = HandleFileAsync();

        // Control returns here before HandleFileAsync returns.
        // ... Prompt the user.
        Console.WriteLine("Please wait patiently " +
            "while I do something important.");

        // Do something at the same time as the file is being read.
        string line = Console.ReadLine();
        Console.WriteLine("You entered (asynchronous logic): " + line);

        // Part 3: wait for the HandleFile task to complete.
        // ... Display its results.
        task.Wait();
        var x = task.Result;
        Console.WriteLine("Count: " + x);

        Console.WriteLine("[DONE]");
        Console.ReadLine();
    }

    static async Task<int> HandleFileAsync()
    {
        string file = @"C:\programs\enable1.txt";
        // Part 2: status messages and long-running calculations.
        Console.WriteLine("HandleFile enter");
        int count = 0;

        // Read in the specified file.
        // ... Use async StreamReader method.
        using (StreamReader reader = new StreamReader(file))
        {
            string v = await reader.ReadToEndAsync();

            // ... Process the file data somehow.
            count += v.Length;

            // ... A slow-running computation.
            //     Dummy code.
            for (int i = 0; i < 10000; i++)
            {
                int x = v.GetHashCode();
                if (x == 0)
                {
                    count--;
                }
            }
        }
        Console.WriteLine("HandleFile exit");
        return count;
    }
}