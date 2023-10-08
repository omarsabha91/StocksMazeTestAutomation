using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;


public class SellerTestBase
{
    protected IWebDriver Driver { get; set; }
    protected StocksMaze.Pages.StocksMazeSeller.HomePage SellerHomePage { get; private set; }

    public SellerTestBase()
    {
        if (DriverManager.driver == null)
        {
            DriverManager.driver = DriverManager.CreateWebDriver();
        }

        Driver = DriverManager.driver;
        SellerHomePage = new StocksMaze.Pages.StocksMazeSeller.HomePage(Driver);
    }
    [TestInitialize]
    public void TestInitialize()
    {
        Driver = DriverManager.CreateWebDriver();
        string baseUrl = Config.StocksmazeSeller;
        Driver.Navigate().GoToUrl(baseUrl);
    }
    [TestCleanup]
    public void Teardown()
    {
        Driver?.Quit();
    }
}
