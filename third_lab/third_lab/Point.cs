namespace third_lab;
public class Point
{
    private double _x;
    private double _y;
    private double _z;
    private const double Epsilon = 1e-10;
    public Point(double x, double y, double z)
    {
        _x = x;
        _y = y;
        _z = z;
    }
    ~Point()
    {
        Console.WriteLine($"Об'єкт ({_x}, {_y}, {_z}) знищився");
    }
    public bool AreCoordinatesIntegers()
    {
        return Math.Abs(_x - Math.Round(_x)) < Epsilon &&
               Math.Abs(_y - Math.Round(_y)) < Epsilon &&
               Math.Abs(_z - Math.Round(_z)) < Epsilon;
    }
    public bool IsInFirstOctant()
    {
        return _x > 0 && _y > 0 && _z > 0;
    }
}