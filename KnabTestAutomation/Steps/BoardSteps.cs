using KnabTestAutomation.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace KnabTestAutomation.Steps

{
    [Binding]
    public class BoardSteps
    {

        //Anti-Context Injection code - Not recommended
        BoardPage boardpage = null;
        LoginPage loginpage = null;

        [When(@"I open a board")]
        public void GivenIOpenABoard()
        {
            loginpage.ClickBoard();
        }


        [When(@"I create a new card")]
        public void GivenICreateANewCard()
        {
            boardpage.ClicklnkAddAnotherCard();
            boardpage.EnterCardTitle();
            boardpage.ClickAddCard();
        }

        [Then(@"that card should be present in the list")]
        public void ThenThatCardShouldBePresentInTheList()
        {

        }

    }
}
