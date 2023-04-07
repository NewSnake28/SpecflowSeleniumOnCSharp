using System;
using TechTalk.SpecFlow;
using MQTASelenium;
using OpenQA.Selenium;

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

        [When(@"I login")]
        public void WhenIogin()
        {
            Pages.Login.EnterCredentials("DFLocal", "cadmin", "1"); 
            Pages.Login.ClickLogin();
            Pages.SharedComponents.WaitLoading(By.Id("splashScreenContainer"));
            Pages.SharedComponents.AcceptCookies();
            Thread.Sleep(TimeSpan.FromSeconds(30));
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
