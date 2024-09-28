namespace sixth_lab;

class Program
{
    static void Main()
    {
        ICoordinates coord = new CylindricalCoordinates(5, Math.PI / 4, 10);
        coord.DisplayCoordinates();
        (coord as CylindricalCoordinates)?.DisplayCylindricalCoordinates();
    }
}