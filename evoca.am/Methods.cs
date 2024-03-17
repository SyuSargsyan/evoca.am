using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using evoca.am.data;
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
            Click(evocabankPaymentButton);
            Assert.Pass();

            
            //actions.Click(instancePaymentButton);
            //BaseActions baseActions = new BaseActions(driver);
            //baseActions.Click(instancePaymentButton);


        }

    }
}
