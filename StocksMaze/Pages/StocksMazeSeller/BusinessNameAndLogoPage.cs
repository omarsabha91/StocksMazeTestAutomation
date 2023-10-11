using System;
using OpenQA.Selenium;
using StocksMaze.ElementInteractions;

namespace StocksMaze.Pages.StocksMazeSeller
{
	public class BusinessNameAndLogoPage
	{
        private IWebDriver _driver;
        public BusinessNameAndLogoPage(IWebDriver driver)
		{
			_driver = driver;
		}
        public InputInteraction BusinessName => new InputInteraction(_driver, By.Id("name"));
        public ButtonInteractions NextButton => new ButtonInteractions(_driver, By.CssSelector("button[type='submit']"));
        //BusinessLogoFieldLocator
        //<input type="file" id="logo" accept="image/png, image/jpeg, image/jpg" name="logo" onchange="convertFileToBase64(this);imagePreview(event);" class="upload-profile-image form-control">

    }
}

