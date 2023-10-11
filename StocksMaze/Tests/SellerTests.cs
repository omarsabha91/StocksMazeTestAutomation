
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

[TestClass]
public class SellerTests : SellerTestBase
{

    [TestMethod]
    public void SellerHomePageSmokeTest()
    {
      
        Assert.IsTrue(Driver.Title.Contains("Grow Your Business on Stocks Maze: Your Seller Hub"), "The title did not contain the expected text.");
        Thread.Sleep(1000);
        SellerHomePage.SignInButton.click();
        Thread.Sleep(5000);
    }

    
}



//Test Cases list to validate before build certification:
//1 - seller sign up via Google and Apple
//2- seller sign up via phone number
//3- store creation, and payout setup
//4- creat 3 products with color and size combination
  //a. Vehicle
  //b. Car part (delivery , manual shipping )
//  c.Electronic(pick up and delivery via GoShippo)
//5 - verify those products are editable after creation
//6- verify those products proper view on buyer platform ( mobile and web apps)
//7 - verify bugs fixed listed in the new build
//8 - check out the electronic and car part products
