using System;

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace atskyapptest
{

    public class Test
    {
        public IWebDriver driver;

        
        public void AndroidSetUp()
        {
            //Setting Capabilities
            DesiredCapabilities capabilities = new DesiredCapabilities();
            capabilities.SetCapability("appium-version", "1.0");
            capabilities.SetCapability("platformName", "Android");
            capabilities.SetCapability("platformVersion", "6.0.1");
            capabilities.SetCapability("platform", "Mac");
            capabilities.SetCapability("deviceName", "Samsung Galaxy S6");
            capabilities.SetCapability("appPackage", "com.bskyb.employee");
            capabilities.SetCapability("appActivity", "md556394555d03a6a66402f2e4be897eeb4.SplashActivity");
            capabilities.SetCapability("app", "C:\\Users\\AAW05\\Documents\\Projects\\atskyapp\\app\\app_1463.apk");
            //Connecting to Appium Server
            driver = new RemoteWebDriver(new Uri("http://127.0.0.1:4723/wd/hub"), capabilities);
        }



        public void SignIn()
        {
            //Test to enter loginname & Password on login page
//            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
//            By signIn = By.ClassName("android.widget.Button");
//            wait.Until(ExpectedConditions.ElementIsVisible(signIn));
//            driver.FindElement(signIn).Click();
        }

        [OneTimeTearDown]
        public void End()
        {
            driver.Quit();
        }

    }
}
