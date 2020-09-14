using KnabTestAutomation.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace KnabTestAutomation.Steps
{
    [Binding]
    public class LoginSteps

    {

        //Anti-Context Injection code - Not recommended
        LoginPage loginPage = null;
        BoardPage boardPage = null;

        //Step definitions
        [Given(@"the Trello homepage is displayed")]
        public void GivenTheTrelloHomepageIsDisplayed()
        {
            IWebDriver webdriver = new ChromeDriver("C://Users/rolandodeboer/source/repos/KnabTestAutomation/KnabTestAutomation");
            webdriver.Navigate().GoToUrl("https://www.trello.com/");
            loginPage = new LoginPage(webdriver);
            boardPage = new BoardPage(webdriver);

        }

        [Given(@"I click the login link")]
        public void GivenIClickTheLoginLink()
        {
            loginPage.ClickLogin();
 
        }

        [When(@"I enter a username and password")]
        public void WhenIEnterAUsernameAndPassword(Table table)
        {
            dynamic data = table.CreateDynamicInstance();

            Thread.Sleep(3000);
            loginPage.Login((string)data.Username, (string)data.Password);
        }

        [When(@"I click the login button")]
        public void WhenIClickTheLoginButton()
        {
            loginPage.ClickLoginButton();

            Thread.Sleep(3000);

        }

        [Then(@"I should see the Trello board overview")]
        public void ThenIShouldSeeTheTrelloBoardOverview()
        {
            Assert.That(loginPage.IsMenuProfileIconExists(), Is.True);
        }

        [Then(@"I should not see the Trello board overview")]
        public void ThenIShouldNotSeeTheTrelloBoardOverview()
        {
            Assert.That(loginPage.IsMenuProfileIconExists(), Is.False);
        }

        [Given(@"I am logged in to Trello")]
        public void GivenIAmLoggedInToTrello()
        {
            
            loginPage.LoginUser();
        }

    }
}
