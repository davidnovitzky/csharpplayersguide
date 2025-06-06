const int startingManticoreHealth = 10;
const int startingCityHealth = 15;
int manticoreHealth = 10;
int cityHealth = 15;
int round = 1;
int guessedAttackRange = 0;

int manticoreRange = AskForManticoreRange("Player 1, how far away from the city do you want to station the Manticore (0 to 100)? ", 0, 100);
Console.WriteLine("Manticore's range currently is " + manticoreRange);
Console.ReadLine();
Console.Clear();
Console.WriteLine("Player 2, it's your turn.");

while (manticoreHealth > 0 && cityHealth > 0)
{
    Console.WriteLine("--------------------------------------------------");
    Console.Write($"STATUS:  Round: {round}  City: {cityHealth}/{startingCityHealth}  ");
    Console.WriteLine($"Manticore: {manticoreHealth}/{startingManticoreHealth}");
    ExcpectedDamageDeal();
    guessedAttackRange = AskForAttackRange("Enter desired cannon range: ", 0, 100);
    DisplayAttackOutcome();

    if (guessedAttackRange == manticoreRange)
    {
        int damageDealt = DamageDeal(0);
        manticoreHealth -= damageDealt;
    }
    cityHealth--;
    round++;
}

gameResult();

int DamageDeal(int damageDealt)
{
    if (round % 3 == 0 && round % 5 == 0)
    {
        damageDealt = 10;
        return damageDealt;

    }
    else if (round % 3 == 0)
    {
        damageDealt = 3;
        return damageDealt;

    }
    else if (round % 5 == 0)
    {
        damageDealt = 3;
        return damageDealt;
    }
    else
    {
        damageDealt = 1;
        return damageDealt;
    }
}
int AskForAttackRange(string text, int min, int max)
{
    while (true)
    {
        Console.Write(text);
        Console.ForegroundColor = ConsoleColor.Cyan;
        string inputRange = Console.ReadLine();
        int.TryParse(inputRange, out int attackRange);
        Console.ResetColor();
        if (attackRange >= min && attackRange <= max)
            return attackRange;
    }

}
void gameResult()
{
    string wonGame = "Congratulations the Manticore has been destroyed!";
    string lostGame = "Oh no! The City has been destroyed!";

    string gameOutcome = (cityHealth > 0) ? wonGame : lostGame; // determines what message will be printed
    ConsoleColor outcomeColor = (cityHealth > 0) ? ConsoleColor.Green : ConsoleColor.Red; // determines what color will be printed in

    Console.ForegroundColor = outcomeColor;
    Console.WriteLine(gameOutcome);
    Console.ResetColor();
    Console.ReadLine();
}

int AskForManticoreRange(string text, int min, int max)
{
    while (true)
    {
        Console.Write(text);
        string inputRange = Console.ReadLine();
        int.TryParse(inputRange, out int manticoreRange);
        if (manticoreRange >= min && manticoreRange <= max)
            return manticoreRange;
    }
}

void ExcpectedDamageDeal()
{
    if (round % 3 == 0 && round % 5 == 0)
    {
        int damageDealt = 10;
        Console.WriteLine($"The cannon is expected to deal {damageDealt} damage this round");
    }
    else if (round % 3 == 0)
    {
        int damageDealt = 3;
        Console.WriteLine($"The cannon is expected to deal {damageDealt} damage this round");
    }
    else if (round % 5 == 0)
    {
        int damageDealt = 3;
        Console.WriteLine($"The cannon is expected to deal {damageDealt} damage this round");
    }
    else
    {
        int damageDealt = 1;
        Console.WriteLine($"The cannon is expected to deal {damageDealt} damage this round");
    }
}

void DisplayAttackOutcome()
{
    if (guessedAttackRange > manticoreRange)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("That round OVERSHOT the target.");
        Console.ResetColor();
    }
    else if (guessedAttackRange < manticoreRange)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("That round FELL SHORT of the target.");
        Console.ResetColor();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("That round was a DIRECT HIT!");
        Console.ResetColor();
    }
}
