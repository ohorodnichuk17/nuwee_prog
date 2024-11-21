namespace nine_lab;

public class CarBuilder : ICarBuilder
{
    private Car _car = new Car();

    public void SetEngine(string engine) => _car.Engine = engine;
    public void SetTransmission(string transmission) => _car.Transmission = transmission;
    public void SetWheels(int wheels) => _car.Wheels = wheels;
    public void SetColor(string color) => _car.Color = color;

    public Car GetCar() => _car;
}