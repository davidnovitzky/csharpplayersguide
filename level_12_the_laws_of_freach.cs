int[] arrayValues = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

int currentSmallest = int.MaxValue;

foreach (int i in arrayValues)
{
    if (i < currentSmallest)
    {
        currentSmallest = i;
    }
}
Console.WriteLine($"Current smallest value: {currentSmallest}");

float total = 0;

foreach (int value in arrayValues)
{
    total += value;
}

float average = total / arrayValues.Length;

Console.WriteLine($"The average from the list: {average.ToString("F2")}");
Console.ReadLine();
