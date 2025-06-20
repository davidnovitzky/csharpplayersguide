Console.WriteLine("The following items are available:");
Console.WriteLine("1 - Rope");
Console.WriteLine("2 - Torches");
Console.WriteLine("3 - Climbing Equipment");
Console.WriteLine("4 - Clean Water");
Console.WriteLine("5 - Machete");
Console.WriteLine("6 - Canoe");
Console.WriteLine("7 - Food Supplies");
Console.Write("What number do you want to see the price of? ");
int itemNumber= int.Parse(Console.ReadLine());

while (itemNumber < 1 || itemNumber > 7)
{
    Console.WriteLine("Invalid Item");
    Console.Write("What number do you want to see the price of? ");
    itemNumber = int.Parse(Console.ReadLine());
} 

    Console.Write("What is your name? ");
    string myName = Console.ReadLine();

    string itemName = itemNumber switch
    {
        1 => "Rope",
        2 => "Torches",
        3 => "Climbing Equipment",
        4 => "Clean Water",
        5 => "Machete",
        6 => "Canoe",
        7 => "Food Supplies",
        _ => ""
    };

    double itemCost = itemNumber switch
    {
        1 => 10,
        2 => 15,
        3 => 25,
        4 => 1,
        5 => 20,
        6 => 200,
        7 => 1,
        _ => 0
    };

    if (myName.ToLower() == "david")
    {
        Console.WriteLine($"{itemName} costs {itemCost / 2} gold.");
    }

    else
    {
        Console.WriteLine($"{itemName} costs {itemCost} gold.");
    }
Console.ReadLine();
