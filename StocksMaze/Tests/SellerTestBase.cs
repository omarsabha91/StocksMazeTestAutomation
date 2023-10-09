using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;


public class SellerTestBase
{
    protected IWebDriver Driver { get; set; }
    protected StocksMaze.Pages.StocksMazeSeller.HomePage SellerHomePage { get; private set; }
    protected StocksMaze.Pages.StocksMazeSeller.SignUpPage SignUpPage { get; private set; }
    protected StocksMaze.Pages.StocksMazeSeller.SignInPage SignInPage { get; private set; }
    protected StocksMaze.Pages.StocksMazeSeller.SetPasswordPage SetPasswordPage { get; private set; }
    protected StocksMaze.Pages.StocksMazeSeller.OTPVerificationPage OTPVerificationPage { get; private set; }
    public SellerTestBase()
    {
        if (DriverManager.driver == null)
        {
            DriverManager.driver = DriverManager.CreateWebDriver();
        }

        Driver = DriverManager.driver;
        SellerHomePage = new StocksMaze.Pages.StocksMazeSeller.HomePage(Driver);
        SignUpPage = new StocksMaze.Pages.StocksMazeSeller.SignUpPage(Driver);
        SignInPage = new StocksMaze.Pages.StocksMazeSeller.SignInPage(Driver);
        SetPasswordPage = new StocksMaze.Pages.StocksMazeSeller.SetPasswordPage(Driver);
        OTPVerificationPage = new StocksMaze.Pages.StocksMazeSeller.OTPVerificationPage(Driver);
    }
    [TestInitialize]
    public void TestInitialize()
    {
        string baseUrl = Config.StocksmazeSeller;
        Driver.Navigate().GoToUrl(baseUrl);
    }

    private void CaptureScreenshot(string testName)
    {
        // Create a directory to store screenshots if it doesn't exist
        string screenshotDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Screenshots");
        if (!Directory.Exists(screenshotDirectory))
        {
            Directory.CreateDirectory(screenshotDirectory);
        }

        // Capture the screenshot
        ITakesScreenshot screenshotDriver = Driver as ITakesScreenshot;
        Screenshot screenshot = screenshotDriver.GetScreenshot();
        string screenshotPath = Path.Combine(screenshotDirectory, $"{testName}_{DateTime.Now:yyyyMMddHHmmss}.png");
        screenshot.SaveAsFile(screenshotPath, ScreenshotImageFormat.Png);

        Console.WriteLine($"Screenshot saved: {screenshotPath}");
    }
    [TestCleanup]
    public void Teardown()
    {
        Driver?.Quit();
    }
}
