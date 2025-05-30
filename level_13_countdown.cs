Challenge(10);
int Challenge(int number)
{
    if (number == 0) return 1;
    Console.WriteLine(number);
    return number * Challenge(number - 1);
}
Console.ReadLine();


//int number = Factorial(4);
//Console.WriteLine(number);
//Console.ReadLine();

//int Factorial(int number)
//{
//    if (number == 1) return 1;
//    return number * Factorial(number - 1);
//}
