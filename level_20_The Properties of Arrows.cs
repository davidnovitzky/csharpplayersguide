Arrow arrow = new Arrow(ChooseArrowHeadType(), ChooseFletchingType(), ChooseShaftLength());
Console.WriteLine($"The arrow costs {arrow.GetCost} gold.");
Console.WriteLine($"You picked a {arrow.Arrowhead} arrowhead type");
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
    // Properties with only getters (read-only outside constructor)
    public ArrowheadType Arrowhead { get; }
    public FletchingType Fletching { get; }
    public float Length { get; }

    public Arrow(ArrowheadType arrowhead, FletchingType flethcing, float length)
    {
        Arrowhead = arrowhead;
        Fletching = flethcing;
        Length = length;
    }
    public float GetCost
    {
        get
        {
            float shaftCost = 0.05f * Length;
 
            float arrowheadCost = Arrowhead switch
            {
                ArrowheadType.Steel => 10f,
                ArrowheadType.Wood => 3f,
                ArrowheadType.Obsidian => 5f
            };
            float fletchingCost = Fletching switch
            {
                FletchingType.Plastic => 10f,
                FletchingType.TurkeyFeathers => 5f,
                FletchingType.GooseFeathers => 3f
            };

            return shaftCost + arrowheadCost + fletchingCost;
        }
    }
}
enum ArrowheadType { Steel, Wood, Obsidian }
enum FletchingType { Plastic, TurkeyFeathers, GooseFeathers }
