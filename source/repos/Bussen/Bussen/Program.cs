using System;

namespace Bussen
{
    class Buss
    {
        public int[] passagerare;
        public int antal_passagerare;
        public int max_passagerare = 10; // Sätt maxgräns för antalet passagerare

        public Buss()
        {
            passagerare = new int[max_passagerare];
            antal_passagerare = 0;
        }

        public void Run()
        {
            Console.WriteLine("Välkommen till Bussen-simulatorn!");
            bool running = true;

            while (running) // Aktiv loop meny
            {
                Console.WriteLine("\nMeny:");
                Console.WriteLine("1. Lägg till passagerare");
                Console.WriteLine("2. Visa alla passagerare");
                Console.WriteLine("3. Beräkna total ålder");
                Console.WriteLine("4. Beräkna genomsnittsålder");
                Console.WriteLine("5. Avsluta");
                Console.Write("Välj ett alternativ: ");

                string choice = Console.ReadLine();

                switch (choice) // Menyval
                {
                    case "1":
                        Add_Passenger();
                        break;
                    case "2":
                        Print_Buss();
                        break;
                    case "3":
                        Console.WriteLine("Total ålder: " + Calc_Total_Age());
                        break;
                    case "4":
                        Console.WriteLine("Genomsnittsålder: " + Calc_Average_Age());
                        break;
                    case "5":
                        running = false; // Avsluta
                        Console.WriteLine("Avslutar programmet.");
                        break;
                    default:
                        Console.WriteLine("Ogiltigt val. Försök igen.");
                        break;
                }
            }
        }

        public void Add_Passenger() // lägg till passagerar o ålder om inte max är nådd
        {
            if (antal_passagerare < max_passagerare)
            {
                Console.Write("Ange passagerarens ålder: ");
                int age;
                if (int.TryParse(Console.ReadLine(), out age) && age > 0)
                {
                    passagerare[antal_passagerare] = age;
                    antal_passagerare++;
                    Console.WriteLine("Passagerare tillagd.");
                }
                else
                {
                    Console.WriteLine("Ogiltig ålder. Försök igen.");
                }
            }
            else
            {
                Console.WriteLine("Bussen är full, inga fler passagerare kan läggas till.");
            }
        }

        public void Print_Buss() // lagra passagerar i bussen
        {
            Console.WriteLine("\nPassagerare i bussen:");
            for (int i = 0; i < antal_passagerare; i++)
            {
                Console.WriteLine($"Passagerare {i + 1}: Ålder {passagerare[i]}");
            }
        }

        public int Calc_Total_Age() // Räkna utt samanlagd ålder
        {
            int totalAge = 0;
            for (int i = 0; i < antal_passagerare; i++)
            {
                totalAge += passagerare[i];
            }
            return totalAge;
        }

        public double Calc_Average_Age() // Räkna ut genomsnittlig ålder
        {
            if (antal_passagerare == 0)
            {
                Console.WriteLine("Inga passagerare på bussen.");
                return 0;
            }
            return (double)Calc_Total_Age() / antal_passagerare;
        }
    }

    class Program
    {
        public static void Main(string[] args) // 
        {
            var minbuss = new Buss();
            minbuss.Run();
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
