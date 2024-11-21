namespace nine_lab;

public class CarDirector
{
    private ICarBuilder _builder;

    public CarDirector(ICarBuilder builder)
    {
        _builder = builder;
    }

    public void ConstructSportCar()
    {
        _builder.SetEngine("V8");
        _builder.SetTransmission("Automatic");
        _builder.SetWheels(4);
        _builder.SetColor("Red");
    }

    public void ConstructSuv()
    {
        _builder.SetEngine("V6");
        _builder.SetTransmission("Manual");
        _builder.SetWheels(4);
        _builder.SetColor("Black");
    }
}