namespace sixth_lab;

class Program
{
    static void Main()
    {
        CylindricalCoordinates coord = new CylindricalCoordinates(5, Math.PI / 4, 10);
        coord.DisplayCoordinates();
        coord.DisplayCylindricalCoordinates();
    }
}