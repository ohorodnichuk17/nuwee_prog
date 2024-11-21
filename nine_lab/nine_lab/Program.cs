namespace nine_lab;

public class Program
{
    static void Main()
    {
        ICarBuilder builder = new CarBuilder();
        CarDirector director = new CarDirector(builder);

        director.ConstructSportCar();
        Car sportsCar = builder.GetCar();
        Console.WriteLine(sportsCar);

        director.ConstructSuv();
        Car suv = builder.GetCar();
        Console.WriteLine(suv);
    }
}
