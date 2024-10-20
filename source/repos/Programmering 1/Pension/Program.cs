Console.WriteLine("Hej och välkommen till denna pensionssimulator!");

// Ber användaren om dess namn.
Console.WriteLine("Vad heter du?");
string namn = Console.ReadLine();

// Frågar hur gammal användaren är.
Console.WriteLine("Hur gammal är du?");
int old = int.Parse(Console.ReadLine());

int pension = 67;
int leftPension = pension - old;

//Räknar ut pensionen utifrån sagd ålder.
if (leftPension > 0)
{
    Console.WriteLine($"{namn} du har {leftPension} år kvar till pension.");
}
else
{
    Console.WriteLine($"{namn}, Du är tillräckligt gammal för att pensionera dig, eller så är du redan pensionär.");
}
Console.WriteLine("Tryck på valfri knapp för att avsluta...");
Console.ReadLine();