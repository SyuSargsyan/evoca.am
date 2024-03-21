using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evoca.am
{
    public abstract class Fields
    {
        public IWebElement element;
        protected IWebDriver driver;
        public TimeSpan timeout;
        public WebDriverWait wait;
     
        protected By instancePaymentButton = By.CssSelector("body > header > div.top-box > div > div.menu.no-wrap > ul > li:nth-child(3) > a");
        protected By evocabankPaymentButton = By.CssSelector("body > app-root > div > app-providers-home > app-providers > div > div.flex-box > div:nth-child(1)");
        protected By loanRepaymentButton = By.CssSelector("body > app-root > div > app-providers-home > app-providers > div > div.flex-box > div:nth-child(1)");
        protected By accountReplenishmentButton = By.CssSelector("body > app-root > div > app-providers-home > app-providers > div > div.flex-box > div:nth-child(2) > app-provider-item > div");
        protected By cardReplenishmentButton = By.CssSelector("body > app-root > div > app-providers-home > app-providers > div > div.flex-box > div:nth-child(3) > app-provider-item");
        protected By loanEarlyRepaymentButton = By.CssSelector("body > app-root > div > app-providers-home > app-providers > div > div.flex-box > div:nth-child(1) > app-provider-item > div > div");
        protected By redularRepaymentButton = By.CssSelector("body > app-root > div > app-providers-home > app-providers > div > div.flex-box > div:nth-child(2) > app-provider-item > div > div");
        protected By loanEarlyAggrementInput = By.CssSelector("#input_1394");
        protected By loanRegularAggrementInput = By.CssSelector("#input_1");
        protected By continueLoanEarlyPaymentButton = By.CssSelector("body > app-root > div > app-provider > div > div > form > div.form-container > div:nth-child(2)");
        protected By continueLoanRegularPaymentButton = By.CssSelector("body > app-root > div > app-provider > div > div > form > div.form-container > div:nth-child(2)");
        protected By pay = By.CssSelector("body > app-root > div > app-check-provider > div > form > div > button");
        protected By actualResOfLoanEarlyPaymentButton = By.CssSelector("body > app-root > div > app-check-provider > div > form > h2");
        protected By actualResofLoanRegPaymentButton = By.CssSelector("body > app-root > div > app-check-provider > div > form > h2");
        protected By accounReplenishmentButton = By.CssSelector("body > app-root > div > app-providers-home > app-providers > div > div.flex-box > div:nth-child(2) > app-provider-item");
        protected By accountInput = By.CssSelector("#input_3");
        protected By continueAccountReplenishmentButton = By.CssSelector("body > app-root > div > app-provider > div > div > form > div.form-container > div:nth-child(2) > button");
        protected By actualResOfAccountReplenishement = By.CssSelector("body > app-root > div > app-check-provider > div > form > h2");
        protected By cardReplenishementButton = By.CssSelector("body > app-root > div > app-providers-home > app-providers > div > div.flex-box > div:nth-child(3) > app-provider-item");
        protected By cardInput = By.CssSelector("#input_4");
        protected By continueCardReblenishementButton = By.CssSelector("body > app-root > div > app-provider > div > div > form > div.form-container > div:nth-child(2)");
        protected By actualResOfCardReplenishement = By.CssSelector("body > app-root > div > app-check-provider > div > form > h2");
        
        protected By mc = By.CssSelector("body > main > div > div > ul > li:nth-child(14) > div > div > a");
        protected By listik = By.CssSelector("#second-level-1 > div > ul");
    }
}
