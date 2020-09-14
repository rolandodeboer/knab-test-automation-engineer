using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace KnabTestAutomation.Pages
{
    public class LoginPage
    {

        public IWebDriver Webdriver { get; }

        public LoginPage(IWebDriver webdriver)
        {
            Webdriver = webdriver;
        }

        //UI elements
        public IWebElement lnkLogin => Webdriver.FindElement(By.LinkText("Log In"));
        public IWebElement txtUsername => Webdriver.FindElement(By.Id("user"));
        public IWebElement txtPassword => Webdriver.FindElement(By.Id("password"));
        public IWebElement btnLogin => Webdriver.FindElement(By.Id("login"));
        public IWebElement menuProfile => Webdriver.FindElement(By.XPath("//button[@aria-label='Open Member Menu']"));
        public IWebElement btnBoardMenu => Webdriver.FindElement(By.XPath("//button[@aria-label='Open Boards Menu']"));

        //Methods
        public void ClickLogin() => lnkLogin.Click();
        public void ClickBoard() => btnBoardMenu.Click();


        public void Login(string username, string password)
        {
            txtUsername.SendKeys(username);
            txtPassword.SendKeys(password);
        }

        public void ClickLoginButton() => btnLogin.Click();

        public void LoginUser()
        {

            //waitForPageUntilElementIsVisible(By.LinkText("Log In"), 10);
            Thread.Sleep(3000);
            ClickLogin();

            //waitForPageUntilElementIsVisible(By.Id("user"), 10);
            Thread.Sleep(5000);
            Login("rolando.de.boer@the-future-group.com", "sRmvSYkryib7");

            //waitForPageUntilElementIsVisible(By.Id("login"), 10);
            Thread.Sleep(1000);    
            ClickLoginButton();
            Console.WriteLine("I just clicked the login button");

        }

        public bool IsMenuProfileIconExists() => menuProfile.Displayed; 
        
        public IWebElement waitForPageUntilElementIsVisible(By locator, int maxSeconds)
        {
            return new WebDriverWait(Webdriver, TimeSpan.FromSeconds(maxSeconds))
                .Until(ExpectedConditions.ElementIsVisible((locator)));
        }

        public void OpenBoard()
        {
            Thread.Sleep(1000);
            ClickBoard();
        }
    }
}
