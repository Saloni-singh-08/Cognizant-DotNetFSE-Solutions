using System;

class Program
{
    static void Main(string[] args)
    {
        Logger logger1 = Logger.GetInstance();
        Logger logger2 = Logger.GetInstance();

        logger1.Log("Application Started");
        logger2.Log("User Logged In");

        Console.WriteLine();

        if (logger1 == logger2)
        {
            Console.WriteLine("Singleton Pattern Works!");
        }
        else
        {
            Console.WriteLine("Singleton Pattern Failed!");
        }
    }
}
