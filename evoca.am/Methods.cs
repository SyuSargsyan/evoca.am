using OpenQA.Selenium;

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
            //Thread.Sleep(10000);
            driver.SwitchTo().Window((driver.WindowHandles[1]));
            wait.Until(e => e.FindElement(evocabankPaymentButton));
            Click(evocabankPaymentButton);
            //Thread.Sleep(10000);
            wait.Until(e => e.FindElement(loanRepaymentButton));
            Click(loanRepaymentButton);
            //Assert.Pass();
            //Assert.IsTrue(driver.FindElement(loanRepaymentButton).Displayed);
            //string ass = "Վարկի մարում";
            //var but = driver.FindElement(loanRepaymentButton).Text;
            //Assert.AreEqual(ass, but);
            
            //actions.Click(instancePaymentButton);
            //BaseActions baseActions = new BaseActions(driver);
            //baseActions.Click(instancePaymentButton);


        }

    }
}
