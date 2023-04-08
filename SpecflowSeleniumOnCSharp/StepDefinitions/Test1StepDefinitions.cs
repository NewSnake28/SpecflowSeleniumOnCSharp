using System;
using TechTalk.SpecFlow;
using MQTASelenium;
using OpenQA.Selenium;
using NUnit.Framework;
using NHibernate.Cfg.MappingSchema;
using OpenQA.Selenium.Support.UI;

namespace SpecflowSeleniumOnCSharp.StepDefinitions
{
    [Binding]
    public class Test1StepDefinitions
    {
        [Given(@"I am on the (.*) website")]
        public void GivenIAmOnTheWebsite(String website)
        {
            Browser.Goto(website);
        }

        [When(@"I login with username (.*) and password (.*)")]
        public void WhenILoginWithUsernameAndPassword(String username, String password)
        {
            Pages.Login.EnterCredentials(username, password); 
            Pages.Login.ClickLogin();
        }

        //Title from browser
        [Then(@"(.*) should be displayed")]
        public void ThenShouldBeDisplayed(String Title)
        {
            Assert.True(Title == Browser.Title);
        }

        //Page title
        [Then(@"the page title should be (.*)")]
        public void ThenShouldBeChecked(String Title)
        {
            Browser.webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Browser.webDriver.FindElement(By.ClassName("title")).Text.Contains(Title);
        }

        //Navigation hamburger icon
        [When(@"I click on the hamburger icon")]
        public void WhenIClickOnTheHamburgerIcon()
        {
            Browser.webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Browser.webDriver.FindElement(By.Id("react-burger-menu-btn")).Click();
        }

        //Add to cart button
        [When(@"I click on (.*) button to add to cart")]
        public void WhenIAddToCart(String button)
        {
            Browser.webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Browser.webDriver.FindElement(By.Id(button)).Click();
        }

        //Shopping cart icon
        [When(@"I click on cart icon")]
        public void WhenIGoToCart()
        {
            Browser.webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Browser.webDriver.FindElement(By.ClassName("shopping_cart_link")).Click();
        }

        //checkout button
        [When(@"I click on checkout button")]
        public void WhenICheckOut()
        {
            Browser.webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Browser.webDriver.FindElement(By.Id("checkout")).Click();
        }

        //Checkout Fill
        [When(@"I continue with firstname (.*) and lastname (.*) and postalcode (.*)")]
        public void WhenIContinueCheckout(String firstname, String lastname, String postalcode)
        {
            Browser.webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Browser.webDriver.FindElement(By.Id("first-name")).SendKeys(firstname);
            Browser.webDriver.FindElement(By.Id("last-name")).SendKeys(lastname);
            Browser.webDriver.FindElement(By.Id("postal-code")).SendKeys(postalcode);
            Browser.webDriver.FindElement(By.Id("continue")).Click();
        }

        //Finish button
        [When(@"I click on the checkout finish button")]
        public void WhenIFinish()
        {
            Browser.webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Browser.webDriver.FindElement(By.Id("finish")).Click();
        }

        // Logout
        [When(@"I click on Logout")]
        public void WhenILogout()
        {
            Browser.webDriver.FindElement(By.Id("react-burger-menu-btn")).Click();
        }

        //Filter icon
        [When(@"I click on the (.*) icon and choose an (.*) option")]
        public void WhenIClickOnTheFilterIcon(String Filter, String value)
        {
            Browser.webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Browser.webDriver.FindElement(By.ClassName(Filter)).Click();
            Browser.webDriver.FindElement(By.XPath("/html/body/div/div/div/div[1]/div[2]/div/span/select/option['" + value + "']")).Click();

        }





        [When(@"user clicks on Hamburger")]
        public void WhenUserClicksOnHamburgerIcon()
        {
            Pages.SharedComponents.ClickHamburger();
            Thread.Sleep(TimeSpan.FromSeconds(10));

        }

        [When(@"user navigates to HR Admin")]
        public void WhenUserNavigatesToHrAdmin()
        {
            Pages.SharedComponents.HRAdminFeature();
            Thread.Sleep(TimeSpan.FromSeconds(10));
        }

        [When(@"user clicks on Status")]
        public void WhenUserClicksOnStatus()
        {
            Pages.SharedComponents.StatusSubFeature();
            Thread.Sleep(TimeSpan.FromSeconds(10));
        }

        [When(@"user clicks on Add Button")]
        public void WhenUserClicksOnAddButton()
        {
            Pages.HRAdminPage.AddNewStatus();
            Thread.Sleep(TimeSpan.FromSeconds(10));
        }

        [When(@"user adds new status record")]
        public void WhenUserAddsNewStatusRecord()
        {
            Pages.HRAdminPage.AddNewStatusRecord();
        }

        [When(@"user saves status record")]
        public void WhenUserSavesStatusRecord()
        {
            Pages.HRAdminPage.SaveStatus();
        }

        [When(@"user copies status record")]
        public void WhenUserCopiesStatusRecord()
        {
            Pages.HRAdminPage.CopyStatusRecord();
        }


        [Then(@"toast success message is displayed")]
        public void ThenToastSuccessMessageIsDisplayed()
        {
            Pages.SharedComponents.ToastMSuccessMessage();
        }
    }
}
