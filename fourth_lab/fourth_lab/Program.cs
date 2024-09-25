namespace fourth_lab;
class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Оберіть тип перетворення:");
            Console.WriteLine("1. Циліндричні -> Декартові");
            Console.WriteLine("2. Декартові -> Циліндричні");
            Console.WriteLine("3. Вихід");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 3)
                break;
            switch (choice)
            {
                case 1:
                    Console.Write("Введіть радіус (r): ");
                    double r = double.Parse(Console.ReadLine());
                    Console.Write("Введіть кут (θ): ");
                    double theta = double.Parse(Console.ReadLine());
                    Console.Write("Введіть висоту (z): ");
                    double z = double.Parse(Console.ReadLine());

                    CylindricalCoordinates cylindrical = new CylindricalCoordinates(r, theta, z);
                    cylindrical.ConvertToCartesian(out double x, out double y, out double zCartesian);
                    Console.WriteLine($"Декартові координати: x = {x}, y = {y}, z = {zCartesian}");
                    break;
                case 2:
                    Console.Write("Введіть x: ");
                    double xCartesian = double.Parse(Console.ReadLine());
                    Console.Write("Введіть y: ");
                    double yCartesian = double.Parse(Console.ReadLine());
                    Console.Write("Введіть z: ");
                    double zValue = double.Parse(Console.ReadLine()); 
                    PolarCoordinates polar = new PolarCoordinates(0, 0);
                    polar.SetCartesianCoordinates(xCartesian, yCartesian);
                    Console.WriteLine($"Циліндричні координати: r = {polar.Radius}, θ = {polar.Angle}, z = {zValue}");
                    break;
                default:
                    Console.WriteLine("Некоректний вибір.");
                    break;
            }
            Console.WriteLine();
        }
    }
}
