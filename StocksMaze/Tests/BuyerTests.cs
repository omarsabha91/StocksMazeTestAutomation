using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class BuyerTests : TestBase
{
    [TestInitialize]
    public void BuyerSetup()
    {
        Driver = DriverManager.CreateWebDriver();
        string baseUrl = Config.Stocksmaze;
        Driver.Navigate().GoToUrl(baseUrl);
    }

    [TestMethod]
    public void HomePageSmokeTest()
    { 
        Assert.IsTrue(Driver.Title.Contains("Buy with Confidence: Connect with Local & Global Sellers | Stocks Maze"), "The title did not contain the expected text.");
    }

}