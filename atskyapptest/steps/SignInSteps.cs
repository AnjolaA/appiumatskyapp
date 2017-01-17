using System;
using atskyapptest.pages;
using atskyapptest.Settings;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace atskyapptest.steps
{
    [Binding]
    public class SignInSteps
    {
        private AppHomePage appHomePage;

        [Given(@"I  login with valid details ""(.*)"" and ""(.*)""")]
        public void GivenILoginWithValidDetailsAnd(string username, string password)
        {
            Console.WriteLine("1");
            SignInPage signInPagepage = new SignInPage(ObjectRepository.Driver);
            Console.WriteLine("2");
            LoginPage loginPage = signInPagepage.GoToLoginScreen();
            Console.WriteLine("3");
            appHomePage = loginPage.Login(username, password);
        }


        [Then(@"I have access to the pages in the app")]
        public void ThenIHaveAccessToThePagesInTheApp()
        {
            WebDriverWait wait = new WebDriverWait(ObjectRepository.Driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(appHomePage.LogoBy));
            Assert.IsTrue(appHomePage.Logo.Displayed, "Logo is not Displayed");
        }
    }
}
