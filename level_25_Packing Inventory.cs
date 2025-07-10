Pack myPack = new Pack(20, 30, 10); // Create a new pack with max weight, volume, and item count

while (true)
{
    Console.WriteLine($"My pack currently holds {myPack.CurrentItemCount}/{myPack.TotalItemCount} items.");
    Console.WriteLine($"My pack weighs: {myPack.CurrentWeight}/{myPack.MaxWeight}.");
    Console.WriteLine($"Current volume: {myPack.CurrentVolume:F2}/{myPack.MaxVolume}.");
    Console.WriteLine("What do you want to add?");
    Console.WriteLine("1 - Arrow (0.1Kg, 0.05cm3)");
    Console.WriteLine("2 - Bow   (1.0Kg, 4.00cm3)");
    Console.WriteLine("3 - Rope  (1.0Kg, 1.50cm3)");
    Console.WriteLine("4 - Water (2.0Kg, 3.00cm3)");
    Console.WriteLine("5 - Food  (1.0Kg, 0.50cm3)");
    Console.WriteLine("6 - Sword (5.0Kg, 3.00cm3)");

    
    int menuChoiceInput = Convert.ToInt32(Console.ReadLine());

    InventoryItem newItem = menuChoiceInput switch
    {
        1 => new Arrow(),
        2 => new Bow(),
        3 => new Rope(),
        4 => new Water(),
        5 => new FoodRations(),
        6 => new Sword(),
        //_ =>  Default to what?
    };

    if (myPack.Add(newItem))
    {
        Console.WriteLine($"Added {newItem.GetType().Name} to the pack.");
    }
    else
    {
        Console.WriteLine("Cannot add item: pack is full or item exceeds weight/volume limits.");
    }
    Console.Clear();
}
public class Pack
{
    private InventoryItem[] _items; // array of InventoryItem objects
    public float MaxWeight { get; set; } // maximum weight capacity of the pack
    public float MaxVolume { get; set; } // maximum volume capacity of the pack
    public int TotalItemCount { get; set; } // total number of items in the pack

    public Pack(float maxWeight, float maxVolume, int totalItemCount) // constructor
    {
        MaxWeight = maxWeight;
        MaxVolume = maxVolume;
        TotalItemCount = totalItemCount;
        _items = new InventoryItem[totalItemCount]; // initialize the array with the total item count
    }

    public bool Add(InventoryItem item)
    {
        if (CurrentItemCount >= TotalItemCount) return false;
        if (CurrentVolume + item.Volume > MaxVolume) return false;
        if (CurrentWeight + item.Weight > MaxWeight) return false;

        _items[CurrentItemCount] = item;
        CurrentItemCount++;
        CurrentVolume += item.Volume;
        CurrentWeight += item.Weight;
        return true;
    }

    public float CurrentWeight { get; set; }
    public float CurrentVolume { get; set; }
    public int CurrentItemCount { get; set; }
}

public class InventoryItem // This class represents an item in an inventory system
{
    public float Weight { get; set; } // property for weight
    public float Volume { get; set; } // property for volume

    public InventoryItem(float weight, float volume) // constructor
    {
        Weight = weight;
        Volume = volume;
    }
}
public class Arrow : InventoryItem 
{
    public Arrow() : base(0.1f, 0.05f) // constructor for Arrow that calls the base class constructor
    {
    }
}
public class Bow : InventoryItem
{
    public Bow() : base(1.0f, 4.0f)
    {
    }
}
public class Rope : InventoryItem
{
    public Rope() : base(1.0f, 1.5f)
    {
    }
}
public class Water : InventoryItem
{
    public Water() : base(2.0f, 3.0f)
    {
    }
}
public class FoodRations: InventoryItem
{
    public FoodRations() : base(1.0f, 0.5f)
    {
    }
}
public class Sword : InventoryItem
{
    public Sword() : base(5.0f, 3.0f)
    {
    }
}
