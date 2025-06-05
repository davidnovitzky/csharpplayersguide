const int minRange = 0;
const int maxRange = 100;
const int startingManticoreHealth = 10;
const int startingCityHealth = 15;
var manticoreHealth = 10;
var cityHealth = 15;
var round = 1;


var manticoreRange = GetManticoreRange();

Console.WriteLine("Player 2, it's your turn.");

while (manticoreHealth > 0 && cityHealth > 0)
{
    PrintRoundAndPlayersScores();
   
    var guessedAttackRange = GetAttackRange();

    var isDirectHit = ValidateAndPrintAttackOutcome(guessedAttackRange);

    if (isDirectHit)
    {
        CalculateUsersScores();
    }

    cityHealth--;
    round++;
}

PrintGameResult();
return;



int GetManticoreRange()
{
    int range;
    while (true)
    {
        Console.Write("Player 1, how far away from the city do you want to station the Manticore (0 to 100)? ");
        string inputRange = Console.ReadLine();
        int.TryParse(inputRange, out int enteredManticoreRange);
        if (enteredManticoreRange >= minRange && enteredManticoreRange <= maxRange)
        {
            range = enteredManticoreRange;
            break;
        }
    }

    Console.WriteLine("Manticore's range currently is " + range);
    Console.ReadLine();
    Console.Clear();

    return range;
}

int GetAttackRange()
{
    while (true)
    {
        Console.Write("Enter desired cannon range: ");
        Console.ForegroundColor = ConsoleColor.Cyan;
        string inputRange = Console.ReadLine();
        int.TryParse(inputRange, out int attackRange);
        Console.ResetColor();
        if (attackRange >= minRange && attackRange <= maxRange)
            return attackRange;
    }

}

bool ValidateAndPrintAttackOutcome(int guessedAttackRange)
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
        return true; // indicates a successful hit
    }

    return false; // indicates a miss
}

void CalculateUsersScores()
{
    var damageDealt = GetDamageDeal();
    manticoreHealth -= damageDealt;
}

int GetDamageDeal()
{
    if (round % 3 == 0 && round % 5 == 0)
    {
        return 10;
    }

    if (round % 3 == 0)
    {
        return 3;
    }

    if (round % 5 == 0)
    {
        return 5;
    }

    return 1;
}

void PrintRoundAndPlayersScores()
{
    Console.WriteLine("--------------------------------------------------");
    Console.Write($"STATUS:  Round: {round}  City: {cityHealth}/{startingCityHealth}  ");
    Console.WriteLine($"Manticore: {manticoreHealth}/{startingManticoreHealth}");
    PrintExpectedDamageDeal();
}

void PrintGameResult()
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

void PrintExpectedDamageDeal()
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

