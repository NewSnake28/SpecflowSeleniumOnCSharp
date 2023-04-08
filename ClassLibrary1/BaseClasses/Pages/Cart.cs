using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MQTASelenium.BaseClasses.Pages
{
    public class Cart : SharedComponents, IPage
    {
        [FindsBy(How = How.Id, Using = "ad-to-cart-sauce-labs-backpack")]
        private IWebElement AddToCartButton;

        public void AddToCart(string button)
        {
            Browser.webDriver.FindElement(By.Id(button)).Click();
        }
    }
}
