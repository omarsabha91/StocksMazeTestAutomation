using OpenQA.Selenium;
using StocksMaze.ElementInteractions;
namespace StocksMaze.Pages.StocksMazeBuyer
{
    public class HomePage
    {
        private IWebDriver _driver;
        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }
        // UI Elements locators
        public ButtonInteractions ProfileMenuButton => new ButtonInteractions(_driver, By.Id("profileMenu"));
        //public By SignInButtonLocator = By.CssSelector("input[title='submit']");



    }
}
