ChestState chestState = ChestState.locked;

while (true)
{
    Console.Write($"The chest is {chestState} What do you want to do? ");
    string userAction = Console.ReadLine();

    if      (userAction == "unlock" && chestState == ChestState.locked)      chestState = ChestState.unlocked;
    else if (userAction == "open"   && chestState == ChestState.unlocked)    chestState = ChestState.open;
    else if (userAction == "lock"   && chestState == ChestState.unlocked)    chestState = ChestState.locked;
    else if (userAction == "close"  && chestState == ChestState.open)        chestState = ChestState.unlocked;
    else Console.WriteLine("Invalid Action");
}

enum ChestState { locked, unlocked, open }
