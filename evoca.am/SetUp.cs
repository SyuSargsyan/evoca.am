using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using evoca.am.data;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace evoca.am
{
    public class SetUp
    {
        public Methods methods;
        public IWebDriver driver;

        [SetUp]
        public void SetUpClass()
        {

            driver = new ChromeDriver();
            methods = new Methods(driver);
            methods.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            Url.currentUrl = Url.liveUrl;
            Client.testClinet = Client.SyuneSargsyan;
            driver.Navigate().GoToUrl(Url.currentUrl.urlValue);
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void tearDownMethod()
        {
            driver.Quit();
        }

    }
}
