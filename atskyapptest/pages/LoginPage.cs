using System;
using System.Runtime.Remoting.Messaging;
using atskyapptest.Settings;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace atskyapptest.pages
{
    public class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        By userNameInputBy = By.XPath("//android.widget.EditText[contains(@resource-id,'userNameInput')]");
        By passwordInputBy = By.XPath("//android.widget.EditText[contains(@resource-id,'passwordInput')]");


        public AppHomePage Login(String username, String password)
        {
            WebDriverWait wait = new WebDriverWait(ObjectRepository.Driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(userNameInputBy));
            ObjectRepository.Driver.FindElement(userNameInputBy).SendKeys(username);
            ObjectRepository.Driver.FindElement(passwordInputBy).SendKeys(password + "\n");
            return new AppHomePage(ObjectRepository.Driver);
         }

    }


}