namespace sixth_lab;
public interface ICoordinates
{
    double Radius { get; set; }
    double Angle { get; set; }

    void SetCoordinates(double radius, double angle);
    void ConvertToCartesian(out double x, out double y);
    void DisplayCoordinates();
}
