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
        public ButtonInteractions SignInButton => new ButtonInteractions(_driver, By.XPath("/html/body/div/header/nav/div/div/div/div[2]/a"));

    }
}
