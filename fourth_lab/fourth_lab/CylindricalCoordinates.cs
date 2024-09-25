namespace fourth_lab;
public class CylindricalCoordinates : PolarCoordinates 

{
    public double Height { get; set; }
    public CylindricalCoordinates(double radius, double angle, double height) : base(radius, angle)
    {
        Height = height;
    }
    public void SetCylindricalCoordinates(double radius, double angle, double height)
    {
        base.SetPolarCoordinates(radius, angle); 

        Height = height;
    }
    public void SetCartesianCoordinates(double x, double y, double z)
    {
        base.SetCartesianCoordinates(x, y);
        Height = z;
    }
    public void ConvertToCartesian(out double x, out double y, out double z)
    {
        base.ConvertToCartesian(out x, out y);
        z = Height;  
    }
}