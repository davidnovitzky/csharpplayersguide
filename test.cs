// Create a program that asks a user to input a number from 0 to 100
// Then the other user has to guess the number
// Display if the users answer is too low or too high
// Use a method inside another method
// * Objective is to write a method to call it several times so you dont have to write the same code twice*

// Make a method which returns a number from the user in range of 0 to 100
// Methods signature > int AskForNumberInRange(string text, int min, int max)
// Make a while loop
// Display text in console window
// Get the user input
// Convert to an int
// Only return if the number is between min and max values
// Otherwise ask again

// Write a method to return a number from the user
// Methods signature > int AskForNumber(string text)
// Display text in console window
// Get the user input
// Convert to an int
// Return it

// Call the InRange Method and assign it to an int variable
// Methods parameters display the question and the range from 0 & 100
// Clear the console
// Prompt the second user to guess the number
// Call the AskForNumber method and assign it to a int variable
// Check if the guessed number variable is greater than the first users variable value
// Display text " too high "
// Call the method again
// Check if the guessed number variable is lower than the first user variable value
// Display text " too low " 
// Check If the guessed number variable equals to the first users variable value
// Display text " you guessed it! "
// Break out of the loop
int result = AskForNumberInRange("Enter a number: ", 0, 100);
Console.Clear();

while (true)
{
    int guess = AskForNumber("Guess the number: ");
    if (guess > result) Console.WriteLine("Too high!");
    else if (guess < result) Console.WriteLine("Too low!");
    else if (guess == result)
    {
        Console.WriteLine("You guessed it!");
        break;
    }
}
Console.ReadLine();

int AskForNumberInRange(string text, int min, int max)
{
    while (true)
    {
        int input = AskForNumber(text);
        if (input >= min && input <= max)
            return input;
    }
}

int AskForNumber(string text)
{
    Console.Write(text);
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}
