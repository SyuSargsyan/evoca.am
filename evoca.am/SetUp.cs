using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using evoca.am.data;
using OpenQA.Selenium.Support.UI;

namespace evoca.am
{
    public class SetUp
    {
        public Methods methods;

        [SetUp]
        public void SetUpClass()
        {

            var driver = new ChromeDriver();
            methods = new Methods(driver);
            methods.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            Url.currentUrl = Url.liveUrl;
            driver.Navigate().GoToUrl(Url.currentUrl.urlValue);
            driver.Manage().Window.Maximize();
        }
    }
}
