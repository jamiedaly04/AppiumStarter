using AppiumFramework.Base;
using OpenQA.Selenium.Appium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SupervisorApp.Pages
{
    class LoginPage : BasePage
    {
        public AppiumWebElement CompanyName => AppiumDriver.FindElementByAccessibilityId("InstanceName");
        public AppiumWebElement UserEmailAddress => AppiumDriver.FindElementByAccessibilityId("UserEmail");
        public AppiumWebElement UserPassword => AppiumDriver.FindElementByAccessibilityId("UserPassword");

        internal bool CheckLoginScreenShown()
        {
            return CompanyName.Displayed && UserEmailAddress.Displayed && UserPassword.Displayed;
        }

        public void Login(Table table)
        {
            DriverFactory.Instance.WaitForElement(CompanyName);
            dynamic data = table.CreateDynamicInstance();
            CompanyName.SendKeys((string)data.Instance);
            UserEmailAddress.SendKeys((string)data.Email);
            UserPassword.SendKeys((string)data.Password);
        }
    }
}
