using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Text;

namespace MQTASelenium
{
    public class Browser
    {
        public static string SwagLabs = "http://www.saucedemo.com/";
        public static string Magento = "https://magento.softwaretestingboard.com/";
        string[] browsers = { "Chrome", "Firefox", "Edge" };


        public static string baseUrl;
        public static WebDriver webDriver = new ChromeDriver();

       /* public static void web(string[] browsers)
        {
            foreach (string browser in browsers)
            {

                switch (browser)
                {
                    case "Chrome":
                        webDriver = new ChromeDriver();
                        break;
                    case "Firefox":
                        webDriver = new FirefoxDriver();
                        break;
                    case "Edge":
                        webDriver = new EdgeDriver();
                        break;
                }
            }
        }*/


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
            switch (website)
            {
                case "SwagLabs":
                    baseUrl = SwagLabs;
                    break;
                case "Magento":
                    baseUrl = Magento;
                    break;
            }

            webDriver.Navigate().GoToUrl(baseUrl);
        }

        public static void Close()
        {
            webDriver.Close();
        }
    }
}
