using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MQTASelenium.BaseClasses.Pages
{
    public class Codes
    {
        [FindsBy(How = How.Id, Using = "search")]
        private IWebElement SearchBar;



        //search
        public void Search(String search)
        {
            SearchBar.SendKeys(search);
        }        
        
        //click on search button
        public void SearchButton()
        {
            SearchBar.SendKeys(Keys.Return);
        }
    }
}
