using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using atskyapptest.Settings;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace atskyapptest.BaseClass
{
    public class BaseClass
    {

        [OneTimeSetUp]
        public static void InitWebdriver()
        {
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
            ObjectRepository.Driver = new RemoteWebDriver(new Uri("http://127.0.0.1:4723/wd/hub"), capabilities);
        }

        
        public void End()
        {
            ObjectRepository.Driver.Quit();
        }

        [OneTimeTearDown]
        public static void TearDown()
        {
            if (ObjectRepository.Driver != null)
            {
                ObjectRepository.Driver.Close();
                ObjectRepository.Driver.Quit();
            }
        }
    }
}
