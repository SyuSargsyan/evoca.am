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
            Click(loanEarlyRepaymentButton);
            SendKey(loanEarlyAggrementInput,Loan.testLoan.LoanContract);
            Click(continueLoanEarlyPayment);
            string expectedResult = "Վարկի մայր գումարի վաղաժամկետ մարում";
            string actualResult = driver.FindElement(actualResOfLoanPayment).Text;
            Assert.AreEqual(expectedResult, actualResult);  
        }
        public void loanRepaymentFunctionality()
        {
            Click(instancePaymentButton);
            Thread.Sleep(10000);
            driver.SwitchTo().Window((driver.WindowHandles[1]));
            Click(evocabankPaymentButton);
            Click(loanRepaymentButton);
            Click(redularRepaymentButton);
            SendKey(loanRegularAggrementInput, Loan.testLoan.LoanContract);
            Click(continueLoanRegularPayment);





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
    }
}
