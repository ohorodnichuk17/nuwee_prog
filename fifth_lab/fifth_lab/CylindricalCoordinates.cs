public class CylindricalCoordinates : PolarCoordinates
{
    public double Height { get; set; }

    public CylindricalCoordinates(double radius, double angle, double height) 
        : base(radius, angle)
    {
        Height = height;
    }

    public override void SetPolarCoordinates(double radius, double angle)
    {
        base.SetPolarCoordinates(radius, angle);
    }

    public override void SetCartesianCoordinates(double x, double y)
    {
        base.SetCartesianCoordinates(x, y);
    }

    public override void ConvertToCartesian(out double x, out double y)
    {
        base.ConvertToCartesian(out x, out y);
    }

    public void ConvertToCartesian(out double x, out double y, out double z)
    {
        base.ConvertToCartesian(out x, out y);
        z = Height;
    }
}