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
int attackRange;

int manticoreRange = AskForManticoreRange("Player 1, how far away from the city do you want to station the Manticore (0 to 100)? ", 0, 100);
Console.WriteLine("Manticore's range currently is " + manticoreRange);
Console.ReadLine();
Console.Clear();
Console.WriteLine("Player 2, it's your turn.");

// Display the outcome if the attack fell short, overshot or if it hit.
// If the attack is lower than the manticore range display fell short and dont take away HP from manticore
// If attack is greater than the manticore range display attack overshot and dont take away HP from manticore
// If attack direct hits the manticore display a direct hit and take away the appropriate damage from the manticore

    while (manticoreHealth >= 0 && cityHealth >= 0)
    {
        Console.WriteLine("--------------------------------------------------");
        Console.Write($"STATUS:  Round: {round}  City: {cityHealth}/{startingCityHealth}  ");
        Console.WriteLine($"Manticore: {manticoreHealth}/{startingManticoreHealth}");
        ExcpectedDamageDeal();
        attackRange = AskForAttackRange("Enter desired cannon range: ", 0, 100);
        DisplayAttackOutcome();
        cityHealth--;
        round++;
    }










gameResult();
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
    string wonGame = "Congratualations the Manticore has been destroyed!";
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
        int damage = 10;
        manticoreHealth -= damage;
        Console.WriteLine($"The cannon is expected to deal {damage} damage this round");
    }
    else if (round % 3 == 0)
    {
        int damage = 3;
        manticoreHealth -= damage;
        Console.WriteLine($"The cannon is expected to deal {damage} damage this round");
    }
    else if (round % 5 == 0)
    {
        int damage = 3;
        manticoreHealth -= damage;
        Console.WriteLine($"The cannon is expected to deal {damage} damage this round");
    }
    else
    {
        int damage = 1;
        manticoreHealth -= damage;
        Console.WriteLine($"The cannon is expected to deal {damage} damage this round");
    }
}

void DisplayAttackOutcome()
{
    if (attackRange > manticoreRange)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("That round OVERSHOT the target");
        Console.ResetColor();
    }
    else if (attackRange < manticoreRange)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("That round FELL SHORT of the target");
        Console.ResetColor();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("That round was a DIRECT HIT!");
        Console.ResetColor();
    }
}
