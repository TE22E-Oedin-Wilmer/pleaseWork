// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Console.ReadLine();

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Tärningskastsimulator med både while och for loop nedan:");
        Console.WriteLine("Tryck [ENTER] för att gå vidare.");
        Console.ReadLine();


        // Anropa metod med en while-loop
        WhileLoop();

        // Anropa metod med en for-loop
        ForLoop();

        Console.WriteLine("Tryck [ENTER] för att avsluta.");
        Console.ReadLine();
    }



    // Metod med while-loop
    static void WhileLoop()
    {
        Random generator = new Random();

        Console.WriteLine("Simulering med while-loop:");
        int kastNummer = 1;
        while (kastNummer <= 5)
        {
            int tärningskast = generator.Next(1, 7); // Random tal mellan 1 och 6
            Console.WriteLine($"Kast {kastNummer}: {tärningskast}");
            kastNummer++;
            Console.ReadLine();
        }

    }

    // Metod med for-loop
    static void ForLoop()
    {
        Random generator = new Random();

        Console.WriteLine("Simulering med for-loop:");
        for (int L = 1; L <= 5; L++)
        {
            int tärningskast = generator.Next(1, 7); // Random tal mellan 1 och 6
            Console.WriteLine($"Kast {L}: {tärningskast}");
            Console.ReadLine();
        }
    }

}