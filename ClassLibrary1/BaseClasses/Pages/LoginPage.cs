using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using MQTASelenium;

namespace MQTASelenium;

public class LoginPage : SharedComponents, IPage
{
    [FindsBy(How = How.Id, Using = "user-name")]
    private IWebElement usernameTextField;

    [FindsBy(How = How.Id, Using = "password")]
    private IWebElement passwordTextField;

    [FindsBy(How = How.Id, Using = "login-button")]
    private IWebElement logInButton;


    public void EnterCredentials(string username, string password)
    {
        Browser.webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        usernameTextField.SendKeys(username);
        passwordTextField.SendKeys(password);
    }

    public void ClickLogin()
    {
        logInButton.Click();
    }
}