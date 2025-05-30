int number = Factorial(4);
Console.WriteLine(number);
Console.ReadLine();

int Factorial(int number)
{
    if (number == 1) return 1;
    return number * Factorial(number - 1);
}

/* OBJECTIVES
 * Write code that counts down from 10 to 1 using a recursive method
 * You have to have a base case that ends the recursion
 * Everytime you call the method you must be getting closer to that base case
 */

//Challenge(10);
//int Challenge(int number)
//{
//    if (number == 0) return 1;
//    Console.WriteLine(number);
//    return number * Challenge(number - 1);
//}
//Console.ReadLine();
