using OpenQA.Selenium;
using StocksMaze.Drivers.Extensions;
namespace StocksMaze.ElementInteractions
{
    public class LabelInteractions
    {
        private By locator;
        private IWebDriver _driver;

        public LabelInteractions(IWebDriver driver, By locator)
        {
            this.locator = locator;
            _driver = driver;
        }

        public string GetText()
        {
            var elem = _driver.WaitForElement(locator);
            return elem.Text;
        }
    }
}
