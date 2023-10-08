using System;
using OpenQA.Selenium;

namespace StocksMaze.Pages.StocksMazeSeller
{
	public class OTPVerificationPage
	{
        private IWebDriver _driver;
        public OTPVerificationPage(IWebDriver driver)
		{
            _driver = driver;
        }
	}
}

