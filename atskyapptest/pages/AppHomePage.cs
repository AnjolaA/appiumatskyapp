using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using atskyapptest.Settings;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace atskyapptest.pages
{
    public class AppHomePage : BasePage
    {
        public AppHomePage(IWebDriver driver) : base(driver)
        {
        }

        [FindsBy(How = How.XPath, Using = "//android.widget.ImageView[contains(@resource-id,'com.bskyb.employee:id/Logo')]")]
        public IWebElement Logo;

        public By LogoBy = By.XPath("//android.widget.ImageView[contains(@resource-id,'com.bskyb.employee:id/Logo')]");

    }
}
