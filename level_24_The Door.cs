Console.Write("What is the passcode: ");
int.TryParse(Console.ReadLine(), out int passcodeInput);

Door door1 = new(passcodeInput);

while (true)
{
    Console.WriteLine($"The door is {door1.DoorState}.");
    Console.Write($"Do you want to (open, close, lock, unlock) or change the passcode to the door > ");

    string stateInput = Console.ReadLine();
    int currentCode = 0;
    int newCode = 0;

    switch (stateInput)
    {
        case "unlock":
            Console.Write("What is the code: ");
            int.TryParse(Console.ReadLine(), out int codeGuess);
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
    private int Passcode; // field names with underscore better? differenetiate from properties

    public Door(int passcode)
    {
        Passcode = passcode;
    }
    public void Close()
    {
        if (DoorState == DoorState.Open)
        {
            DoorState = DoorState.Closed;
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
    }
    public void Unlock(int code)
    {
        if (DoorState == DoorState.Locked && Passcode == code)
        {
            DoorState = DoorState.Closed;
        }
    }
    public void ChangePassCode(int currentCode, int newCode)
    {

        Console.Write("Type in your current code: ");
        int.TryParse(Console.ReadLine(), out currentCode);

        if (Passcode == currentCode)
        {
            Console.Write("Type in your new passcode: ");
            int.TryParse(Console.ReadLine(), out newCode );
            Passcode = newCode;
        }
        else
        {
            Console.WriteLine("Current passcode incorrect");
        }
    }
}
public enum DoorState { Locked, Open, Closed }
