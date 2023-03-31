using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using MQTASelenium;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Support.UI;
using Remotion.Linq.Parsing.Structure.IntermediateModel;
using NHibernate.Driver;

namespace MQTASelenium
{
    public class SharedComponents
    {
        [FindsBy(How = How.Id, Using = "onetrust-accept-btn-handler")]
        private IWebElement Cookies;
        
        [FindsBy(How = How.Id, Using = "splashScreenContainer")]
        private IWebElement LoadingMask;

        [FindsBy(How = How.ClassName, Using = "dfI_Nav_Hamburger")]
        private IWebElement HamburgerIcon;

        [FindsBy(How = How.ClassName, Using = "toast-success")]
        private IWebElement ToastSuccessMessage;

        public void AcceptCookies()
        {
            Cookies.Click();
            
        }

        public void WaitLoading(By loader)
        {
            WebDriverWait wait = new WebDriverWait(Browser.webDriver, new TimeSpan(0, 1, 0));
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(loader));
        }

        public void ClickHamburger()
        {
            HamburgerIcon.Click();
        }

        public void HRAdminFeature()
        {
            Browser.webDriver.FindElement(By.XPath(".//*[contains(@class, 'FeatureDisplayName') and contains(text(), 'HR Admin')]")).Click();
        }
        public void StatusSubFeature()
        {
            Browser.webDriver.FindElement(By.XPath(".//*[contains(@class, 'FeatureDisplayName') and starts-with(text(), 'Status')]")).Click();
        }

        public void ToastMSuccessMessage()
        {
            var wait = new WebDriverWait(Browser.webDriver, TimeSpan.FromSeconds(10));
            wait.Until(d => d.FindElement(By.ClassName("toast-success")));
        }
    }
}
