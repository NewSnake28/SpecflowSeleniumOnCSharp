using System;
using TechTalk.SpecFlow;
using MQTASelenium;
using OpenQA.Selenium;
using NUnit.Framework;

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

        //then @swaglabs should be display
        [Then(@"(.*) should be displayed")]
        public void ThenShouldBeDisplayed(String Title)
        {
            Assert.True(Title == Browser.Title);
            /*if (website == "SwagLabs")
            {
                Assert.
            }
            else if (website == "Magento")
            {
                Pages.SharedComponents.MagentoLogo();
            }*/
        }   




        [When(@"user clicks on Hamburger Icon")]
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
