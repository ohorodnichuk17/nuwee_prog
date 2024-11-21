namespace ten_lab;

public class LoggingDecorator : WebTestDecorator
{
    public LoggingDecorator(IWebTest webTest) : base(webTest) { }

    public override void RunTest()
    {
        Console.WriteLine("Logging test run...");
        base.RunTest();
    }
}