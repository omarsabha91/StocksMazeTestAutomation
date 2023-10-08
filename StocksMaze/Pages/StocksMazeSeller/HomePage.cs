using OpenQA.Selenium;
using StocksMaze.ElementInteractions;
namespace StocksMaze.Pages.StocksMazeSeller
{
    public class HomePage
    {
        private IWebDriver _driver;
        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }

        // UI Elements locators
        public ButtonInteractions SignInButton => new ButtonInteractions(_driver, By.CssSelector("a[href='/login/']"));

    }
}
