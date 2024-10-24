using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hej och välkommen till denna pensionssimulator!");

        // Ber användaren om dess namn.
        Console.WriteLine("Vad heter du?");
        string namn = Console.ReadLine();

        // Frågar hur gammal användaren är och validerar att inmatningen endast är siffror.
        int old;
        while (true)
        {
            Console.WriteLine("Hur gammal är du?");
            string input = Console.ReadLine();

            // kolla om åldern är korrekt skrivit.
            if (int.TryParse(input, out old) && old > 0)
            {
                break; // Om det är korrekt så fortsätt.
            }
            else
            {
                Console.WriteLine("Ange din ålder med siffror och heltal.");
            }
        }

        int pension = 67;
        int leftPension = pension - old;

        // Räknar ut pensionen utifrån sagd ålder.
        if (leftPension > 0)
        {
            Console.WriteLine($"{namn}, du har {leftPension} år kvar till pension.");
        }
        else
        {
            Console.WriteLine($"{namn}, du är tillräckligt gammal för att pensionera dig, eller så är du redan pensionär.");
        }

        Console.WriteLine("Tryck på valfri knapp för att avsluta...");
        Console.ReadKey();
    }
}
