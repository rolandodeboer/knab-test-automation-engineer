using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace KnabTestAutomation.Pages
{
    public class BoardPage
    {
        LoginPage loginpage = null;

        public IWebDriver Webdriver { get; }

        public BoardPage(IWebDriver webdriver)
        {
            Webdriver = webdriver;
        }

        //UI elements
        public IWebElement cardList => Webdriver.FindElement(By.XPath("//div[@class='js-list list-wrapper']"));
        public IWebElement linkAddAnotherCard => Webdriver.FindElement(By.XPath("//span[@class='js-add-another-card']"));
        public IWebElement txtCardTitle => Webdriver.FindElement(By.XPath("//textarea[@class='list-card-composer-textarea js-card-title']"));
        public IWebElement btnAddCard => Webdriver.FindElement(By.XPath("//input[@type='submit']"));
        public IWebElement tileBoard => Webdriver.FindElement(By.XPath("//div[@class='board-tile-details-name']"));
        
        //Methods

        public bool IsCardListExists() => cardList.Displayed;
        public void ClicklnkAddAnotherCard()
        {
            //loginpage.waitForPageUntilElementIsVisible(By.XPath("//span[@class='js-add-another-card']"), 5);
            Thread.Sleep(5000);
            linkAddAnotherCard.Click();
        }
        public void EnterCardTitle()
        {
            //loginpage.waitForPageUntilElementIsVisible(By.XPath("//textarea[@class='list-card-composer-textarea js-card-title']"), 5);
            Thread.Sleep(5000);
            txtCardTitle.SendKeys("title");
        }
        public void ClickAddCard() => btnAddCard.Click();

        public bool IsTileBoardExists() => tileBoard.Displayed;

    }
}
