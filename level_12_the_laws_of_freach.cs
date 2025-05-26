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

/*int[] arrayValues = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 }; //initializes 9 values inside if the array

int currentSmallest = int.MaxValue; // variable will hold the smallest number each pass, current value is the largest available
float total = 0; // initialized float variable will hold the average of the values inside the array

foreach (int value in arrayValues) // for every loop pass assign the value from the array to the new "value" int variable
{
    if (value < currentSmallest) // conditional statement if the value is smaller than the currentSmallest is true then..
    {
        currentSmallest = value; // then the new value is assigned to the currentSmallest variable        
    }
        total += value; // this adds each value to the total float variable to be used in the formula to calculate the average, it cant be inside the if statement because the condition doesnt work for this
}

float average = total / arrayValues.Length; // the calculated total of the arrays values divided by the total length of the array is assigned as the average to a new variable

Console.WriteLine($"Current smallest value: {currentSmallest}"); // prints the left over smallest value from the array
Console.WriteLine($"The average from the list: {average.ToString("F2")}"); // prints the total values average with only two decimals
Console.ReadLine();*/
