using System;

public class Logger
{
    // Single instance of Logger
    private static Logger instance = new Logger();

    // Private constructor
    private Logger()
    {
        Console.WriteLine("Logger instance created.");
    }

    // Public method to get the single instance
    public static Logger GetInstance()
    {
        return instance;
    }

    // Method to log messages
    public void Log(string message)
    {
        Console.WriteLine("Log: " + message);
    }
}
