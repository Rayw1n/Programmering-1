using System;

class Program
{
    static Random random = new Random();

    // Metod för att omvandla Fahrenheit till Celsius
    static decimal fahr_to_cel(int fahrenheit)
    {
        return (fahrenheit - 32) * 5m / 9;
    }

    // slumpa fram fahrenheit
    static int fahr_to_cel()
    {
        return random.Next(150, 200); // Slumpmässig Fahrenheit-temperatur
    }

    static void Main()
    {
        decimal celsius = 0;
        bool validInput = false;

        // överlagrad loop 
        while (celsius < 82 || celsius > 87)
        {
            int fahrenheit;

            while (!validInput)
            {
                try
                {
                    // Be användaren ange temperaturen i Fahrenheit
                    Console.Write("Ange temperaturen i Fahrenheit (eller 0 för en slumpmässig temperatur): ");
                    fahrenheit = int.Parse(Console.ReadLine());

                    // Om 0, använd den överlagrade metoden för att slumpa
                    if (fahrenheit == 0)
                    {
                        fahrenheit = fahr_to_cel();
                        Console.WriteLine("Slumpad temperatur i Fahrenheit: " + fahrenheit);
                    }

                    // Fahrenheit till Celsius
                    celsius = fahr_to_cel(fahrenheit);
                    validInput = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ogiltig inmatning. Ange ett heltal för temperaturen.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Inmatningen är för stor eller för liten för att vara giltig.");
                }
            }

            // Kontrollera om temperaturen är i rätt intervall
            if (celsius < 82)
            {
                Console.WriteLine("Det är för kallt.");
                validInput = false;  // återställ inmatning för ny loop
            }
            else if (celsius > 87)
            {
                Console.WriteLine("Det är för varmt.");
                validInput = false;  // återställ inmatning för ny loop
            }
            else
            {
                Console.WriteLine("Temperaturen är nu lagom.");
            }
        }
    }
}
