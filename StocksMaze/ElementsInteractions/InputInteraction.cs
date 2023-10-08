using OpenQA.Selenium;
using StocksMaze.Drivers.Extensions;
namespace StocksMaze.ElementInteractions
{
    public class InputInteraction
    {
        private By locator;
        private IWebDriver _driver;

        public InputInteraction(IWebDriver driver, By locator)
        {
            this.locator = locator;
            _driver = driver;
        }

        public void SetValue(string value)
        {
            var elem = _driver.WaitForElement(locator);
            elem.SendKeys(value);
        }
    }
}
