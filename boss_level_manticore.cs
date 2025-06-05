// Setup the game with health for manticore and city then rounds
// Get the starting distance for the Manticore from the first player and clear the screen after.
// Second player turn
// Run the game in a loop until the city or the Manticore is destroyed.
// Display the status for the round, city health and manticore health
// Display the amount of damage expected on a hit.
// Get the input of a number from the player for the cannon range
// Display the outcome if the attack fell short, overshot or if it hit.
// Deal damage to the Manticore if it was a hit.
// Deal damage to the city if the Manticore is still alive every round.
// Go on to the next round until the city or manticore is destroyed (loop)
// Display outcome of the game if manticore or city health is = 0
// ------------------------------- METHODS --------------------------------
// 1.Display the outcome of the game, win or lose
// 2.Tells the player if they fell short, overshot, or hit their target.
// 3.Displays the status of the game, including the round number, and health of city and Manticore.
// 4.Calculate how much damage will be done depending on the current round.

const int startingManticoreHealth = 10;
const int startingCityHealth = 15;
int manticoreHealth = 10;
int cityHealth = 15;
int round = 1;

int manticoreRange = AskForManticoreRange("Player 1, how far away from the city do you want to station the Manticore (0 to 100)? ", 0, 100);
Console.WriteLine("Manticore's range currently is " + manticoreRange);
Console.ReadLine();
Console.Clear();
Console.WriteLine("Player 2, it's your turn.");

while (manticoreHealth > 0 && cityHealth > 0)
{
    Console.WriteLine("--------------------------------------------------");
    DisplayStatus(round, cityHealth, manticoreHealth);

    int damageDealt = DamageDeal();
    Console.WriteLine($"The cannon is expected to deal {damageDealt} damage this round");

    int guessedAttackRange = AskForAttackRange("Enter desired cannon range (0 to 100): ", 0, 100);
    DisplayAttackOutcome(guessedAttackRange);

    if (guessedAttackRange == manticoreRange) manticoreHealth -= damageDealt;

    cityHealth--;
    round++;
}
gameResult();
int DamageDeal()
{
    if      (round % 3 == 0 && round % 5 == 0) return 10;
    else if (round % 3 == 0 || round % 5 == 0) return 3;
    else                                       return 1;
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
int AskForManticoreRange(string text, int min, int max)
{
    while (true)
    {
        Console.Write(text);
        Console.ForegroundColor = ConsoleColor.Cyan;
        string inputRange = Console.ReadLine();
        int.TryParse(inputRange, out int manticoreRange);
        Console.ResetColor();
        if (manticoreRange >= min && manticoreRange <= max)
            return manticoreRange;
    }
}
void gameResult()
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
