namespace second_lab;

public class Point
{
    private int x;
    private int y;
    private int z;

    public Point(int x, int y, int z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public static Point Input()
    {
        Console.WriteLine("Введіть координати точки:");
            
        Console.Write("X: ");
        int x = Convert.ToInt32(Console.ReadLine());
            
        Console.Write("Y: ");
        int y = Convert.ToInt32(Console.ReadLine());
            
        Console.Write("Z: ");
        int z = Convert.ToInt32(Console.ReadLine());
            
        return new Point(x, y, z);
    }

    public bool AreCoordinatesIntegers()
    {
        return x == (int)x && y == (int)y && z == (int)z;
    }

    public bool IsInFirstOctant()
    {
        return x > 0 && y > 0 && z > 0;
    }

    public void Print()
    {
        Console.WriteLine($"Координати точки: ({x}, {y}, {z})");

        if (AreCoordinatesIntegers())
        {
            Console.WriteLine("Всі координати цілочислові");
        }
        else
        {
            Console.WriteLine("Не всі координати є цілочисловими");
        }

        if (IsInFirstOctant())
        {
            Console.WriteLine("Точка знаходиться в першому октанті");
        }
        else
        {
            Console.WriteLine("Точка не знаходиться в першому октанті");
        }
    }
}

