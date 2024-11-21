namespace ten_lab;

public class Program
{
    static void Main(string[] args)
    {
        IWebTest test = new ConcreteWebTest();
        
        test = new LoggingDecorator(test);
        test = new StatusCheckDecorator(test);
        
        test.RunTest();
    }
}