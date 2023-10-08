using System;
using System.Diagnostics;
using System.Threading;
using OpenQA.Selenium;
using StocksMaze.Drivers;


namespace StocksMaze.ElementInteractions
{
    public class ButtonInteractions
    {
        private IWebDriver _driver;

        private By ButtonLocator;

        public ButtonInteractions(IWebDriver driver, By locator)
        {
            _driver = driver;
            ButtonLocator = locator;
        }


        public Boolean ClickAndWaitForStale(By ElementToGoStale, int timeoutInSeconds = 5)
        {

            IWebElement ButtonToClickon = _driver.FindElement(ButtonLocator);

            IWebElement staleElement = _driver.FindElement(ElementToGoStale);
            ButtonToClickon.Click();

            try
            {
                var SW = new Stopwatch();
                if (SW.Elapsed < TimeSpan.FromSeconds(timeoutInSeconds))
                {
                    Thread.Sleep(250);
                    staleElement.GetAttribute("InnerText");
                }

            }

            catch (StaleElementReferenceException)
            {

                return true;

            }

            return false;

        }


        public void click()
        {
            IWebElement Button = _driver.FindElement(ButtonLocator);
            Button.Click();
            _driver.WaitForPageLoad();
        }
    }
}
