for (int i = 1; i < 100; i++)
{
    Console.ResetColor();
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.Write($"{i}: ");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Combined Blast!");
    }
    else if (i % 3 == 0)
    {
        Console.Write($"{i}: ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Fire Blast!");
    }

    else if (i % 5 == 0)
    {
        Console.Write($"{i}: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Electric Blast!");
    }

    else
    {
        Console.Write($"{i}: ");
        Console.WriteLine("Normal");
    }
}
Console.ReadLine();

/* first version
for (int i = 1; i < 100; i++)
{
    if (i % 3 == 0)
    {
        Console.Write($"{i}: ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Fire Blast!");
        Console.ResetColor();
    }

    if (i % 5 == 0)
    {
        Console.Write($"{i}: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Electric Blast!");
        Console.ResetColor();
    }
    if (i % 3 == 0 && i % 5 ==0)
    {
        Console.Write($"{i}: ");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Combined Blast!");
        Console.ResetColor();
    }


    else if (i % 3 != 0 && i % 5 != 0)
    {
        Console.ResetColor();
        Console.Write($"{i}: ");
        Console.WriteLine("Normal");
    }
}
Console.ReadLine();
*/

// write a for loop which goes through 100 times
// display a normal blast every pass
// display a fire blast! every third pass < change color to red
// display a electric blast! every fifth pass < change color to yellow
// display a combined blast! when two blasts line up < change color to cyan
// if (number % 3 == 0) "Fire Blast!"
// if (number % 5 == 0) "Electric Blast!"
// if (number % 15 == 0) "Combined Blast!"

// OUTPUT example
// Normal 1
// Normal 2
// Fire   3
// Normal 4 
// Electric 5
// Fire   6
// Normal 7
// Normal 8
// Fire 9
// Electric 10
// Normal 11
// Fire 12
// Normal 13
// Normal 14
// Combined 15
// etc

// *THE MAGIC CANNON*

// *RULES*
// Loop through values between 1 and 100
// Display what kind of blast is expected
// Two gems - Fire and Electric
// Every third turn fire gem activates
// Every fifth turn electric gem activates
// When fire and electric lines up create a combined blast
// The % operator (remainder) may be used
// Change the text color based on the input. 
// Fire - red, Electric - yellow, Electric & Fire - blue
