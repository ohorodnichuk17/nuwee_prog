namespace sixth_lab;

public class CylindricalCoordinates : Coordinates
{
    public double Height { get; set; }
    public CylindricalCoordinates(double radius, double angle, double height) 
        : base(radius, angle)
    {
        Height = height;
    }
    public override void SetCoordinates(double radius, double angle)
    {
        Radius = radius;
        Angle = angle;
    }
    public override void ConvertToCartesian(out double x, out double y)
    {
        x = Radius * Math.Cos(Angle);
        y = Radius * Math.Sin(Angle);
    }
    public void DisplayCylindricalCoordinates()
    {
        ConvertToCartesian(out double x, out double y);
        Console.WriteLine($"Декартові координати: x = {x}, y = {y}, z = {Height}");
    }
}