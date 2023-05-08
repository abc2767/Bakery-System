using System;
using System.Runtime.InteropServices;

class Bakery_System
{
    public Bakery_System()
    {
        Console.SetWindowSize(100, 25);
        Console.Title = "Jimni Bakery Ssytem";
        Console.ForegroundColor = ConsoleColor.White ;

    }
    private int MainMenu()
    {
        Console.Clear();
        Console.WriteLine("♥♥♥♥♥Welcome to Jimni's Bakery♥♥♥♥♥");
        Console.WriteLine("1. Login for Existing Customer");
        Console.WriteLine("2. Sing up for new User");
        Console.WriteLine("3. Exit");
        Console.WriteLine("-----------------------------");
        Console.BackgroundColor = ConsoleColor.Black;
        Console.Write("Enter your choice : ");
        try
        {
            return (int.Parse(Console.ReadLine()));
        }
        catch (FormatException)
        {
            return 0;
        }

    }
    private int Login()
    {
        Console.Clear();
        Console.WriteLine("Login let's get it!");
        return 0;
    }

    private int SignUp()
    {
        Console.Clear();
        Console.WriteLine("Sign up gogo");
        return 0;
    }

    static void Main(string[] args)
    {
        Bakery_System obj = new Bakery_System();
        Console.Read();
        while (true)
        {
            switch(obj.MainMenu())
            {
                case 1: obj.Login();
                    break;
                case 2: obj.SignUp();
                    break;
                case 3:
                        Console.WriteLine("\n");
                        Console.WriteLine("Thank you for using our bakery survice!");
                        Console.WriteLine("Press any key to  exit the service");
                        Console.ReadLine();
                        Environment.Exit(0);
                    break;

            default:
                    Console.WriteLine("You choose incorrect number");
                    break;
            }
        }
    }
}