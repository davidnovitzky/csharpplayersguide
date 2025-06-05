const int startingManticoreHealth = 10;
const int startingCityHealth = 15;
int manticoreHealth = 10;
int cityHealth = 15;
int round = 1;

int manticoreRange = AskForManticoreRange(0, 100);
Console.WriteLine("Manticore's range currently is " + manticoreRange);
Console.ReadLine();
Console.Clear();
Console.WriteLine("Player 2, it's your turn.");

while (manticoreHealth > 0 && cityHealth > 0)
{
    Console.WriteLine("--------------------------------------------------");
    DisplayStatus(round, cityHealth, manticoreHealth);

    int damageDealt = GetExpectedDamageOutput();
    Console.WriteLine($"The cannon is expected to deal {damageDealt} damage this round");

    int guessedAttackRange = AskForAttackRange(0, 100);
    DisplayAttackOutcome(guessedAttackRange);

    if (guessedAttackRange == manticoreRange) manticoreHealth -= damageDealt;

    cityHealth--;
    round++;
}
DisplayGameResult();
int GetExpectedDamageOutput()
{
    if      (round % 3 == 0 && round % 5 == 0) return 10;
    else if (round % 3 == 0 || round % 5 == 0) return 3;
    else                                       return 1;
}
int AskForAttackRange(int min, int max)
{
    return GetNumberFromUser("Enter desired cannon range (0 to 100): ", min, max);
}
int AskForManticoreRange(int min, int max)
{
    return GetNumberFromUser("Player 1, how far away from the city do you want to station the Manticore (0 to 100)? ", min, max);
}
int GetNumberFromUser(string text, int min, int max)
{
    while (true)
    {
        Console.Write(text);
        Console.ForegroundColor = ConsoleColor.Cyan;
        string input = Console.ReadLine();
        Console.ResetColor();
        int.TryParse(input, out int number);
        if (number >= min && number <= max)
            return number;
    }
}
void DisplayGameResult()
{
    string wonGame = "Congratualations the Manticore has been destroyed!";
    string lostGame = "Oh no! The City has been destroyed!";

    string gameOutcome = (cityHealth > 0) ? wonGame : lostGame; // determines what message will be printed
    ConsoleColor outcomeColor = (cityHealth > 0) ? ConsoleColor.Green : ConsoleColor.Red; // determines what color will be printed in

    Console.ForegroundColor = outcomeColor;
    Console.WriteLine(gameOutcome);
    Console.ReadLine();
}
void DisplayAttackOutcome(int guessedAttackRange)
{
    if (guessedAttackRange > manticoreRange)
        ShowColoredMessage("That round OVERSHOT the target.", ConsoleColor.Magenta);

    else if (guessedAttackRange < manticoreRange)
        ShowColoredMessage("That round FELL SHORT of the target.", ConsoleColor.Magenta);

    else
        ShowColoredMessage("That round was a DIRECT HIT!", ConsoleColor.Yellow);   
}
void ShowColoredMessage(string message, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.WriteLine(message);
    Console.ResetColor();
}
void DisplayStatus(int round, int cityHealth, int manticoreHealth)
{
    Console.WriteLine($"STATUS:  Round: {round}  City: {cityHealth}/{startingCityHealth}  Manticore: {manticoreHealth}/{startingManticoreHealth}");
}
