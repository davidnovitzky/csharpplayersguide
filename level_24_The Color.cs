Color colorRed = new Color(255, 0, 0);
Color colorBlue = Color.Blue;

Console.WriteLine($"{colorRed.RedChannel}, {colorRed.GreenChannel}, {colorRed.BlueChannel}");
Console.WriteLine($"{colorBlue.RedChannel}, {colorBlue.GreenChannel}, {colorBlue.BlueChannel}");

public class Color
{
    public int RedChannel { get; }
    public int GreenChannel { get; }
    public int BlueChannel { get; }

    public Color(int r, int g, int b)
    {
        RedChannel = r;
        GreenChannel = g;
        BlueChannel = b;
    }

    public static Color White { get; } = new Color(255, 255, 255);
    public static Color Black { get; } = new Color(0, 0, 0);
    public static Color Red { get; } = new Color(255, 0, 0);
    public static Color Orange { get; } = new Color(255, 165, 0);
    public static Color Yellow { get; } = new Color(255, 255, 0);
    public static Color Green { get; } = new Color(0, 128, 0);
    public static Color Blue { get; } = new Color(0, 0, 255);
    public static Color Purple { get; } = new Color(128, 0, 128);
}
