using System;
using OpenQA.Selenium;
using StocksMaze.ElementInteractions;

namespace StocksMaze.Pages.StocksMazeSeller
{
	public class OTPVerificationPage
	{
        private IWebDriver _driver;
        public OTPVerificationPage(IWebDriver driver)
		{
            _driver = driver;
        }
        public ButtonInteractions SubmitButton => new ButtonInteractions(_driver, By.CssSelector("button[type='submit']"));
        public InputInteraction DigitOneField => new InputInteraction(_driver, By.Id("digit-1"));
        public InputInteraction DigitTwoField => new InputInteraction(_driver, By.Id("digit-2"));
        public InputInteraction DigitThreeField => new InputInteraction(_driver, By.Id("digit-3"));
        public InputInteraction DigitFourField => new InputInteraction(_driver, By.Id("digit-4"));



    }
}

