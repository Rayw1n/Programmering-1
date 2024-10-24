using System;

class Program
{
    static void Main()
    {
        bool spelaIgen = true; //bool funktion
        int rekordGissningar = int.MaxValue; // För att hålla reda på minsta antalet gissningar

        while (spelaIgen)
        {
            // Skapa ett Random-objekt och slumpa ett tal mellan 1 och 100
            Random random = new Random();
            int slumpTal = random.Next(1, 101);
            int gissningar = 0;  // Håller reda på antal gissningar
            bool korrektGissat = false; // Används för att kontrollera när användaren har gissat rätt

            Console.WriteLine("Gissa talet mellan 1 & 100 (Du har 15 försök)");

            do
            {
                // Läs in användarens gissning
                string str = Console.ReadLine();
                int tal;

                // Validering av inmatning
                if (int.TryParse(str, out tal))
                {
                    gissningar++;

                    // Kolla om talet är rätt eller om det är för högt/lågt
                    if (tal > slumpTal + 5)
                    {
                        Console.WriteLine("För högt! Gissa igen.");
                    }
                    else if (tal < slumpTal - 5)
                    {
                        Console.WriteLine("För lågt! Gissa igen.");
                    }
                    else if (Math.Abs(tal - slumpTal) <= 5 && tal != slumpTal)
                    {
                        Console.WriteLine("Det närmar sig!");
                    }

                    // Kontrollera om talet är rätt
                    if (tal == slumpTal)
                    {
                        korrektGissat = true;
                        Console.WriteLine($"Grattis! Du gissade rätt på {gissningar} försök.");
                    }

                    // Avsluta spelet om användaren har gjort 15 gissningar
                    if (gissningar >= 15 && !korrektGissat)
                    {
                        Console.WriteLine($"Du har gjort 15 gissningar. Det korrekta talet var {slumpTal}.");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Ogiltig inmatning, ange ett giltigt tal.");
                }
            }
            while (!korrektGissat && gissningar < 15);

            // Håll reda på rekordet för minst antal gissningar
            if (korrektGissat && gissningar < rekordGissningar)
            {
                rekordGissningar = gissningar;
            }

            // Fråga om användaren vill spela igen
            Console.WriteLine("Vill du spela igen? (ja/nej)");
            string svar = Console.ReadLine().ToLower();

            if (svar != "ja")
            {
                spelaIgen = false;
            }
        }

        // När spelet avslutas, visa rekordet om minst antal gissningar
        if (rekordGissningar < int.MaxValue)
        {
            Console.WriteLine($"Rekordet för minst antal gissningar var {rekordGissningar}.");
        }

        Console.WriteLine("Tack för att du spelade!");
    }
}
