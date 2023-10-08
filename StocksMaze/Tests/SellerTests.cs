
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

[TestClass]
public class SellerTests : SellerTestBase
{

    [TestMethod]
    public void HomePageSmokeTest()
    {

        Assert.IsTrue(Driver.Title.Contains("Grow Your Business on Stocks Maze: Your Seller Hub"), "The title did not contain the expected text.");
        Thread.Sleep(1000);
        SellerHomePage.SignInButton.click();
        Thread.Sleep(5000);
    }

    
}
