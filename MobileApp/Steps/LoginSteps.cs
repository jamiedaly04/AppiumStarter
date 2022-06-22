using AppiumFramework.Base;
using SupervisorApp.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace SupervisorApp.Steps
{
    [Binding]
    public class LoginSteps
    {

        [Given(@"Im at the Login screen")]
        public void GivenImAtTheLoginScreen()
        {
            PageFactory.Instance.CurrentPage = new LoginPage();
            Assert.IsTrue(PageFactory.Instance.CurrentPage.As<LoginPage>().CheckLoginScreenShown());
        }

        [When(@"I Enter Valid instance details with Login Credentials")]
        public void WhenIEnterValidInstanceDetailsWithLoginCredentials(Table table)
        {
            PageFactory.Instance.CurrentPage.As<LoginPage>().Login(table);
        }

        [Then(@"I can Successfully Login")]
        public void ThenICanSuccessfullyLogin()
        {
            //Need to click button here and assert sync works
        }

    }
}
