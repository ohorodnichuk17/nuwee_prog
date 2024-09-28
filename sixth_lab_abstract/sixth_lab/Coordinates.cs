namespace sixth_lab;
public abstract class Coordinates
{
    public double Radius { get; set; }
    public double Angle { get; set; }
    public Coordinates(double radius, double angle)
    {
        Radius = radius;
        Angle = angle;
    }
    public abstract void SetCoordinates(double radius, double angle);
    public abstract void ConvertToCartesian(out double x, out double y);
    public void DisplayCoordinates()
    {
        Console.WriteLine($"Координати: r = {Radius}, θ = {Angle}");
    }
}