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
        protected By cardTocardTransactionButton = By.CssSelector("body > app-root > div > app-providers-home > app-providers > div > div.flex-box > div:nth-child(2) > app-provider-item > div");
        protected By cardTocardTransactionInAM = By.CssSelector("body > app-root > div > app-providers-home > app-providers > div > div.flex-box > div > app-provider-item > div");
        protected By currencyDropdownForC2C = By.Id("input_741");
        protected By messageForC2C = By.CssSelector("#input_742");
        protected By continueC2CForAM = By.CssSelector("body > app-root > div > app-provider > div > div > form > div.form-container > div:nth-child(2)");
        protected By payC2CButton = By.CssSelector("body > app-root > div > app-check-provider > div > form > div > button");
        protected By arcaPageForC2C = By.CssSelector("#formContainer > div");
        protected By mobileButton = By.CssSelector("body > app-root > div > app-providers-home > app-providers > div > div.flex-box > div:nth-child(4) > app-provider-item > div");
        protected By vivaMobileButton = By.CssSelector("body > app-root > div > app-providers-home > app-providers > div > div.flex-box > div:nth-child(2) > app-provider-item > div > div");
        protected By vivaMobileInput = By.CssSelector("#input_17");
        protected By continueVivaPaymentButton = By.CssSelector("body > app-root > div > app-provider > div > div > form > div.form-container > div:nth-child(2) > button");
        protected By payVivaPaymentButton = By.CssSelector("body > app-root > div > app-check-provider > div > form > div > button");
        protected By arcaViva = By.Id("formPayment");
        protected By uComMobileButton = By.CssSelector("body > app-root > div > app-providers-home > app-providers > div > div.flex-box > div:nth-child(3) > app-provider-item > div");
        protected By uComMobileInput = By.CssSelector("#input_16");
        protected By uComContinueButton = By.CssSelector("body > app-root > div > app-provider > div > div > form > div.form-container > div:nth-child(2) > button");
        protected By teamsMobileButton = By.CssSelector("body > app-root > div > app-providers-home > app-providers > div > div.flex-box > div:nth-child(1) > app-provider-item > div > div");
        protected By teamsMobileInput = By.CssSelector("#input_12");
        protected By teamsContinueButton = By.CssSelector("body > app-root > div > app-provider > div > div > form > div.form-container > div:nth-child(2) > button");

        protected By mc = By.CssSelector("body > main > div > div > ul > li:nth-child(14) > div > div > a");
        protected By listik = By.CssSelector("#second-level-1 > div > ul");
    }
}
