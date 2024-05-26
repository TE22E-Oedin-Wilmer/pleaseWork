// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Console.ReadLine();

using System;

class Program
{
    static void Main(string[] args)   // Main metoden som körs fråmn början. Kör också båda loop-metoderna.
    {
        Console.WriteLine("50/50 Skottsimulation med både while och for loop nedan:"); // Text
        Console.WriteLine("Tryck [ENTER] för att gå vidare.");
        Console.ReadLine();   // Readline tvingar en att trycka [ENTER] för att fortsätta.


        // Anropa metod med en while-loop
        WhileLoop();

        // Anropa metod med en for-loop
        ForLoop();

        Console.WriteLine("Tryck [ENTER] för att avsluta.");   // Mer text samt en readline som fungerar som stopp.
        Console.ReadLine();
    }



    // Metod med while-loop
    static void WhileLoop()
    {
        Random generator = new Random();    //   RNG

        Console.WriteLine("Simulering med while-loop:");     // Text
        int skottNummer = 1;                                 // Vilket skott man är på (variabel)
        while (skottNummer <= 5)                             // While loop
        {
            int träff = generator.Next(1, 11);               // Random tal mellan 1 och 10
            if (träff < 6)                                   // Om du träffar mindre än 6 (aka 5 och neråt) missar du
            {
                Console.WriteLine($"Skott {skottNummer}: MISS");
            }

            else if (träff > 5)                              // Om du träffar mer än 5 (aka 6 och uppåt) träffar du
            {
                Console.WriteLine($"Skott {skottNummer}: TRÄFF");
            }

            skottNummer++;                                   // Skottnummret går upp efter varje skott och du behöver trycka [ENTER] för att gå vidare
            Console.ReadLine();
        }

    }

    // Metod med for-loop
    static void ForLoop()
    {
        Random generator = new Random();                    // RNG

        Console.WriteLine("Simulering med for-loop:");      // Text
        for (int L = 1; L <= 5; L++)                        // For loop som repeteras 5 gånger
        {
            int träff = generator.Next(1, 11);              // Random tal mellan 1 och 10
           if (träff < 6)                                   // Om du träffar mindre än 6 (aka 5 och neråt) missar du
            {
                Console.WriteLine($"Skott {L}: MISS");
            }

            else if (träff > 5)                            // Om du träffar mer än 5 (aka 6 och uppåt) träffar du
            {
                Console.WriteLine($"Skott {L}: TRÄFF");
            }
            Console.ReadLine();                            // Kräver att du trycker [ENTER] för att fortsätta
        }
    }

}