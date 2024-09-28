class Program
{
    static void Main()
    {
        PolarCoordinates coordinates = new CylindricalCoordinates(5, Math.PI / 4, 10);
        
        coordinates.ConvertToCartesian(out double x, out double y);
        
        Console.WriteLine($"Декартові координати: x = {x}, y = {y}");
    }
}