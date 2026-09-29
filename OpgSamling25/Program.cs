using System;
using System.Collections.Generic;

Random rnd = new Random();

// ==========================================
// Opgave 2.7: Trafiklyset
// ==========================================
Console.WriteLine("=== Opgave 2.7: Trafiklyset ===");

int randomTal = rnd.Next(0, 3);
TrafficLight light = (TrafficLight)randomTal;

if (light == TrafficLight.Red)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("STOP! Hold stille.");
}
else if (light == TrafficLight.Yellow)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("GØR KLAR! Vær opmærksom.");
}
else if (light == TrafficLight.Green)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("KØR! Vejen er fri.");
}
Console.ResetColor();

Console.WriteLine("\nTryk Enter for næste opgave...");
Console.ReadLine();


// ==========================================
// Opgave 2.8: Ugens Vagthold
// ==========================================
Console.WriteLine("=== Opgave 2.8: Ugens Vagthold ===");
Console.Write("Indtast en ugedag som et tal (1-7): ");

string dagInput = Console.ReadLine();
int dayNumber = int.Parse(dagInput);

if (dayNumber >= 1 && dayNumber <= 7)
{
    int enumIndex = dayNumber - 1;
    UgensDag valgtDag = (UgensDag)enumIndex;

    switch (valgtDag)
    {
        case UgensDag.Monday:
        case UgensDag.Tuesday:
        case UgensDag.Wednesday:
        case UgensDag.Thursday:
            Console.WriteLine("Almindelig hverdagsvagt – 2 livreddere på arbejde.");
            break;
        case UgensDag.Friday:
            Console.WriteLine("Fredags-disco aften – 4 livreddere og 1 tekniker på arbejde.");
            break;
        case UgensDag.Saturday:
        case UgensDag.Sunday:
            Console.WriteLine("Weekend-vagt – Fuldt familie-beredskab.");
            break;
    }
}
else
{
    Console.WriteLine("Ugyldig ugedag indtastet!");
}

Console.WriteLine("\nTryk Enter for næste opgave...");
Console.ReadLine();


// ==========================================
// Opgave 2.9: Pokedex (Indeks i lister)
// ==========================================
Console.WriteLine("=== Opgave 2.9: Pokedex ===");
List<string> pokedex = new List<string>();
pokedex.Add("Bulbasaur");
pokedex.Add("Charmander");
pokedex.Add("Squirtle");
pokedex.Add("Pikachu");

int listeStørrelse = pokedex.Count;
int maxIndeks = listeStørrelse - 1;

Console.Write("Vælg et Pokemon-indeks (0 til 3): ");
string pokeInput = Console.ReadLine();
int pokeIndex = int.Parse(pokeInput);

if (pokeIndex >= 0 && pokeIndex <= maxIndeks)
{
    string valgtPokemon = pokedex[pokeIndex];
    Console.WriteLine($"Du valgte Pokemon på plads {pokeIndex}: {valgtPokemon}");
}
else
{
    Console.WriteLine($"Ugyldigt indeks! Vælg et tal mellem 0 og {maxIndeks}");
}

Console.WriteLine("\nTryk Enter for næste opgave...");
Console.ReadLine();


// ==========================================
// Opgave 2.10: Skattekisten (Tilføj og fjern)
// ==========================================
Console.WriteLine("=== Opgave 2.10: Skattekisten ===");
List<string> treasureChest = new List<string>();
treasureChest.Add("Guldsværd");
treasureChest.Add("Helbredseliksir");
treasureChest.Add("Magisk Ring");

string ting0 = treasureChest[0];
string ting1 = treasureChest[1];
string ting2 = treasureChest[2];
Console.WriteLine($"Indhold: 0: {ting0}, 1: {ting1}, 2: {ting2}");

Console.Write("Hvilken genstand vil du tage fra kisten? Vælg 0, 1 eller 2: ");
string kisteInput = Console.ReadLine();
int kisteValg = int.Parse(kisteInput);
int kisteStørrelse = treasureChest.Count;

