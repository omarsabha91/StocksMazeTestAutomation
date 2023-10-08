using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

public class TestBase
{
    protected IWebDriver Driver { get; set; }

    [TestCleanup]
    public void Teardown()
    {
        Driver?.Quit();
    }

    
}