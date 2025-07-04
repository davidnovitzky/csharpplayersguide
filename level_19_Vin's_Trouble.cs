Arrow arrow = new Arrow(ChooseArrowHeadType(), ChooseFletchingType(), ChooseShaftLength());
Console.WriteLine($"The arrow costs {arrow.GetCost()} gold.");
Console.WriteLine($"You picked a {arrow.GetArrowHeadType()} arrowhead type");
ArrowheadType ChooseArrowHeadType()
{
    while (true)
    {
        Console.Write("Pick an arrowhead type (Steel, Wood, Obsidian): ");
        string arrowheadInput = Console.ReadLine().ToLower().Trim();

        switch (arrowheadInput)
        {
            case "steel":
                {
                    return ArrowheadType.Steel;
                }
            case "wood":
                {
                    return ArrowheadType.Wood;
                }
            case "obsidian":
                {
                    return ArrowheadType.Obsidian;
                }
            default:
                {
                    Console.WriteLine("Invalid Arrow Head Type");
                    break;
                }
        }
    }
}
FletchingType ChooseFletchingType()
{
    while (true)
    {
        Console.Write("Pick a Fletching type (Plastic, Turkey Feathers, Goose Feathers): ");
        string fletchingTypeInput = Console.ReadLine().ToLower().Trim();

        switch (fletchingTypeInput)
        {
            case "plastic":
                {
                    return FletchingType.Plastic;
                }
            case "turkey feathers":
                {
                    return FletchingType.TurkeyFeathers;
                }
            case "goose feathers":
                {
                    return FletchingType.GooseFeathers;
                }
            default:
                {
                    Console.WriteLine("Invalid Fletching Type");
                    break;
                }
        }
    }
}

float ChooseShaftLength()
{
    float shaftLengthInput = 0;

    while (shaftLengthInput < 60 || shaftLengthInput > 100)
    {
        Console.Write("Pick a length for your shaft (60cm-100cm): ");
        shaftLengthInput = float.Parse(Console.ReadLine());
    }
    return shaftLengthInput;
}
class Arrow
{
    private ArrowheadType Arrowhead; // restricts access to change after user input
    private FletchingType Fletching; // restricts access to change after user input
    private float Length; // restricts access to change after user input

    public Arrow(ArrowheadType arrowhead, FletchingType flethcing, float length)
    {
        Arrowhead = arrowhead; 
        Fletching = flethcing;
        Length = length;
    }

    public ArrowheadType GetArrowHeadType() => Arrowhead; // creates a getter method to get access to the value
    public FletchingType GetFletchingType() => Fletching; // creates a getter method to get access to the value
    public float GetShaftLength() => Length; // creates a getter method to get access to the value
    public float GetCost() 
    {
        float shaftCost = 0.05f * Length;
        float arrowCost;
        float arrowheadCost;
        float fletchingCost;

        switch (Arrowhead)
        {
            case ArrowheadType.Steel:
                arrowheadCost = 10.0f;
                break;
            case ArrowheadType.Wood:
                arrowheadCost = 3.0f;
                break;
            case ArrowheadType.Obsidian:
                arrowheadCost = 5.0f;
                break;
            default:
                arrowheadCost = 0f;
                break;
        }
        switch (Fletching)
        {
            case FletchingType.Plastic:
                fletchingCost = 10.0f;
                break;
            case FletchingType.TurkeyFeathers:
                fletchingCost = 5.0f;
                break;
            case FletchingType.GooseFeathers:
                fletchingCost = 3.0f;
                break;
            default:
                fletchingCost = 0f;
                break;
        }
        return arrowCost = arrowheadCost + shaftCost + fletchingCost;
    }
}
enum ArrowheadType { Steel, Wood, Obsidian }
enum FletchingType { Plastic, TurkeyFeathers, GooseFeathers }
