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
        private By loginButton = By.Id("loginButton"); // Replace with actual locator.

        

        // Interactions

        public void ClickLoginButton()
        {
            var button = new ButtonInteractions(_driver, loginButton);
            button.Click();
        }

     
    }
}
