namespace fifth_lab;

public class PolarCoordinates
{
    public double Radius { get; set; }
    public double Angle { get; set; }
    public PolarCoordinates(double radius, double angle)
    {
        Radius = radius;
        Angle = angle;
    }
    public virtual void SetPolarCoordinates(double radius, double angle)
    {
        Radius = radius;
        Angle = angle;
    }
    public virtual void SetCartesianCoordinates(double x, double y)
    {
        Radius = Math.Sqrt(x * x + y * y);
        Angle = Math.Atan2(y, x);
    }
    public virtual void ConvertToCartesian(out double x, out double y)
    {
        x = Radius * Math.Cos(Angle);
        y = Radius * Math.Sin(Angle);
    }
}