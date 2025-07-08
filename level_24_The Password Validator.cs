PasswordValidator passValidator = new PasswordValidator();

while (true)
{
    Console.Write("Enter a password: ");
    string? passwordInput = Console.ReadLine();

    if (passValidator.IsValid(passwordInput!) == true)
    {
        Console.WriteLine("The password is valid");
    }
    else
    {
        Console.WriteLine("The password is invalid");
    }
}
public class PasswordValidator
{
    public bool IsValid(string password)
    {
        if (password.Contains('T')) return false;
        if (password.Contains('&')) return false;
        if (password.Contains(' ')) return false;
        if (password.Length < 6) return false;
        if (password.Length > 13) return false;
        if (!UpperCase(password)) return false;
        if (!IsNumber(password)) return false;
        if (!LowerCase(password)) return false;
        
        return true;
    }
    public bool UpperCase(string password)
    {
        foreach (char letter in password)
        {
            if (char.IsUpper(letter))
            {
                return true;
            }
        }
        return false;
    }
    public bool LowerCase(string password)
    {
        foreach (char letter in password)
        {
            if (char.IsLower(letter))
            {
                return true;
            }
        }
        return false;
    }
    public bool IsNumber(string password)
    {
        foreach (char letter in password)
        {
            if (char.IsDigit(letter))
            {
                return true;
            }
        }
        return false;
    }
}
