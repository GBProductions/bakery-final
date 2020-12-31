using System;
using Bakery.Models;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Welcome to Pierre's Bakery!");
        Console.WriteLine("We sell a bread loaf for $5 and a pastry for $2");
        Console.WriteLine("We got a special deal though: buy 2 loafs of bread get 1 free.");
        Console.WriteLine("Also, buy 3 pastries for only $5.");
        Console.WriteLine("How many loafs of bread do you want?");
        string breadNumber = Console.ReadLine();
        Console.WriteLine("How many pastries do you want?");
        string pastryNumber = Console.ReadLine();
        Console.WriteLine("Loafs of Bread: " + breadNumber);
        Console.WriteLine("Number of Pastries: " + pastryNumber);
        

    }
}