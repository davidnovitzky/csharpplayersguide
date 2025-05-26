int[] firstArray = new int[5];

for (int i = 0; i < firstArray.Length; i++)
{
    Console.Write("Enter a number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    firstArray[i] = number;
}

int[] secondArray = new int[firstArray.Length];

for (int i = 0; i < secondArray.Length; i++)
{
    secondArray[i] = firstArray[i];
}
for (int i = 0; i < secondArray.Length; i++)
{
    Console.WriteLine($"Original: {firstArray[i]} Copy: {secondArray[i]}");
}
Console.ReadLine();