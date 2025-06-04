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

int manticoreHealth = 10;
int cityHealth = 15;
int round = 1;

int manticoreRange = AskForManticoreRange("Player 1, how far away from the city do you want to station the Manticore (0 to 100)? ", 0, 100);
Console.WriteLine("Manticore's range currently is " + manticoreRange);
Console.ReadLine();
Console.Clear();
Console.WriteLine("Player 2, it's your turn.");
Console.WriteLine("-------------------------");
Console.ReadLine();
int AskForManticoreRange(string text, int min, int max)
{
    Console.Write(text);
    string inputRange = Console.ReadLine();
    int.TryParse(inputRange, out int manticoreRange);
    return manticoreRange;
}
