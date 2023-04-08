using TechTalk.SpecFlow;
using MQTASelenium;
using OpenQA.Selenium;
using NUnit.Framework;
using MQTASelenium.BaseClasses.Pages;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace SpecflowSeleniumOnCSharp.StepDefinitions
{
    [Binding]
    public class Test2StepDefinitions
    {
        //click on sign in button
        [When(@"I click on the My Account link")]
        public void WhenIClickOnTheMyAccountLink()
        {
            Browser.webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Browser.webDriver.FindElement(By.XPath("/html/body/div[1]/header/div[1]/div/ul/li[2]/a")).Click();
        }

        //Check browser title
        [Then(@"I should be on the (.*) page")]
        public void ThenIShouldBeOnTheLoginPage(String title)
        {
            Assert.True(title == Browser.Title);
        }

        //Enter login credentials
        [When(@"I enter login credentials with email (.*) and password (.*)")]
        public void WhenIEnterCredentials(String email, String password)
        {
            Browser.webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Pages.Login.EnterEmailCredentials(email, password);
            Pages.Login.SignIn();
        }

        //Search something
        [When(@"I enter search term (.*) and search")]
        public void WhenISearch(String search)
        {
            Browser.webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Pages.Codes.Search(search);
            Pages.Codes.SearchButton();

        }

        //Check search results
        [Then(@"I should be on the search page (.*)")]
        public void ThenIShouldBeOnTheSearchPage(String title)
        {
            var expectedTitle = $"Search results for: '{title}'";
            Browser.webDriver.FindElement(By.XPath(@"//html/body/div[1]/main/div[1]/h1/span")).Text.Contains(expectedTitle);
        }

        //Add searched item to view
        [When(@"I click on the (.*) in the list")]
        public void WhenIAddSearchedItemToView(String value)
        {
            Browser.webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Browser.webDriver.FindElement(By.XPath(@"//*[@id=""maincontent""]/div[3]/div[1]/div[2]/div[2]/ol/li[" + value + "]/div/a")).Click();

        }

        //Add item to cart
        [When(@"I click on the Add to Cart button")]
        public void WhenIAddTheSelectedItemToCart()
        {
            Browser.webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //add size
            Browser.webDriver.FindElement(By.XPath(@"/html/body/div[1]/main/div[2]/div/div[1]/div[4]/form/div[1]/div/div/div[1]/div[1]/div[1]")).Click();
            //add color
            Browser.webDriver.FindElement(By.XPath(@"/html/body/div[1]/main/div[2]/div/div[1]/div[4]/form/div[1]/div/div/div[2]/div[1]/div[1]")).Click();

            Browser.webDriver.FindElement(By.Id("product-addtocart-button")).Click();

        }

        //View cart popup
        [When(@"I click on the shopping cart button")]
        public void WhenIViewMyShoppingCart()
        {
            // Set the explicit wait timeout to 10 seconds
            WebDriverWait wait = new WebDriverWait(Browser.webDriver, TimeSpan.FromSeconds(10000));
            Task.Delay(5000).Wait();
            Browser.webDriver.FindElement(By.XPath(@"/html/body/div[1]/header/div[2]/div[1]/a")).Click();
            
        }

        //view cart page
        [When(@"I click on the view and edit cart button")]
        public void WhenIClickOnViewAndEditCart()
        {
            Browser.webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Browser.webDriver.FindElement(By.XPath(@"/html/body/div[1]/header/div[2]/div[1]/div/div/div/div[2]/div[5]/div/a")).Click();
        
        }

        //Check cart page title
        [Then(@"I should be on the shopping cart page with (.*)")]
        public void ThenICheckCartTitle(String title)
        {
            Browser.webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            Assert.True(title == Browser.Title);

        }


        //go to about page
        [When(@"I click on the About Us link from footer")]
        public void WhenIClickOnTheAboutUsLink()
        {
            Task.Delay(2000).Wait();
            Browser.webDriver.FindElement(By.XPath(@"/html/body/div[1]/footer/div/div[2]/div/ul/li[1]/a")).Click();
        
        }

        //go to about page
        [When(@"I click on the whats new button form the navigation bar")]
        public void WhenIClickOnTheWhatsNewPage()
        {
            Task.Delay(2000).Wait();
            Browser.webDriver.FindElement(By.XPath(@"/html/body/div[1]/main/div[1]/h1/span")).Click();
        }

            // /html/body/div[1]/header/div[2]/div[1]/div/div/div/div[2]/div[5]/div/a


            ////html/body/div[1]/main/div[1]/h1/span
            ////html/body/div[1]/main/div[3]/div/div[2]/div[3]/div/div/ol/li[1]
            ////html/body/div[1]/main/div[3]/div/div[2]/div[3]/div/div/ol/li[3]/div/a/span/span/img
            /////*[@id="maincontent"]/div[3]/div[1]/div[2]/div[2]/ol/li[1]/div/a
        }
    }
