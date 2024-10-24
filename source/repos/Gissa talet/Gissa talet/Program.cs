using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Gissa talet mellan 1 & 100");
        string str = Console.ReadLine();
        int tal = Convert.ToInt32(str);

        // Skapa en random funktion
        Random random = new Random();

        // Slumpa ett tal mellan 1 och 100
        int slumpTal = random.Next(1, 101); // mellan 1 och 100.

        // Räkna ut och se om talet stämmer överens med 10 antal i skillnad.
        while (tal != slumpTal)
        {
            if (tal > slumpTal + 5) // högre än slumpattal + 5
            {
                Console.WriteLine("För högt! Gissa igen.");
            }
            else if (tal < slumpTal - 5) //Lägre än slumpattal - 5
            {
                Console.WriteLine("För lågt! Gissa igen.");
            }

            if (Math.Abs(tal - slumpTal) <= 5 && tal != slumpTal)
            {
                Console.WriteLine("Det närmar sig!");
            }

            str = Console.ReadLine();
            tal = Convert.ToInt32(str);
        }

        // Om talet var rätt
        Console.WriteLine("Grattis, det var korrekt!"); 
        Console.ReadKey();
    }
   
}
