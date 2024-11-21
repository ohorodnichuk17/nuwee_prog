namespace ten_lab;

public class WebTestDecorator : IWebTest
{
    protected IWebTest _webTest;

    public WebTestDecorator(IWebTest webTest)
    {
        _webTest = webTest;
    }

    public virtual void RunTest()
    {
        _webTest.RunTest();
    }
}