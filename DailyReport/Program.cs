﻿// See https://aka.ms/new-console-template for more information
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        Console.WriteLine("What course are you on?");
        string course = Console.ReadLine();
        Console.WriteLine("What page number?");
        int page = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
        Boolean help_need = Convert.ToBoolean(Console.ReadLine());
        Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
        string positive = Console.ReadLine();
        Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
        String feedback = Console.ReadLine();
        Console.WriteLine("How many hours did you study today?");
        int hours = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Thank you for your answers, " + name + "! An instructor will respond shortly. Have a great day!");
        Console.Read();
    }
}
