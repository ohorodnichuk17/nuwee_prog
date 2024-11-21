namespace ten_lab;

public class StatusCheckDecorator : WebTestDecorator
{
    public StatusCheckDecorator(IWebTest webTest) : base(webTest) { }

    public override void RunTest()
    {
        Console.WriteLine("Checking status before running test...");
        base.RunTest();
    }
}