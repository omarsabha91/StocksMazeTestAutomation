using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

[TestClass]
public class BuyerTests : BuyerTestBase
{

    [TestMethod]
    public void BuyerHomePageSmokeTest()
    { 
        Assert.IsTrue(Driver.Title.Contains("Buy with Confidence: Connect with Local & Global Sellers | Stocks Maze"), "The title did not contain the expected text.");
    }

}