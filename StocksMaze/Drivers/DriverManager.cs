using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public static class DriverManager
{
    public static IWebDriver CreateWebDriver()
    {
      
        IWebDriver driver = new ChromeDriver();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
        driver.Manage().Window.Maximize();
        return driver;
    }
}