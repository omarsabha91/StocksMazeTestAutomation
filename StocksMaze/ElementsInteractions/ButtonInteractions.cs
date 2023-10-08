using OpenQA.Selenium;
using StocksMaze.Drivers.Extensions;


namespace StocksMaze.ElementInteractions
{
    public class ButtonInteractions
    {
        private By locator;
        private IWebDriver _driver;

        public ButtonInteractions(IWebDriver driver, By locator)
        {
            this.locator = locator;
            _driver = driver;
        }

        public void Click()
        {
            var elem = _driver.WaitForElement(locator);
            elem.Click();
        }
    }
}
