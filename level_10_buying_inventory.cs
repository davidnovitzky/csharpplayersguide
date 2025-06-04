// switch statement

Console.WriteLine("The following items are available:");
Console.WriteLine("1 - Rope");
Console.WriteLine("2 - Torches");
Console.WriteLine("3 - Climbing Equipment");
Console.WriteLine("4 - Clean Water");
Console.WriteLine("5 - Machete");
Console.WriteLine("6 - Canoe");
Console.WriteLine("7 - Food Supplies");
Console.Write("What number do you want to see the price of? ");
int itemNumber = int.Parse(Console.ReadLine());

int itemCost = 0;

switch (itemNumber)
{
    case 1:
        itemCost = 10;
        Console.WriteLine("Rope costs " + itemCost + " gold.");
        break;
    case 2:
        itemCost = 15;
        Console.WriteLine("Torches costs " + itemCost + " gold.");
        break;
    case 3:
        itemCost = 25;
        Console.WriteLine("Climbing Equipment costs " + itemCost + " gold.");
        break;
    case 4:
        itemCost = 1;
        Console.WriteLine("Clean Water costs " + itemCost + " gold.");
        break;
    case 5:
        itemCost = 20;
        Console.WriteLine("Machete costs " + itemCost + " gold.");
        break;
    case 6:
        itemCost = 200;
        Console.WriteLine("Canoe costs " + itemCost + " gold.");
        break;
    case 7:
        itemCost = 1;
        Console.WriteLine("Food Supplies cost " + itemCost + " gold.");
        break;
    default:
        Console.WriteLine("Invalid item number.");
        break;
}
Console.ReadLine();

// switch expression

Console.WriteLine("The following items are available:");
Console.WriteLine("1 - Rope");
Console.WriteLine("2 - Torches");
Console.WriteLine("3 - Climbing Equipment");
Console.WriteLine("4 - Clean Water");
Console.WriteLine("5 - Machete");
Console.WriteLine("6 - Canoe");
Console.WriteLine("7 - Food Supplies");
Console.Write("What number do you want to see the price of? ");
int itemNumber = int.Parse(Console.ReadLine());

string itemName = itemNumber switch
{
    1 => "Rope",
    2 => "Torches",
    3 => "Climbing Equipment",
    4 => "Clean Water",
    5 => "Machete",
    6 => "Canoe",
    7 => "Food Supplies",
    _ => "Invalid item Number"
};

int itemCost = itemNumber switch
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
Console.WriteLine($"{itemName} costs {itemCost} gold.");
Console.ReadLine();
