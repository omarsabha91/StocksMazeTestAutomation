using System;
using OpenQA.Selenium;
using StocksMaze.ElementInteractions;

namespace StocksMaze.Pages.StocksMazeSeller
{
	public class SignUpPage
	{

        private IWebDriver _driver;

        public SignUpPage(IWebDriver driver)
		{
            _driver = driver;
        }

        // UI Elements locators
        public InputInteraction PhoneNumberField => new InputInteraction(_driver, By.Id("phone"));
        public InputInteraction EmailField => new InputInteraction(_driver, By.Id("email"));
        public ButtonInteractions ContinueButton => new ButtonInteractions(_driver, By.CssSelector("button.media-w100[type='submit']"));
        public ButtonInteractions GoogleSignInButton => new ButtonInteractions(_driver, By.XPath("//span[text()='Sign in with Google']"));
        public ButtonInteractions AppleSignInButton => new ButtonInteractions(_driver, By.XPath("//span[text()='Sign in with Apple']"));
        public ButtonInteractions ClassSMSRadioButton => new ButtonInteractions(_driver, By.CssSelector("input[type='radio'][value='classic']"));
        public ButtonInteractions WhatsAppSMSRadioButton => new ButtonInteractions(_driver, By.CssSelector("input[type='radio'][value='whatsapp']"));
        
        

    }
}

