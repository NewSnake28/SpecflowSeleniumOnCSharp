using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using MQTASelenium;

namespace MQTASelenium;

public class LoginPage : SharedComponents, IPage
{
    [FindsBy(How = How.Id, Using = "txtCompanyName")]
    private IWebElement companyNameTextField;

    [FindsBy(How = How.Id, Using = "txtUserName")]
    private IWebElement usernameTextField;

    [FindsBy(How = How.Id, Using = "txtUserPass")]
    private IWebElement passwordTextField;

    [FindsBy(How = How.Id, Using = "MainContent_loginUI_cmdLogin")]
    private IWebElement logInButton;


    public void EnterCredentials(string companyName,string username, string password)
    {
        companyNameTextField.SendKeys(companyName);
        usernameTextField.SendKeys(username);
        passwordTextField.SendKeys(password);
    }

    public void ClickLogin()
    {
        logInButton.Click();
    }
}