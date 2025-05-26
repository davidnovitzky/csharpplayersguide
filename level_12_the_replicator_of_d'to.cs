int[] firstArray = new int[5]; // declare an array and assign a length of 5

for (int i = 0; i < firstArray.Length; i++) // a for loop of firstArray number of passes [5], incrementing by 1 each pass,
{
    Console.Write("Enter a number: "); // prompt the user to enter a number
    int number = Convert.ToInt32(Console.ReadLine()); // variable holds the input value and converts string value to integer
    firstArray[i] = number; // the number value is assigned to the array "firstArray" in each of its indexes [i] each pass.
}
//copy firstArray values to the secondArray
int[] secondArray = new int[firstArray.Length]; // declare an array and assign the same length as first Array

for (int i = 0; i < secondArray.Length; i++) // a for loop of secondary number of passes [firstArray.Length], which is 5, incrementing by 1 each pass,
{
    secondArray[i] = firstArray[i]; // the firstArray values inside the indexes and assigned to the new secondArray indexes each for loop pass
}
for (int i = 0; i < secondArray.Length; i++) // a for loop of the same length as long as the index which is looping each pass, is less than the array length which is 5
{
    Console.WriteLine($"Original: {firstArray[i]} Copy: {secondArray[i]}"); // prints first array values and the copied over secondArray values
}
Console.ReadLine();
