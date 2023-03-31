using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using MQTASelenium;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Support.UI;


namespace MQTASelenium
{
    public class HRAdminPage
    {
        [FindsBy(How = How.ClassName, Using = "Icon_Add")]
        private IWebElement AddIcon;

        [FindsBy(How = How.ClassName, Using = "Icon_Save")]
        private IWebElement SaveIcon;

        [FindsBy(How = How.ClassName, Using = "Icon_Copy")]
        private IWebElement CopyIcon;

        [FindsBy(How = How.XPath, Using = ".//*[contains(@class,'dgrid-selected')]//td[1]")]
        private IWebElement StatusName;

        [FindsBy(How = How.XPath, Using = ".//*[contains(@class,'dgrid-row-table')]//td[contains(@class,'dgrid-focus')]/div")]
        private IWebElement StatusNameTextField;



        public void AddNewStatus()
        {

            AddIcon.Click();

        }

        public void SaveStatus()
        {

            SaveIcon.Click();

        }

        public void CopyStatusRecord()
        {

            CopyIcon.Click();

        }
        public void AddNewStatusRecord()
        {
            //IWebElement simpleTable = (IWebElement)Browser.Driver.FindElement(By.ClassName("dgrid-tree-container"));
            //IList<IWebElement> rows = simpleTable.FindElements(By.TagName("tr"));
            //IList<IWebElement> tds = simpleTable.FindElements(By.TagName("td"));

            //foreach (IWebElement row in rows)
            //{
            //    IList<IWebElement> tds = row.FindElements(By.TagName("td"));
            //    foreach (IWebElement td in tds)
            //    {
            //        td.Click();
            //        td.SendKeys("test1");
            //    }


            //}
            StatusName.Click();
            StatusNameTextField.SendKeys("NewStatus");
        }

        


    }
}
