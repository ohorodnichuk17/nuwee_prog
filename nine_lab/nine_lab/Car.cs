namespace nine_lab;

public class Car
{
    public string Engine { get; set; }
    public string Transmission { get; set; }
    public int Wheels { get; set; }
    public string Color { get; set; }

    public override string ToString()
    {
        return $"Car with {Engine} engine, {Transmission} transmission, {Wheels} wheels, color {Color}.";
    }
}