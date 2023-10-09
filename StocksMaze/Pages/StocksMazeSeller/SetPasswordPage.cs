using System;
using OpenQA.Selenium;
using StocksMaze.ElementInteractions;

namespace StocksMaze.Pages.StocksMazeSeller
{
	public class SetPasswordPage
	{
        private IWebDriver _driver;
        public SetPasswordPage(  IWebDriver driver)
		{
		            _driver = driver;
		}
        public InputInteraction PasswordField => new InputInteraction(_driver, By.Id("password"));
        public InputInteraction ConfirmPasswordField => new InputInteraction(_driver, By.Id("confirm_password"));
        public ButtonInteractions SaveButton => new ButtonInteractions(_driver, By.CssSelector("button[type='submit']"));
     


    }
}

