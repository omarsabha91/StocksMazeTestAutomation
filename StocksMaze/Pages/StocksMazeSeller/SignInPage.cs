using OpenQA.Selenium;
using StocksMaze.ElementInteractions;
namespace StocksMaze.Pages.StocksMazeSeller
{
    public class SignInPage
    {
        private IWebDriver _driver;
        public SignInPage(IWebDriver driver)
        {
            _driver = driver;
        }
        public InputInteraction PhoneNumberField => new InputInteraction(_driver, By.Id("phone"));
        public InputInteraction PasswordField => new InputInteraction(_driver, By.Id("password"));
        public ButtonInteractions LoginButton => new ButtonInteractions(_driver, By.Id("submit-button"));
        public ButtonInteractions GoogleSignInButton => new ButtonInteractions(_driver, By.XPath("//span[text()='Sign in with Google']"));
        public ButtonInteractions AppleSignInButton => new ButtonInteractions(_driver, By.XPath("//span[text()='Sign in with Apple']"));

    }
}
