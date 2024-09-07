namespace third_lab;

class Program
{
    static int CountValidPoints(Point[] points)
    {
        int validCount = 0;

        foreach (var point in points)
        {
            if (point.AreCoordinatesIntegers() && point.IsInFirstOctant())
            {
                validCount++;
            }
        }

        return validCount;
    }

    static void Main(string[] args)
    {
        var points = new Point[]
        {
            new Point(1, 2, 3),
            new Point(-1, 5.5, 3),
            new Point(0, 1, 2),
            new Point(3.5, 1, 2),
            new Point(10, 5, 6)
        };

        int validPoints = CountValidPoints(points);
        Console.WriteLine($"Кількість дійсних points (цілі числа та перший октант): {validPoints}");

        points = null;
        GC.Collect();
        GC.WaitForPendingFinalizers();
    }
}