Console.Write("What is the passcode: ");
int.TryParse(Console.ReadLine(), out int passcode);

Door door1 = new(passcode);

while (true)
{
    Console.WriteLine($"The door is {door1.DoorState}.");
    Console.Write($"Do you want to (open, close, lock, unlock) or change the passcode to the door > ");

    string stateInput = Console.ReadLine();

    switch (stateInput)
    {
        case "unlock":
            door1.Unlock(passcode);
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
            Console.Write("What is the current code: ");
            int.TryParse(Console.ReadLine(), out int currentCode);

            if (passcode == currentCode)
            {
                Console.Write("Type in your new passcode: ");
                int.TryParse(Console.ReadLine(), out int newCode);
                door1.ChangePassCode(currentCode, newCode);
            }
            else
            {
                Console.WriteLine("Current password incorrect");
            }
            break;
    }
}


public class Door
{
    public DoorState DoorState { get; set; }
    private int Passcode;

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
        if (currentCode == Passcode)
        {
            Passcode = newCode;
        }
    }
}
public enum DoorState { Locked, Open, Closed }
