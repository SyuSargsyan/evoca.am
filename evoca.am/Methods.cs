using evoca.am.data;
using NUnit.Framework.Internal.Commands;
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

        public void loanEarlyRepaymentFunctionality()
        {
            Click(instancePaymentButton);
            Thread.Sleep(10000);
            driver.SwitchTo().Window((driver.WindowHandles[1]));
            Click(evocabankPaymentButton);
            Click(loanRepaymentButton);
            Thread.Sleep(1000);
            Click(loanEarlyRepaymentButton);
            SendKey(loanEarlyAggrementInput,Client.testClinet.Loan);
            Click(continueLoanEarlyPaymentButton);
            string expectedResult = "Վարկի մայր գումարի վաղաժամկետ մարում";
            wait.Until(e => e.FindElement(actualResOfLoanEarlyPaymentButton));
            Thread.Sleep(2000);
            string actualResult = driver.FindElement(actualResOfLoanEarlyPaymentButton).Text;
            Assert.AreEqual(expectedResult, actualResult);  
        }
        public void loanRefularRepaymentFunctionality()
        {
            Click(instancePaymentButton);
            Thread.Sleep(10000);
            driver.SwitchTo().Window((driver.WindowHandles[1]));
            Click(evocabankPaymentButton);
            Click(loanRepaymentButton);
            Thread.Sleep(1000);
            Click(redularRepaymentButton);
            SendKey(loanRegularAggrementInput, Client.testClinet.Loan);
            Click(continueLoanRegularPaymentButton);
            string expectedResult = "Հերթական մարում";
            wait.Until(e => e.FindElement(actualResofLoanRegPaymentButton));
            Thread.Sleep(2000);
            string actualResult = driver.FindElement(actualResofLoanRegPaymentButton).Text;
            Assert.AreEqual(expectedResult, actualResult);

            //    IWebElement listiku = driver.FindElement(listik);
            //    IList<IWebElement> listof = listiku.FindElements(By.TagName("li"));
            //    IWebElement card = listof[1];
            //    card.Click();
            //    //driver.FindElement((By)card).Click();
            ////Click(card);
            //    Actions action = new Actions(driver);
            //    IWebElement element = driver.FindElement(mc);
            //    action.MoveToElement((IWebElement)element).Perform();
            //    //action.DragAndDropToOffset(element);
            //    //action.MoveToLocation(IWebElement)element);
            //    action.ContextClick(element).Perform();

        }

        public void AccountReplenishmentFunctionality()
        {
            Click(instancePaymentButton);
            Thread.Sleep(10000);
            driver.SwitchTo().Window((driver.WindowHandles[1]));
            Click(evocabankPaymentButton);
            Click(accounReplenishmentButton);
            SendKey(accountInput, Client.testClinet.Account);
            Click(continueAccountReplenishmentButton);
            string ExpectedResult = "Հաշվի համալրում";
            wait.Until(e => e.FindElement(actualResOfAccountReplenishement));
            Thread.Sleep(2000);
            string ActualResult = driver.FindElement(actualResOfAccountReplenishement).Text;
            Assert.AreEqual(ExpectedResult, ActualResult);
        }
        public void CardRelenishementFunctionality() 
        {
            Click(instancePaymentButton);
            Thread.Sleep(10000);
            driver.SwitchTo().Window((driver.WindowHandles[1]));
            Click(evocabankPaymentButton);
            Click(cardReplenishementButton);
            SendKey(cardInput, Client.testClinet.Card);
            Click(continueCardReblenishementButton);
            string ExpectedResult = "Քարտի համալրում";
            wait.Until(e => e.FindElement(actualResOfCardReplenishement));
            Thread.Sleep(3000);
            string ActualResult = driver.FindElement(actualResOfCardReplenishement).Text;
            Assert.AreEqual(ExpectedResult, ActualResult);
        }
        public void CardToCardTransactionFunctionality ()
        {
            Click(instancePaymentButton);
            Thread.Sleep(10000);
            driver.SwitchTo().Window((driver.WindowHandles[1]));
            Click(cardTocardTransactionButton);
            Click(cardTocardTransactionInAM);
            Click(currencyDropdownForC2C);
            IWebElement dropdownButton = driver.FindElement(currencyDropdownForC2C);
            IList<IWebElement> currencyList = dropdownButton.FindElements(By.TagName("option"));
            IWebElement usd = currencyList[1];
            ClickElement(usd);
            Click(continueC2CForAM);
            Click(payC2CButton);
            Thread.Sleep(3000); 
            driver.SwitchTo().Window(driver.WindowHandles[2]);
            wait.Until(e => e.FindElement(arcaPageForC2C));
            Assert.IsTrue(driver.FindElement(arcaPageForC2C).Displayed);
        }
        public void viveMobilePaymentFunctionality ()
        {
            Click(instancePaymentButton);
            Thread.Sleep(10000);
            driver.SwitchTo().Window((driver.WindowHandles[1]));
            Click(mobileButton);
            Click(vivaMobileButton);
            SendKey(vivaMobileInput, Client.SyuneSargsyan.Mobile.VivaProvider);
            Click(continueVivaPaymentButton);
            Click(payVivaPaymentButton);
            driver.SwitchTo().Window(driver.WindowHandles[2]);
            wait.Until(e => e.FindElement(arcaViva));
            Assert.IsTrue(driver.FindElement(arcaViva).Displayed);





        }
    }
}
