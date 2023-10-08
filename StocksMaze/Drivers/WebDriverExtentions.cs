using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Diagnostics;
using System.Threading;

namespace StocksMaze.Drivers
{
    public static class WebDriverExtensions
    {

        public static IWebElement WaitForElement(this IWebDriver driver, By by, int timeoutInSeconds = 10)
        {
            if (timeoutInSeconds > 0)
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
                return wait.Until(drv => drv.FindElement(by));
            }

            return driver.FindElement(by);
        }


        public static void WaitForPageLoad(this IWebDriver driver, int timeoutInSeconds = 30)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            wait.Until(drv => ((IJavaScriptExecutor)drv)
                .ExecuteScript("return document.readyState").Equals("complete"));
        }

        public static bool WaitForElementDisplayed(this IWebElement element, int waitTimeInSeconds)
        {
            var sw = Stopwatch.StartNew();
            while (sw.Elapsed < TimeSpan.FromSeconds(waitTimeInSeconds))
            {
                Thread.Sleep(250);
                if (element.Displayed)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
