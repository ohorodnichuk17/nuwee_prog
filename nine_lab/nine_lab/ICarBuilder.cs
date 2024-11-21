namespace nine_lab;

public interface ICarBuilder
{
    void SetEngine(string engine);
    void SetTransmission(string transmission);
    void SetWheels(int wheels);
    void SetColor(string color);
    Car GetCar();
}