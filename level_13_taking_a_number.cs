AskForNumber("What is the airspeed velocity of an unladen swallow? ");
int AskForNumber(string text)
{
    Console.Write(text);
    int returnvalue = int.Parse(Console.ReadLine());
    return returnvalue;
}
AskForNumberInRange("Enter a number between", 1, 100);
int AskForNumberInRange(string text, int min, int max)
{
    while (true)
    {
        Console.WriteLine($"{text} {min} & {max}");
        int returnvalue = int.Parse(Console.ReadLine());

        if (returnvalue > min && returnvalue < max)
        {
            return returnvalue;
        }
    }
}
