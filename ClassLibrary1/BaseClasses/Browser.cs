using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace MQTASelenium
{
    public class Browser
    {
        public static string baseUrl = "http://d-pc1300tr.corpadds.com:51000/Mydayforce.aspx";
        public static WebDriver webDriver = new ChromeDriver(@"C:\DRIVERS");


        public static string Title
        {
            get { return webDriver.Title; }
        }

        public static WebDriver Driver
        {
            get { return webDriver; }
        }

        public static void Goto()
        {
            webDriver.Navigate().GoToUrl(baseUrl);
        }

        public static void Close()
        {
            webDriver.Close();
        }
    }
}
