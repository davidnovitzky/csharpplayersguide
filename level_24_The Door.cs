string passcodeInput; // string because int dont read lead zero
string currentCode = "";
string newCode = "";
string codeGuess = "";

while (true)
{
    Console.Write("What is the passcode: ");
    passcodeInput = Console.ReadLine()!;

    if (!string.IsNullOrEmpty(passcodeInput) && passcodeInput.All(char.IsDigit))
    {
        break;
    }
}

Door door1 = new(passcodeInput);

while (true)
{
    Console.WriteLine($"The door is {door1.DoorState}.");
    Console.Write($"Do you want to (open, close, lock, unlock) or (change) the passcode to the door > ");

    string? stateInput = Console.ReadLine();

    switch (stateInput)
    {
        case "unlock":
            door1.Unlock(codeGuess);
            break;
        case "open":
            door1.Open();
            break;
        case "close":
            door1.Close();
            break;
        case "lock":
            door1.Lock();
            break;
        case "change":
            door1.ChangePassCode(currentCode, newCode);
            break;
    }
}
public class Door
{
    public DoorState DoorState { get; private set; } // private set to leave setting inside of the class
    private string Passcode; // field names with underscore better? differenetiate from properties

    public Door(string passcode)
    {
        Passcode = passcode;
    }
    public void Close()
    {
        if (DoorState == DoorState.Open)
        {
            DoorState = DoorState.Closed;
        }
        else if (DoorState == DoorState.Closed)
        {
            Console.WriteLine("The door is already closed can't you see?");
        }
    }
    public void Open()
    {
        if (DoorState == DoorState.Closed)
        {
            DoorState = DoorState.Open;
        }
    }
    public void Lock()
    {
        if (DoorState == DoorState.Closed)
        {
            DoorState = DoorState.Locked;
        }
        else if (DoorState == DoorState.Open)
        {
            Console.WriteLine("Please close the door first");
        }
    }
    public void Unlock(string? code)
    {
        if (DoorState == DoorState.Locked)
        {
            while (code == "" || code.All(char.IsLetter))
            {
                Console.Write("What is the code: ");
                code = Console.ReadLine();
            }
            
            if (Passcode == code)
            {
                DoorState = DoorState.Closed;
            }
            else
            {
                Console.WriteLine("Passcode incorrect");
            }  
        }
        else if (DoorState == DoorState.Open)
        {
            Console.WriteLine("The door is already unlocked");
        }
        else if (DoorState == DoorState.Closed)
        {
            Console.WriteLine("The door is already unlocked");
        }  
    }
    public void ChangePassCode(string currentCode, string newCode)
    {

        while (currentCode == "" || currentCode.All(char.IsLetter))
        {
            Console.Write("Type in your current code: ");
            currentCode = Console.ReadLine()!;
        }
        if (Passcode == currentCode)
        {
            while (newCode == "" || newCode.All(char.IsLetter))
            {
                Console.Write("Type in your new passcode: ");
                newCode = Console.ReadLine()!;
            }
            Passcode = newCode;
        }
        else
        {
            Console.WriteLine("Current passcode incorrect");
        }
    }
}
public enum DoorState { Locked, Open, Closed }
