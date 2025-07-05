Point point1 = new Point(2, 3);
Point point2 = new Point(-4, 0);

Console.WriteLine($"({point1.xCoord}, {point1.yCoord})");
Console.WriteLine($"({point2.xCoord}, {point2.yCoord})");

class Point
{
    // my properties are immutable to prevent accidental modification
    public int xCoord { get; }
    public int yCoord { get; }

    public Point(int x, int y)
    {
        xCoord = x;
        yCoord = y;
    }

    public Point()
    {
        xCoord = 0;
        yCoord = 0;
    }
}
