using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;


public class BuyerTestBase
{
    protected IWebDriver Driver;
    protected StocksMaze.Pages.StocksMazeBuyer.HomePage BuyerHomePage { get; private set; }


    public BuyerTestBase()
    {
        if ( DriverManager.driver==null)
        {
            DriverManager.driver = DriverManager.CreateWebDriver();
        }

        Driver = DriverManager.driver;
        BuyerHomePage = new StocksMaze.Pages.StocksMazeBuyer.HomePage(Driver);
    }

    [TestInitialize]
    public void TestInitialize()
    {
        Driver = DriverManager.CreateWebDriver();
        string baseUrl = Config.Stocksmaze;
        Driver.Navigate().GoToUrl(baseUrl);
    }
    [TestCleanup]
    public void Teardown()
    {
        Driver?.Quit();
    }
}



