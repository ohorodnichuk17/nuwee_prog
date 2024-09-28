namespace sixth_lab;

public class CylindricalCoordinates : ICoordinates
{
    public double Radius { get; set; }
    public double Angle { get; set; }
    public double Height { get; set; }
    public CylindricalCoordinates(double radius, double angle, double height)
    {
        Radius = radius;
        Angle = angle;
        Height = height;
    }
    public void SetCoordinates(double radius, double angle)
    {
        Radius = radius;
        Angle = angle;
    }
    public void ConvertToCartesian(out double x, out double y)
    {
        x = Radius * Math.Cos(Angle);
        y = Radius * Math.Sin(Angle);
    }
    public void DisplayCoordinates()
    {
        Console.WriteLine($"Координати: r = {Radius}, θ = {Angle}");
    }
    public void DisplayCylindricalCoordinates()
    {
        ConvertToCartesian(out double x, out double y);
        Console.WriteLine($"Декартові координати: x = {x}, y = {y}, z = {Height}");
    }
}