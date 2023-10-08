
using Microsoft.VisualStudio.TestTools.UnitTesting;


[TestClass]
public class SellerTests : TestBase
{
    [TestInitialize]
    public void SellerSetup()
    {
        Driver = DriverManager.CreateWebDriver();
        string baseUrl = Config.StocksmazeSeller;
        Driver.Navigate().GoToUrl(baseUrl);
    }

    [TestMethod]
    public void HomePageSmokeTest()
    {

        Assert.IsTrue(Driver.Title.Contains("Grow Your Business on Stocks Maze: Your Seller Hub"), "The title did not contain the expected text.");
    }

    
}
