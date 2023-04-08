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

    [FindsBy(How = How.Id, Using = "email")]
    private IWebElement emailTextField;

    [FindsBy(How = How.Id, Using = "pass")]
    private IWebElement passTextField;

    [FindsBy(How = How.Id, Using = "send2")]
    private IWebElement signInButton;


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

    public void EnterEmailCredentials(String email, String password)
    {
        Browser.webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        emailTextField.SendKeys(email);
        passTextField.SendKeys(password);
    }

    public void SignIn()
    {
        signInButton.Click();
    }
}