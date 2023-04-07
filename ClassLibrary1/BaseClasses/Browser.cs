using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace MQTASelenium
{
    public class Browser
    {
        public static string SwagLabs = "https://www.saucedemo.com/";
        public static string Magento = "https://magento.softwaretestingboard.com/";
        public static string baseUrl;
        public static WebDriver webDriver = new ChromeDriver(@"C:\DRIVERS");


        public static string Title
        {
            get { return webDriver.Title; }
        }

        public static WebDriver Driver
        {
            get { return webDriver; }
        }

        public static void Goto(String website)
        {
            //switch case to select url form declared public variables for different URLs
            switch (website)
            {
                case "SwagLabs":
                    baseUrl = SwagLabs;
                    break;
                case "Magento":
                    baseUrl = Magento;
                    break;
                default:
                    throw new Exception("Please select a valid URL");
            }
            webDriver.Navigate().GoToUrl(baseUrl);
        }

        public static void Close()
        {
            webDriver.Close();
        }
    }
}
