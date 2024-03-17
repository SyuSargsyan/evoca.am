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
        protected By loanEarlyRepaymentButton = By.CssSelector("body > app-root > div > app-providers-home > app-providers > div > div.flex-box > div:nth-child(1)");
        protected By redularRepaymentButton = By.CssSelector("body > app-root > div > app-providers-home > app-providers > div > div.flex-box > div:nth-child(2) > app-provider-item > div > div");
        protected By loanAggrementInput = By.Id("input_1394");
        protected By pay = By.CssSelector("body > app-root > div > app-check-provider > div > form > div > button");
    }
}
