using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Support.PageObjects;
using TechTalk.SpecFlow;

namespace AppiumFramework.Base
{
    public class BasePage : Base
    {

        public AppiumDriver<AppiumWebElement> AppiumDriver;

        public BasePage() => AppiumDriver = DriverFactory.Instance.AppiumDriver;

        public TPage GetInstance<TPage>() where TPage : BasePage, new()
        {
            var T = Activator.CreateInstance(typeof(TPage));
            return (TPage)T;
        }

        public TPage As<TPage>() where TPage : BasePage
        {
            return (TPage)this;
        }


    }
}
