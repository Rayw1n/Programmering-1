using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Skapa en lista för användarens nummer
        List<int> bingorad = new List<int>();

        Console.WriteLine("Vänligen mata in din bingorad med tio  siffror (mellan 1 och 25):");

        // Låt användaren peta in tio nummer
        for (int i = 0; i < 10; i++)
        {
            int nummer;
            while (true)
            {
                Console.Write($"Ange nummer {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out nummer) && nummer >= 1 && nummer <= 25 && !bingorad.Contains(nummer))
                {
                    bingorad.Add(nummer);
                    break;
                }
                else
                {
                    Console.WriteLine("Felaktigt nummer. Ange ett nummer mellan 1 och 25. Dubbletter går inte");
                }
            }
        }

        // Skapa en lista för slumpade nummer utan dubbletter
        List<int> slumpadeNummer = new List<int>();
        Random slump = new Random();

        Console.WriteLine("\nSlumpade nummer:");
        while (slumpadeNummer.Count < 10)
        {
            int slumpNummer = slump.Next(1, 26);
            if (!slumpadeNummer.Contains(slumpNummer))
            {
                slumpadeNummer.Add(slumpNummer);
                Console.WriteLine(slumpNummer);
            }
        }

        // Jämför och hitta bingo-träffar
        Console.WriteLine("\nResultat:");
        int bingoCount = 0;
        foreach (int nummer in bingorad)
        {
            if (slumpadeNummer.Contains(nummer))
            {
                Console.WriteLine($"Bingo! Du har en träff på nummer {nummer}");
                bingoCount++;
            }
        }

        // visa scoreboard
        if (bingoCount == 0)
        {
            Console.WriteLine("Ingen Bingo.");
        }
        else
        {
            Console.WriteLine($"\nTotalt antal träffar: {bingoCount}");
        }
    }
}