if (kisteValg >= 0 && kisteValg < kisteStørrelse)
{
    string tagetGenstand = treasureChest[kisteValg];
    treasureChest.RemoveAt(kisteValg);
    Console.WriteLine($"Du tog: {tagetGenstand}");

    Console.Write("Hvilken ny genstand vil du lægge i kisten? ");
    string nyGenstand = Console.ReadLine();
    treasureChest.Add(nyGenstand);

    int nytAntal = treasureChest.Count;
    Console.WriteLine($"Der er nu {nytAntal} genstande i kisten.");
}
else
{
    Console.WriteLine("Ugyldigt valg.");
}

Console.WriteLine("\nTryk Enter for næste opgave...");
Console.ReadLine();


// ==========================================
// Opgave 2.11: Karakterbogens Top og Bund
// ==========================================
Console.WriteLine("=== Opgave 2.11: Karakterbogens Top og Bund ===");
List<int> scores = new List<int>();
scores.Add(45);
scores.Add(82);
scores.Add(95);
scores.Add(60);

int sum = scores[0] + scores[1] + scores[2] + scores[3];
int antalScores = scores.Count;
double average = (double)sum / antalScores;

Console.WriteLine($"Samlet point: {sum}, Gennemsnit: {average}");

int førsteScore = scores[0];
int sidsteScore = scores[3];

if (førsteScore > sidsteScore)
{
    Console.WriteLine("Den første studerende fik flest point af de to yderste.");
}
else if (sidsteScore > førsteScore)
{
    Console.WriteLine("Den sidste studerende fik flest point af de to yderste.");
}
else
{
    Console.WriteLine("Den første og den sidste studerende fik lige mange point.");
}

if (average >= 50)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Holdets samlede resultat er bestået!");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Holdets samlede resultat er ikke bestået!");
}
Console.ResetColor();

Console.WriteLine("\nTryk Enter for næste opgave...");
Console.ReadLine();


// ==========================================
// Opgave 2.12 (Ekstra): Sten, Saks, Papir
// ==========================================
Console.WriteLine("=== Opgave 2.12: Sten, Saks, Papir ===");
List<string> players = new List<string>();
players.Add("Spiller 1");
players.Add("Computer");

string spiller1Navn = players[0];
string computerNavn = players[1];

int compTal = rnd.Next(0, 3);
HandSign computerSign = (HandSign)compTal;

Console.Write($"{spiller1Navn}, vælg dit træk (0 = Rock, 1 = Paper, 2 = Scissors): ");
string playerInput = Console.ReadLine();
int playerChoice = int.Parse(playerInput);

if (playerChoice >= 0 && playerChoice <= 2)
{
    HandSign playerSign = (HandSign)playerChoice;
    Console.WriteLine($"{spiller1Navn} valgte {playerSign} og {computerNavn} valgte {computerSign}");

    // Logikken er delt op på flere linjer for at holde det simpelt
    if (playerSign == computerSign)
    {
        Console.WriteLine("-> Det er uafgjort!");
    }
    else if (playerSign == HandSign.Rock && computerSign == HandSign.Scissors)
    {
        Console.WriteLine($"-> {spiller1Navn} vinder!");
    }
    else if (playerSign == HandSign.Scissors && computerSign == HandSign.Paper)
    {
        Console.WriteLine($"-> {spiller1Navn} vinder!");
    }
    else if (playerSign == HandSign.Paper && computerSign == HandSign.Rock)
    {
        Console.WriteLine($"-> {spiller1Navn} vinder!");
    }
    else
    {
        // Hvis det ikke er uafgjort, og Spiller 1 ikke vinder, så vinder computeren
        Console.WriteLine($"-> {computerNavn} vinder!");
    }
}
else
{
    Console.WriteLine("Ugyldigt valg. Spillet afsluttes.");
}

Console.WriteLine("\nProgrammet er slut!");

// ==========================================
// ENUMS (Skal ligge nederst i filen)
// ==========================================
enum TrafficLight { Red, Yellow, Green }
enum UgensDag { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }
enum HandSign { Rock, Paper, Scissors }