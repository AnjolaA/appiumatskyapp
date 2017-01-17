using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using atskyapptest.Settings;
using OpenQA.Selenium;

namespace atskyapptest.pages
{
    public class SignInPage : BasePage
    {
       public  By signIn = By.ClassName("android.widget.Button");

        public SignInPage(IWebDriver driver) : base(driver)
        {
        }

        public LoginPage GoToLoginScreen()
        {
            Console.WriteLine("Got to Sign in Page ");
            ObjectRepository.Driver.FindElement(signIn).Click();
            return new LoginPage(ObjectRepository.Driver);
        }
    }
}
