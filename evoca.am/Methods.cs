﻿using NUnit.Framework.Internal.Commands;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace evoca.am
{
    public class Methods : BaseActions
    {
        public Methods(IWebDriver driver) : base(driver)
        {
        }

        public void TestCasesmethods()
        {
            //Actions actions = new Actions(driver);
            //actions.Click(instancePaymentButton);
            Click(instancePaymentButton);
            Thread.Sleep(10000);
            driver.SwitchTo().Window((driver.WindowHandles[0]));
            wait.Until(e => e.FindElement(instancePaymentButton));
            Assert.IsTrue(driver.FindElement(instancePaymentButton).Displayed);
            //Click(evocabankPaymentButton);
            //Thread.Sleep(10000);
            //wait.Until(e => e.FindElement(loanRepaymentButton));
            //Click(loanRepaymentButton);
         
            //Assert.Pass();
            //Assert.IsTrue(driver.FindElement(loanRepaymentButton).Displayed);
            //string ass = "Վարկի մարում";
            //var but = driver.FindElement(loanRepaymentButton).Text;
            //Assert.AreEqual(ass, but);
            
            //actions.Click(instancePaymentButton);
            //BaseActions baseActions = new BaseActions(driver);
            //baseActions.Click(instancePaymentButton);


        }
        public void cardmenu()
        {
            IWebElement listiku = driver.FindElement(listik);
            IList<IWebElement> listof = listiku.FindElements(By.TagName("li"));
            IWebElement card = listof[1];
            card.Click();
            //driver.FindElement((By)card).Click();
        //Click(card);
            Actions action = new Actions(driver);
            IWebElement element = driver.FindElement(mc);
            action.MoveToElement((IWebElement)element).Perform();
            //action.DragAndDropToOffset(element);
            //action.MoveToLocation(IWebElement)element);
            action.ContextClick(element).Perform();
            
        }
    }
}
